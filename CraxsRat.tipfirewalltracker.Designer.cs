﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;



/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class CraxsRat_tipfirewalltracker {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal CraxsRat_tipfirewalltracker() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CraxsRat.tipfirewalltracker", typeof(CraxsRat_tipfirewalltracker).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The firewall will make the  act as a VPN:
    ///
    ///why this?
    ///- It does not affect the speed of the internet at all
    ///
    ///- Craxs app helps with long connection
    ///
    ///Prevent the system from killing apps in the background
    ///
    ///Allows you to cut off the internet for selected applications
    ///
    ///NOTE: to cut off the internet, first block the app, then activate the firewall.
    /// </summary>
    internal static string FWtext_Text {
        get {
            return ResourceManager.GetString("FWtext.Text", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized resource of type System.Drawing.Bitmap.
    /// </summary>
    internal static System.Drawing.Bitmap PictureBox1_Image {
        get {
            object obj = ResourceManager.GetObject("PictureBox1.Image", resourceCulture);
            return ((System.Drawing.Bitmap)(obj));
        }
    }
}
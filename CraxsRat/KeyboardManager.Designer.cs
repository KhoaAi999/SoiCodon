﻿// Token: 0x02000087 RID: 135
//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class KeyboardManager : global::System.Windows.Forms.Form
{
	// Token: 0x06000629 RID: 1577 RVA: 0x0009E328 File Offset: 0x0009C528
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

	// Token: 0x0600062A RID: 1578 RVA: 0x0009E36C File Offset: 0x0009C56C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.checkenable = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.checkselected = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.checkkeypermission = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.savebutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label5 = new global::System.Windows.Forms.Label();
		this.montext = new global::System.Windows.Forms.Label();
		this.Label4 = new global::System.Windows.Forms.Label();
		this.Label3 = new global::System.Windows.Forms.Label();
		this.acttext = new global::System.Windows.Forms.Label();
		this.primtext = new global::System.Windows.Forms.Label();
		this.checkbutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.statustext = new global::System.Windows.Forms.TextBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.checkbutton.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
		this.savebutton.Click += new global::System.EventHandler(this.DrakeUIButtonIcon2_Click);
		this.checkenable.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkenable_MouseClick);
		this.checkselected.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkselected_MouseClick);
		this.checkkeypermission.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkkeypermission_MouseClick);
		this.Panel1.Controls.Add(this.checkenable);
		this.Panel1.Controls.Add(this.checkselected);
		this.Panel1.Controls.Add(this.checkkeypermission);
		this.Panel1.Controls.Add(this.savebutton);
		this.Panel1.Controls.Add(this.Label5);
		this.Panel1.Controls.Add(this.montext);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.acttext);
		this.Panel1.Controls.Add(this.primtext);
		this.Panel1.Controls.Add(this.checkbutton);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(315, 482);
		this.Panel1.TabIndex = 0;
		this.checkenable.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkenable.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkenable.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkenable.Location = new global::System.Drawing.Point(45, 381);
		this.checkenable.Name = "checkenable";
		this.checkenable.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkenable.Size = new global::System.Drawing.Size(60, 29);
		this.checkenable.TabIndex = 22;
		this.checkselected.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkselected.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkselected.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkselected.Location = new global::System.Drawing.Point(45, 288);
		this.checkselected.Name = "checkselected";
		this.checkselected.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkselected.Size = new global::System.Drawing.Size(60, 29);
		this.checkselected.TabIndex = 21;
		this.checkkeypermission.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkkeypermission.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkkeypermission.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkkeypermission.Location = new global::System.Drawing.Point(45, 186);
		this.checkkeypermission.Name = "checkkeypermission";
		this.checkkeypermission.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkeypermission.Size = new global::System.Drawing.Size(60, 29);
		this.checkkeypermission.TabIndex = 20;
		this.savebutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.savebutton.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.savebutton.FillColor = global::System.Drawing.Color.Black;
		this.savebutton.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.savebutton.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebutton.Location = new global::System.Drawing.Point(0, 61);
		this.savebutton.Name = "savebutton";
		this.savebutton.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebutton.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.savebutton.Size = new global::System.Drawing.Size(315, 61);
		this.savebutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.savebutton.Symbol = 61639;
		this.savebutton.TabIndex = 19;
		this.savebutton.Text = "Save logs";
		this.Label5.AutoSize = true;
		this.Label5.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label5.ForeColor = global::System.Drawing.Color.White;
		this.Label5.Location = new global::System.Drawing.Point(10, 385);
		this.Label5.Name = "Label5";
		this.Label5.Size = new global::System.Drawing.Size(23, 25);
		this.Label5.TabIndex = 18;
		this.Label5.Text = "3";
		this.montext.AutoSize = true;
		this.montext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.montext.ForeColor = global::System.Drawing.Color.White;
		this.montext.Location = new global::System.Drawing.Point(159, 385);
		this.montext.Name = "montext";
		this.montext.Size = new global::System.Drawing.Size(77, 25);
		this.montext.TabIndex = 17;
		this.montext.Text = "Monitor";
		this.Label4.AutoSize = true;
		this.Label4.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label4.ForeColor = global::System.Drawing.Color.White;
		this.Label4.Location = new global::System.Drawing.Point(10, 288);
		this.Label4.Name = "Label4";
		this.Label4.Size = new global::System.Drawing.Size(23, 25);
		this.Label4.TabIndex = 15;
		this.Label4.Text = "2";
		this.Label3.AutoSize = true;
		this.Label3.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label3.ForeColor = global::System.Drawing.Color.White;
		this.Label3.Location = new global::System.Drawing.Point(16, 186);
		this.Label3.Name = "Label3";
		this.Label3.Size = new global::System.Drawing.Size(23, 25);
		this.Label3.TabIndex = 14;
		this.Label3.Text = "1";
		this.acttext.AutoSize = true;
		this.acttext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.acttext.ForeColor = global::System.Drawing.Color.White;
		this.acttext.Location = new global::System.Drawing.Point(148, 288);
		this.acttext.Name = "acttext";
		this.acttext.Size = new global::System.Drawing.Size(101, 25);
		this.acttext.TabIndex = 13;
		this.acttext.Text = "Set Active";
		this.primtext.AutoSize = true;
		this.primtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.primtext.ForeColor = global::System.Drawing.Color.White;
		this.primtext.Location = new global::System.Drawing.Point(111, 186);
		this.primtext.Name = "primtext";
		this.primtext.Size = new global::System.Drawing.Size(198, 25);
		this.primtext.TabIndex = 11;
		this.primtext.Text = "Keyboard Permission";
		this.checkbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkbutton.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.checkbutton.FillColor = global::System.Drawing.Color.Black;
		this.checkbutton.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkbutton.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkbutton.Location = new global::System.Drawing.Point(0, 0);
		this.checkbutton.Name = "checkbutton";
		this.checkbutton.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkbutton.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.checkbutton.Size = new global::System.Drawing.Size(315, 61);
		this.checkbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.checkbutton.Symbol = 61473;
		this.checkbutton.TabIndex = 0;
		this.checkbutton.Text = "Check Permission";
		this.statustext.BackColor = global::System.Drawing.Color.Black;
		this.statustext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.statustext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.ForeColor = global::System.Drawing.Color.Lime;
		this.statustext.Location = new global::System.Drawing.Point(325, 0);
		this.statustext.Multiline = true;
		this.statustext.Name = "statustext";
		this.statustext.ReadOnly = true;
		this.statustext.Size = new global::System.Drawing.Size(780, 482);
		this.statustext.TabIndex = 1;
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new global::System.Drawing.Point(315, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(10, 482);
		this.Panel2.TabIndex = 2;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(1105, 482);
		base.Controls.Add(this.statustext);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		this.MinimumSize = new global::System.Drawing.Size(1011, 490);
		base.Name = "KeyboardManager";
		base.ShowIcon = false;
		this.Text = "KeyboardManager";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040008F7 RID: 2295
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040008FE RID: 2302
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040008FF RID: 2303
	internal global::DrakeUI.Framework.DrakeUIButtonIcon checkbutton;

	// Token: 0x04000900 RID: 2304
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
	internal global::System.Windows.Forms.Label Label4;

	// Token: 0x04000901 RID: 2305
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label3")]
	internal global::System.Windows.Forms.Label Label3;

	// Token: 0x04000902 RID: 2306
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("acttext")]
	internal global::System.Windows.Forms.Label acttext;

	// Token: 0x04000903 RID: 2307
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("primtext")]
	internal global::System.Windows.Forms.Label primtext;

	// Token: 0x04000904 RID: 2308
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("statustext")]
	internal global::System.Windows.Forms.TextBox statustext;

	// Token: 0x04000905 RID: 2309
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label5")]
	internal global::System.Windows.Forms.Label Label5;

	// Token: 0x04000906 RID: 2310
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("montext")]
	internal global::System.Windows.Forms.Label montext;

	// Token: 0x04000907 RID: 2311
	internal global::DrakeUI.Framework.DrakeUIButtonIcon savebutton;

	// Token: 0x04000908 RID: 2312
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000909 RID: 2313
	internal global::DrakeUI.Framework.DrakeUICheckBox checkenable;

	// Token: 0x0400090A RID: 2314
	internal global::DrakeUI.Framework.DrakeUICheckBox checkselected;

	// Token: 0x0400090B RID: 2315
	internal global::DrakeUI.Framework.DrakeUICheckBox checkkeypermission;
}

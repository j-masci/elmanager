﻿using Elmanager.CustomControls;

namespace Elmanager.Forms
{
	public partial class RenameForm
		{
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components = null;
		
		//The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		private void InitializeComponent()
			{
            this.Label1 = new System.Windows.Forms.Label();
            this.RenameSelectedButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.NickBox = new System.Windows.Forms.TextBox();
            this.PatternBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(42, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(251, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Example pattern: LNT=Level+Nickname+Time";
            // 
            // RenameSelectedButton
            // 
            this.RenameSelectedButton.AutoSize = true;
            this.RenameSelectedButton.Location = new System.Drawing.Point(96, 120);
            this.RenameSelectedButton.Name = "RenameSelectedButton";
            this.RenameSelectedButton.Size = new System.Drawing.Size(149, 25);
            this.RenameSelectedButton.TabIndex = 2;
            this.RenameSelectedButton.Text = "Rename selected replays";
            this.RenameSelectedButton.UseVisualStyleBackColor = true;
            this.RenameSelectedButton.Click += new System.EventHandler(this.RenameSelected);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(102, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 15);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Nickname:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(118, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 15);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Pattern:";
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(172, 61);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(67, 23);
            this.NickBox.TabIndex = 4;
            this.NickBox.Text = "Nick";
            // 
            // PatternBox
            // 
            this.PatternBox.Location = new System.Drawing.Point(172, 87);
            this.PatternBox.MaxLength = 3;
            this.PatternBox.Name = "PatternBox";
            this.PatternBox.Size = new System.Drawing.Size(67, 23);
            this.PatternBox.TabIndex = 1;
            this.PatternBox.Text = "LNT";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 29);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(321, 15);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Letters: L=Level, N=Nickname, T=Time, F=Current filename";
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(341, 157);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.NickBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.RenameSelectedButton);
            this.Controls.Add(this.PatternBox);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 164);
            this.Name = "RenameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rename with pattern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox PatternBox;
		internal System.Windows.Forms.Button RenameSelectedButton;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox NickBox;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
	}
	
}

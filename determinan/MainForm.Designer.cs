/*
 * Created by SharpDevelop.
 * User: Meysam
 * Date: 1/7/2018
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace determinan
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonResult;
		private System.Windows.Forms.TextBox mat11;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.TextBox mat21;
		private System.Windows.Forms.TextBox mat31;
		private System.Windows.Forms.TextBox mat12;
		private System.Windows.Forms.TextBox mat22;
		private System.Windows.Forms.TextBox mat32;
		private System.Windows.Forms.TextBox mat13;
		private System.Windows.Forms.TextBox mat23;
		private System.Windows.Forms.TextBox mat33;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonResult = new System.Windows.Forms.Button();
			this.mat11 = new System.Windows.Forms.TextBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.mat21 = new System.Windows.Forms.TextBox();
			this.mat31 = new System.Windows.Forms.TextBox();
			this.mat12 = new System.Windows.Forms.TextBox();
			this.mat22 = new System.Windows.Forms.TextBox();
			this.mat32 = new System.Windows.Forms.TextBox();
			this.mat13 = new System.Windows.Forms.TextBox();
			this.mat23 = new System.Windows.Forms.TextBox();
			this.mat33 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonResult
			// 
			this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonResult.Location = new System.Drawing.Point(16, 114);
			this.buttonResult.MaximumSize = new System.Drawing.Size(96, 23);
			this.buttonResult.MinimumSize = new System.Drawing.Size(96, 23);
			this.buttonResult.Name = "buttonResult";
			this.buttonResult.Size = new System.Drawing.Size(96, 23);
			this.buttonResult.TabIndex = 9;
			this.buttonResult.Text = "calculate";
			this.buttonResult.UseVisualStyleBackColor = true;
			this.buttonResult.Click += new System.EventHandler(this.ButtonResultClick);
			// 
			// mat11
			// 
			this.mat11.Location = new System.Drawing.Point(16, 12);
			this.mat11.Name = "mat11";
			this.mat11.Size = new System.Drawing.Size(28, 20);
			this.mat11.TabIndex = 0;
			this.mat11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelResult
			// 
			this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelResult.Location = new System.Drawing.Point(16, 88);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(96, 23);
			this.labelResult.TabIndex = 2;
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mat21
			// 
			this.mat21.Location = new System.Drawing.Point(16, 38);
			this.mat21.Name = "mat21";
			this.mat21.Size = new System.Drawing.Size(28, 20);
			this.mat21.TabIndex = 3;
			this.mat21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat31
			// 
			this.mat31.Location = new System.Drawing.Point(16, 64);
			this.mat31.Name = "mat31";
			this.mat31.Size = new System.Drawing.Size(28, 20);
			this.mat31.TabIndex = 6;
			this.mat31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat12
			// 
			this.mat12.Location = new System.Drawing.Point(50, 12);
			this.mat12.Name = "mat12";
			this.mat12.Size = new System.Drawing.Size(28, 20);
			this.mat12.TabIndex = 1;
			this.mat12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat22
			// 
			this.mat22.Location = new System.Drawing.Point(50, 38);
			this.mat22.Name = "mat22";
			this.mat22.Size = new System.Drawing.Size(28, 20);
			this.mat22.TabIndex = 4;
			this.mat22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat32
			// 
			this.mat32.Location = new System.Drawing.Point(50, 64);
			this.mat32.Name = "mat32";
			this.mat32.Size = new System.Drawing.Size(28, 20);
			this.mat32.TabIndex = 7;
			this.mat32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat13
			// 
			this.mat13.Location = new System.Drawing.Point(84, 12);
			this.mat13.Name = "mat13";
			this.mat13.Size = new System.Drawing.Size(28, 20);
			this.mat13.TabIndex = 2;
			this.mat13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat23
			// 
			this.mat23.Location = new System.Drawing.Point(84, 38);
			this.mat23.Name = "mat23";
			this.mat23.Size = new System.Drawing.Size(28, 20);
			this.mat23.TabIndex = 5;
			this.mat23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mat33
			// 
			this.mat33.Location = new System.Drawing.Point(84, 64);
			this.mat33.Name = "mat33";
			this.mat33.Size = new System.Drawing.Size(28, 20);
			this.mat33.TabIndex = 8;
			this.mat33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonResult;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(142, 149);
			this.Controls.Add(this.mat33);
			this.Controls.Add(this.mat32);
			this.Controls.Add(this.mat31);
			this.Controls.Add(this.mat23);
			this.Controls.Add(this.mat22);
			this.Controls.Add(this.mat21);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.mat13);
			this.Controls.Add(this.mat12);
			this.Controls.Add(this.mat11);
			this.Controls.Add(this.buttonResult);
			this.MaximumSize = new System.Drawing.Size(158, 188);
			this.MinimumSize = new System.Drawing.Size(158, 188);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "determinan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Gabi
 * Date: 20.05.2009
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Beautiful_Wallpapers
{
	partial class FHelp
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHelp));
			this.tab_Help = new System.Windows.Forms.TabControl();
			this.tab_About = new System.Windows.Forms.TabPage();
			this.linklabel_Site = new System.Windows.Forms.LinkLabel();
			this.rtxt_Text = new System.Windows.Forms.RichTextBox();
			this.lbl_Titlu = new System.Windows.Forms.Label();
			this.pbox_Image = new System.Windows.Forms.PictureBox();
			this.tab_Changelog = new System.Windows.Forms.TabPage();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Donate = new System.Windows.Forms.Button();
			this.btn_CheckUpdate = new System.Windows.Forms.Button();
			this.tab_Help.SuspendLayout();
			this.tab_About.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Image)).BeginInit();
			this.tab_Changelog.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_Help
			// 
			this.tab_Help.Controls.Add(this.tab_About);
			this.tab_Help.Controls.Add(this.tab_Changelog);
			this.tab_Help.Location = new System.Drawing.Point(0, 0);
			this.tab_Help.Name = "tab_Help";
			this.tab_Help.SelectedIndex = 0;
			this.tab_Help.Size = new System.Drawing.Size(329, 329);
			this.tab_Help.TabIndex = 0;
			// 
			// tab_About
			// 
			this.tab_About.BackColor = System.Drawing.SystemColors.Control;
			this.tab_About.Controls.Add(this.linklabel_Site);
			this.tab_About.Controls.Add(this.rtxt_Text);
			this.tab_About.Controls.Add(this.lbl_Titlu);
			this.tab_About.Controls.Add(this.pbox_Image);
			this.tab_About.Location = new System.Drawing.Point(4, 22);
			this.tab_About.Name = "tab_About";
			this.tab_About.Padding = new System.Windows.Forms.Padding(3);
			this.tab_About.Size = new System.Drawing.Size(321, 303);
			this.tab_About.TabIndex = 0;
			this.tab_About.Text = "About";
			// 
			// linklabel_Site
			// 
			this.linklabel_Site.AutoSize = true;
			this.linklabel_Site.Location = new System.Drawing.Point(19, 159);
			this.linklabel_Site.Name = "linklabel_Site";
			this.linklabel_Site.Size = new System.Drawing.Size(138, 13);
			this.linklabel_Site.TabIndex = 3;
			this.linklabel_Site.TabStop = true;
			this.linklabel_Site.Text = "http://wyrdaprogramming.tk";
			this.linklabel_Site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_Site_LinkClicked);
			// 
			// rtxt_Text
			// 
			this.rtxt_Text.BackColor = System.Drawing.SystemColors.Control;
			this.rtxt_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtxt_Text.Location = new System.Drawing.Point(19, 133);
			this.rtxt_Text.Name = "rtxt_Text";
			this.rtxt_Text.Size = new System.Drawing.Size(299, 164);
			this.rtxt_Text.TabIndex = 2;
			this.rtxt_Text.Text = resources.GetString("rtxt_Text.Text");
			// 
			// lbl_Titlu
			// 
			this.lbl_Titlu.Location = new System.Drawing.Point(165, 59);
			this.lbl_Titlu.Name = "lbl_Titlu";
			this.lbl_Titlu.Size = new System.Drawing.Size(138, 23);
			this.lbl_Titlu.TabIndex = 1;
			this.lbl_Titlu.Text = "Beautiful Wallpapers v2.5.2";
			// 
			// pbox_Image
			// 
			this.pbox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pbox_Image.Image = global::Beautiful_Wallpapers.Properties.Resources.img;
			this.pbox_Image.InitialImage = null;
			this.pbox_Image.Location = new System.Drawing.Point(8, 16);
			this.pbox_Image.Name = "pbox_Image";
			this.pbox_Image.Size = new System.Drawing.Size(134, 101);
			this.pbox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbox_Image.TabIndex = 0;
			this.pbox_Image.TabStop = false;
			// 
			// tab_Changelog
			// 
			this.tab_Changelog.Controls.Add(this.richTextBox2);
			this.tab_Changelog.Location = new System.Drawing.Point(4, 22);
			this.tab_Changelog.Name = "tab_Changelog";
			this.tab_Changelog.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Changelog.Size = new System.Drawing.Size(321, 303);
			this.tab_Changelog.TabIndex = 2;
			this.tab_Changelog.Text = "Changelog";
			this.tab_Changelog.UseVisualStyleBackColor = true;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(3, 3);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(315, 297);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
			// 
			// btn_Ok
			// 
			this.btn_Ok.Location = new System.Drawing.Point(244, 335);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 1;
			this.btn_Ok.Text = "OK";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.Btn_OkClick);
			// 
			// btn_Donate
			// 
			this.btn_Donate.Location = new System.Drawing.Point(8, 336);
			this.btn_Donate.Name = "btn_Donate";
			this.btn_Donate.Size = new System.Drawing.Size(75, 23);
			this.btn_Donate.TabIndex = 2;
			this.btn_Donate.Text = "Donate";
			this.btn_Donate.UseVisualStyleBackColor = true;
			this.btn_Donate.Click += new System.EventHandler(this.btn_Donate_Click);
			// 
			// btn_CheckUpdate
			// 
			this.btn_CheckUpdate.Location = new System.Drawing.Point(112, 336);
			this.btn_CheckUpdate.Name = "btn_CheckUpdate";
			this.btn_CheckUpdate.Size = new System.Drawing.Size(104, 23);
			this.btn_CheckUpdate.TabIndex = 3;
			this.btn_CheckUpdate.Text = "Check for update";
			this.btn_CheckUpdate.UseVisualStyleBackColor = true;
			this.btn_CheckUpdate.Visible = false;
			this.btn_CheckUpdate.Click += new System.EventHandler(this.btn_CheckUpdate_Click);
			// 
			// FHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 364);
			this.Controls.Add(this.btn_CheckUpdate);
			this.Controls.Add(this.btn_Donate);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.tab_Help);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FHelp";
			this.ShowInTaskbar = false;
			this.Text = "Help";
			this.tab_Help.ResumeLayout(false);
			this.tab_About.ResumeLayout(false);
			this.tab_About.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Image)).EndInit();
			this.tab_Changelog.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_Titlu;
		private System.Windows.Forms.RichTextBox rtxt_Text;
		private System.Windows.Forms.PictureBox pbox_Image;
		private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TabPage tab_Changelog;
		private System.Windows.Forms.TabPage tab_About;
		private System.Windows.Forms.TabControl tab_Help;
        private System.Windows.Forms.Button btn_Donate;
        private System.Windows.Forms.Button btn_CheckUpdate;
        private System.Windows.Forms.LinkLabel linklabel_Site;
	}
}

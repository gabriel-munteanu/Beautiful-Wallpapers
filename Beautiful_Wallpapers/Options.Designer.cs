/*
 * Created by SharpDevelop.
 * User: Gabi
 * Date: 18.05.2009
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Beautiful_Wallpapers
{
	partial class Options
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.cbox_startup = new System.Windows.Forms.CheckBox();
			this.groupbox_general = new System.Windows.Forms.GroupBox();
			this.lbl_Delay = new System.Windows.Forms.Label();
			this.txt_Delay = new System.Windows.Forms.TextBox();
			this.cbox_auto = new System.Windows.Forms.CheckBox();
			this.groupBox_lastpicture = new System.Windows.Forms.GroupBox();
			this.rbutton_announce = new System.Windows.Forms.RadioButton();
			this.rbuton_auto = new System.Windows.Forms.RadioButton();
			this.groupBox_SavePictures = new System.Windows.Forms.GroupBox();
			this.btn_SaveLocation = new System.Windows.Forms.Button();
			this.cbox_autosave = new System.Windows.Forms.CheckBox();
			this.folderDialog_SaveLocation = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip_SaveLocation = new System.Windows.Forms.ToolTip(this.components);
			this.groupbox_general.SuspendLayout();
			this.groupBox_lastpicture.SuspendLayout();
			this.groupBox_SavePictures.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_OK
			// 
			this.btn_OK.Location = new System.Drawing.Point(138, 263);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(68, 22);
			this.btn_OK.TabIndex = 0;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.Btn_OKClick);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(212, 263);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(68, 22);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
			// 
			// cbox_startup
			// 
			this.cbox_startup.Location = new System.Drawing.Point(6, 19);
			this.cbox_startup.Name = "cbox_startup";
			this.cbox_startup.Size = new System.Drawing.Size(104, 24);
			this.cbox_startup.TabIndex = 2;
			this.cbox_startup.Text = "Run at start up";
			this.cbox_startup.UseVisualStyleBackColor = true;
			this.cbox_startup.CheckedChanged += new System.EventHandler(this.cbox_startup_CheckedChanged);
			// 
			// groupbox_general
			// 
			this.groupbox_general.Controls.Add(this.lbl_Delay);
			this.groupbox_general.Controls.Add(this.txt_Delay);
			this.groupbox_general.Controls.Add(this.cbox_auto);
			this.groupbox_general.Controls.Add(this.cbox_startup);
			this.groupbox_general.Location = new System.Drawing.Point(12, 12);
			this.groupbox_general.Name = "groupbox_general";
			this.groupbox_general.Size = new System.Drawing.Size(268, 100);
			this.groupbox_general.TabIndex = 4;
			this.groupbox_general.TabStop = false;
			this.groupbox_general.Text = "General";
			// 
			// lbl_Delay
			// 
			this.lbl_Delay.AutoSize = true;
			this.lbl_Delay.Location = new System.Drawing.Point(32, 48);
			this.lbl_Delay.Name = "lbl_Delay";
			this.lbl_Delay.Size = new System.Drawing.Size(125, 13);
			this.lbl_Delay.TabIndex = 5;
			this.lbl_Delay.Text = "seconds delay at start up";
			// 
			// txt_Delay
			// 
			this.txt_Delay.Location = new System.Drawing.Point(4, 44);
			this.txt_Delay.MaxLength = 4;
			this.txt_Delay.Name = "txt_Delay";
			this.txt_Delay.Size = new System.Drawing.Size(28, 20);
			this.txt_Delay.TabIndex = 4;
			this.txt_Delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Delay_KeyPress);
			// 
			// cbox_auto
			// 
			this.cbox_auto.Location = new System.Drawing.Point(4, 68);
			this.cbox_auto.Name = "cbox_auto";
			this.cbox_auto.Size = new System.Drawing.Size(256, 24);
			this.cbox_auto.TabIndex = 3;
			this.cbox_auto.Text = "Automaticaly check for a new wallpaper(1 hour)";
			this.cbox_auto.UseVisualStyleBackColor = true;
			this.cbox_auto.CheckedChanged += new System.EventHandler(this.Cbox_autoCheckedChanged);
			// 
			// groupBox_lastpicture
			// 
			this.groupBox_lastpicture.Controls.Add(this.rbutton_announce);
			this.groupBox_lastpicture.Controls.Add(this.rbuton_auto);
			this.groupBox_lastpicture.Enabled = false;
			this.groupBox_lastpicture.Location = new System.Drawing.Point(12, 124);
			this.groupBox_lastpicture.Name = "groupBox_lastpicture";
			this.groupBox_lastpicture.Size = new System.Drawing.Size(268, 71);
			this.groupBox_lastpicture.TabIndex = 5;
			this.groupBox_lastpicture.TabStop = false;
			this.groupBox_lastpicture.Text = "New wallpaper found";
			// 
			// rbutton_announce
			// 
			this.rbutton_announce.Checked = true;
			this.rbutton_announce.Location = new System.Drawing.Point(6, 39);
			this.rbutton_announce.Name = "rbutton_announce";
			this.rbutton_announce.Size = new System.Drawing.Size(154, 24);
			this.rbutton_announce.TabIndex = 1;
			this.rbutton_announce.TabStop = true;
			this.rbutton_announce.Text = "Just announce me";
			this.rbutton_announce.UseVisualStyleBackColor = true;
			// 
			// rbuton_auto
			// 
			this.rbuton_auto.Location = new System.Drawing.Point(6, 19);
			this.rbuton_auto.Name = "rbuton_auto";
			this.rbuton_auto.Size = new System.Drawing.Size(218, 24);
			this.rbuton_auto.TabIndex = 0;
			this.rbuton_auto.Text = "Put it on the desktop automaticaly";
			this.rbuton_auto.UseVisualStyleBackColor = true;
			// 
			// groupBox_SavePictures
			// 
			this.groupBox_SavePictures.Controls.Add(this.btn_SaveLocation);
			this.groupBox_SavePictures.Controls.Add(this.cbox_autosave);
			this.groupBox_SavePictures.Location = new System.Drawing.Point(12, 201);
			this.groupBox_SavePictures.Name = "groupBox_SavePictures";
			this.groupBox_SavePictures.Size = new System.Drawing.Size(268, 56);
			this.groupBox_SavePictures.TabIndex = 6;
			this.groupBox_SavePictures.TabStop = false;
			this.groupBox_SavePictures.Text = "Save Pictures";
			// 
			// btn_SaveLocation
			// 
			this.btn_SaveLocation.Location = new System.Drawing.Point(155, 19);
			this.btn_SaveLocation.Name = "btn_SaveLocation";
			this.btn_SaveLocation.Size = new System.Drawing.Size(82, 23);
			this.btn_SaveLocation.TabIndex = 1;
			this.btn_SaveLocation.Text = "Save location";			
			this.btn_SaveLocation.UseVisualStyleBackColor = true;
			this.btn_SaveLocation.Click += new System.EventHandler(this.Btn_SaveLocationClick);
			// 
			// cbox_autosave
			// 
			this.cbox_autosave.Location = new System.Drawing.Point(6, 19);
			this.cbox_autosave.Name = "cbox_autosave";
			this.cbox_autosave.Size = new System.Drawing.Size(114, 24);
			this.cbox_autosave.TabIndex = 0;
			this.cbox_autosave.Text = "Auto save pictures";
			this.cbox_autosave.UseVisualStyleBackColor = true;
			// 
			// folderDialog_SaveLocation
			// 
			this.folderDialog_SaveLocation.Description = "Select a location where the pictures will be saved.";
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 296);
			this.Controls.Add(this.groupBox_SavePictures);
			this.Controls.Add(this.groupBox_lastpicture);
			this.Controls.Add(this.groupbox_general);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OptionsLoad);
			this.groupbox_general.ResumeLayout(false);
			this.groupbox_general.PerformLayout();
			this.groupBox_lastpicture.ResumeLayout(false);
			this.groupBox_SavePictures.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTip_SaveLocation;
		private System.Windows.Forms.FolderBrowserDialog folderDialog_SaveLocation;
		private System.Windows.Forms.CheckBox cbox_autosave;
		private System.Windows.Forms.Button btn_SaveLocation;
		private System.Windows.Forms.GroupBox groupBox_SavePictures;
		private System.Windows.Forms.RadioButton rbuton_auto;
		private System.Windows.Forms.RadioButton rbutton_announce;
		private System.Windows.Forms.GroupBox groupBox_lastpicture;
		private System.Windows.Forms.CheckBox cbox_auto;
		private System.Windows.Forms.GroupBox groupbox_general;
		private System.Windows.Forms.CheckBox cbox_startup;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Delay;
        private System.Windows.Forms.TextBox txt_Delay;
	}
}

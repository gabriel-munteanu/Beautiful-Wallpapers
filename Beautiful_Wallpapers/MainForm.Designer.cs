/*
 * Created by SharpDevelop.
 * User: Elev
 * Date: 3/27/2009
 * Time: 9:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Beautiful_Wallpapers
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbox_Ultima = new System.Windows.Forms.PictureBox();
			this.cmnu_Pictures = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_SavePicture = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Random = new System.Windows.Forms.Button();
			this.lbl_UltimaPoza = new System.Windows.Forms.Label();
			this.pbox_Random = new System.Windows.Forms.PictureBox();
			this.lbl_Random = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.b_WorkMain = new System.ComponentModel.BackgroundWorker();
			this.mnu_Meniu = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_LoadLast = new System.Windows.Forms.Button();
			this.b_WorkRandom = new System.ComponentModel.BackgroundWorker();
			this.nico_Icon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmnu_Icon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnu_icon_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.tmr_Check = new System.Windows.Forms.Timer(this.components);
			this.b_WorkCheck = new System.ComponentModel.BackgroundWorker();
			this.linkl_Link = new System.Windows.Forms.LinkLabel();
			this.lbl_Vote = new System.Windows.Forms.Label();
			this.lbl_Update = new System.Windows.Forms.Label();
			this.btn_Backbtn_Back = new System.Windows.Forms.Button();
			this.btn_Forward = new System.Windows.Forms.Button();
			this.lbl_NrPoza = new System.Windows.Forms.Label();
			this.b_WorkBF = new System.ComponentModel.BackgroundWorker();
			this.saveFDlg_SavePicture = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Ultima)).BeginInit();
			this.cmnu_Pictures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Random)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.mnu_Meniu.SuspendLayout();
			this.cmnu_Icon.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbox_Ultima
			// 
			this.pbox_Ultima.ContextMenuStrip = this.cmnu_Pictures;
			this.pbox_Ultima.Location = new System.Drawing.Point(45, 44);
			this.pbox_Ultima.Name = "pbox_Ultima";
			this.pbox_Ultima.Size = new System.Drawing.Size(286, 177);
			this.pbox_Ultima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbox_Ultima.TabIndex = 1;
			this.pbox_Ultima.TabStop = false;
			this.pbox_Ultima.DoubleClick += new System.EventHandler(this.Pbox_UltimaDoubleClick);
			this.pbox_Ultima.MouseLeave += new System.EventHandler(this.Pbox_UltimaMouseLeave);
			this.pbox_Ultima.MouseEnter += new System.EventHandler(this.Pbox_UltimaMouseEnter);
			// 
			// cmnu_Pictures
			// 
			this.cmnu_Pictures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btn_SavePicture});
			this.cmnu_Pictures.Name = "cmnu_Pictures";
			this.cmnu_Pictures.ShowImageMargin = false;
			this.cmnu_Pictures.Size = new System.Drawing.Size(121, 26);
			// 
			// btn_SavePicture
			// 
			this.btn_SavePicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_SavePicture.Name = "btn_SavePicture";
			this.btn_SavePicture.Size = new System.Drawing.Size(120, 22);
			this.btn_SavePicture.Text = "Save picture";
			this.btn_SavePicture.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.btn_SavePicture.Click += new System.EventHandler(this.Btn_SavePictureClick);
			// 
			// btn_Random
			// 
			this.btn_Random.Location = new System.Drawing.Point(203, 493);
			this.btn_Random.Name = "btn_Random";
			this.btn_Random.Size = new System.Drawing.Size(99, 34);
			this.btn_Random.TabIndex = 0;
			this.btn_Random.Text = "Random picture";
			this.btn_Random.UseVisualStyleBackColor = true;
			this.btn_Random.Click += new System.EventHandler(this.Btn_RandomClick);
			// 
			// lbl_UltimaPoza
			// 
			this.lbl_UltimaPoza.Location = new System.Drawing.Point(155, 25);
			this.lbl_UltimaPoza.Name = "lbl_UltimaPoza";
			this.lbl_UltimaPoza.Size = new System.Drawing.Size(68, 16);
			this.lbl_UltimaPoza.TabIndex = 2;
			this.lbl_UltimaPoza.Text = "Last Picture";
			// 
			// pbox_Random
			// 
			this.pbox_Random.BackColor = System.Drawing.SystemColors.Control;
			this.pbox_Random.ContextMenuStrip = this.cmnu_Pictures;
			this.pbox_Random.Location = new System.Drawing.Point(45, 304);
			this.pbox_Random.Name = "pbox_Random";
			this.pbox_Random.Size = new System.Drawing.Size(286, 177);
			this.pbox_Random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbox_Random.TabIndex = 3;
			this.pbox_Random.TabStop = false;
			this.pbox_Random.DoubleClick += new System.EventHandler(this.Pbox_RandomDoubleClick);
			this.pbox_Random.MouseLeave += new System.EventHandler(this.Pbox_RandomMouseLeave);
			this.pbox_Random.MouseEnter += new System.EventHandler(this.Pbox_RandomMouseEnter);
			// 
			// lbl_Random
			// 
			this.lbl_Random.Location = new System.Drawing.Point(146, 260);
			this.lbl_Random.Name = "lbl_Random";
			this.lbl_Random.Size = new System.Drawing.Size(90, 17);
			this.lbl_Random.TabIndex = 4;
			this.lbl_Random.Text = "Random Picture";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lbl_Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 540);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(375, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_Status
			// 
			this.lbl_Status.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(38, 17);
			this.lbl_Status.Text = "Ready";
			// 
			// b_WorkMain
			// 
			this.b_WorkMain.WorkerReportsProgress = true;
			this.b_WorkMain.WorkerSupportsCancellation = true;
			this.b_WorkMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.b_WorkMain_DoWork);
			// 
			// mnu_Meniu
			// 
			this.mnu_Meniu.BackColor = System.Drawing.SystemColors.Menu;
			this.mnu_Meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mnu_Meniu.Location = new System.Drawing.Point(0, 0);
			this.mnu_Meniu.Name = "mnu_Meniu";
			this.mnu_Meniu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mnu_Meniu.Size = new System.Drawing.Size(375, 24);
			this.mnu_Meniu.TabIndex = 6;
			this.mnu_Meniu.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItemClick);
			// 
			// btn_LoadLast
			// 
			this.btn_LoadLast.Location = new System.Drawing.Point(74, 493);
			this.btn_LoadLast.Name = "btn_LoadLast";
			this.btn_LoadLast.Size = new System.Drawing.Size(99, 34);
			this.btn_LoadLast.TabIndex = 7;
			this.btn_LoadLast.Text = "Last Picture";
			this.btn_LoadLast.UseVisualStyleBackColor = true;
			this.btn_LoadLast.Click += new System.EventHandler(this.Btn_LoadLastClick);
			// 
			// b_WorkRandom
			// 
			this.b_WorkRandom.WorkerReportsProgress = true;
			this.b_WorkRandom.WorkerSupportsCancellation = true;
			this.b_WorkRandom.DoWork += new System.ComponentModel.DoWorkEventHandler(this.B_WorkRandomDoWork);
			this.b_WorkRandom.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.b_WorkRandom_RunWorkerCompleted);
			// 
			// nico_Icon
			// 
			this.nico_Icon.BalloonTipText = "Beautiful Wallpapers";
			this.nico_Icon.ContextMenuStrip = this.cmnu_Icon;
			this.nico_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("nico_Icon.Icon")));
			this.nico_Icon.Text = "Beautiful Wallpapers";
			this.nico_Icon.Visible = true;
			this.nico_Icon.DoubleClick += new System.EventHandler(this.Nico_IconDoubleClick);
			// 
			// cmnu_Icon
			// 
			this.cmnu_Icon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cmnu_icon_exit});
			this.cmnu_Icon.Name = "cmnu_Icon";
			this.cmnu_Icon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.cmnu_Icon.Size = new System.Drawing.Size(104, 26);
			// 
			// cmnu_icon_exit
			// 
			this.cmnu_icon_exit.Name = "cmnu_icon_exit";
			this.cmnu_icon_exit.Size = new System.Drawing.Size(103, 22);
			this.cmnu_icon_exit.Text = "Exit";
			this.cmnu_icon_exit.Click += new System.EventHandler(this.cmnu_icon_exitClick);
			// 
			// tmr_Check
			// 
			this.tmr_Check.Interval = 300000;
			this.tmr_Check.Tick += new System.EventHandler(this.Tmr_CheckTick);
			// 
			// b_WorkCheck
			// 
			this.b_WorkCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.b_WorkCheck_DoWork);
			this.b_WorkCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.b_WorkCheck_RunWorkerCompleted);
			// 
			// linkl_Link
			// 
			this.linkl_Link.AutoSize = true;
			this.linkl_Link.Location = new System.Drawing.Point(263, 544);
			this.linkl_Link.Name = "linkl_Link";
			this.linkl_Link.Size = new System.Drawing.Size(109, 13);
			this.linkl_Link.TabIndex = 8;
			this.linkl_Link.TabStop = true;
			this.linkl_Link.Text = "cemimo.blogspot.com";
			this.linkl_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkl_Link_LinkClicked);
			// 
			// lbl_Vote
			// 
			this.lbl_Vote.AutoSize = true;
			this.lbl_Vote.Location = new System.Drawing.Point(61, 232);
			this.lbl_Vote.Name = "lbl_Vote";
			this.lbl_Vote.Size = new System.Drawing.Size(258, 13);
			this.lbl_Vote.TabIndex = 9;
			this.lbl_Vote.Text = "If you like the last picture, vote for it on cemimo\'s blog";
			// 
			// lbl_Update
			// 
			this.lbl_Update.AutoSize = true;
			this.lbl_Update.Location = new System.Drawing.Point(224, 4);
			this.lbl_Update.Name = "lbl_Update";
			this.lbl_Update.Size = new System.Drawing.Size(78, 13);
			this.lbl_Update.TabIndex = 10;
			this.lbl_Update.Text = "Last update at:";
			// 
			// btn_Backbtn_Back
			// 
			this.btn_Backbtn_Back.Location = new System.Drawing.Point(12, 384);
			this.btn_Backbtn_Back.Name = "btn_Backbtn_Back";
			this.btn_Backbtn_Back.Size = new System.Drawing.Size(20, 23);
			this.btn_Backbtn_Back.TabIndex = 11;
			this.btn_Backbtn_Back.Text = "<";
			this.btn_Backbtn_Back.UseVisualStyleBackColor = true;
			this.btn_Backbtn_Back.Click += new System.EventHandler(this.btn_Backbtn_Back_Click);
			// 
			// btn_Forward
			// 
			this.btn_Forward.Location = new System.Drawing.Point(340, 384);
			this.btn_Forward.Name = "btn_Forward";
			this.btn_Forward.Size = new System.Drawing.Size(20, 23);
			this.btn_Forward.TabIndex = 12;
			this.btn_Forward.Text = ">";
			this.btn_Forward.UseVisualStyleBackColor = true;
			this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
			// 
			// lbl_NrPoza
			// 
			this.lbl_NrPoza.AutoSize = true;
			this.lbl_NrPoza.Location = new System.Drawing.Point(168, 280);
			this.lbl_NrPoza.Name = "lbl_NrPoza";
			this.lbl_NrPoza.Size = new System.Drawing.Size(24, 13);
			this.lbl_NrPoza.TabIndex = 13;
			this.lbl_NrPoza.Text = "/25";
			// 
			// b_WorkBF
			// 
			this.b_WorkBF.WorkerSupportsCancellation = true;
			this.b_WorkBF.DoWork += new System.ComponentModel.DoWorkEventHandler(this.b_WorkBF_DoWork);
			this.b_WorkBF.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.b_WorkBF_RunWorkerCompleted);
			// 
			// saveFDlg_SavePicture
			// 
			this.saveFDlg_SavePicture.DefaultExt = "jpg";
			this.saveFDlg_SavePicture.Filter = "JPG files|*.jpg|PNG files|*.png|All files|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(375, 562);
			this.Controls.Add(this.lbl_NrPoza);
			this.Controls.Add(this.btn_Forward);
			this.Controls.Add(this.btn_Backbtn_Back);
			this.Controls.Add(this.lbl_Update);
			this.Controls.Add(this.pbox_Ultima);
			this.Controls.Add(this.btn_LoadLast);
			this.Controls.Add(this.lbl_Vote);
			this.Controls.Add(this.lbl_UltimaPoza);
			this.Controls.Add(this.btn_Random);
			this.Controls.Add(this.lbl_Random);
			this.Controls.Add(this.pbox_Random);
			this.Controls.Add(this.linkl_Link);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.mnu_Meniu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnu_Meniu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = " Beautiful Wallpapers";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Resize += new System.EventHandler(this.MainFormResize);
			((System.ComponentModel.ISupportInitialize)(this.pbox_Ultima)).EndInit();
			this.cmnu_Pictures.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbox_Random)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.mnu_Meniu.ResumeLayout(false);
			this.mnu_Meniu.PerformLayout();
			this.cmnu_Icon.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.SaveFileDialog saveFDlg_SavePicture;
		private System.Windows.Forms.ToolStripMenuItem btn_SavePicture;
		private System.Windows.Forms.ContextMenuStrip cmnu_Pictures;
		private System.Windows.Forms.Timer tmr_Check;
		private System.Windows.Forms.ToolStripMenuItem cmnu_icon_exit;
		private System.Windows.Forms.ContextMenuStrip cmnu_Icon;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon nico_Icon;
		private System.ComponentModel.BackgroundWorker b_WorkRandom;
		private System.Windows.Forms.Button btn_LoadLast;
		private System.ComponentModel.BackgroundWorker b_WorkMain;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mnu_Meniu;
		private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
		private System.Windows.Forms.Button btn_Random;
		private System.Windows.Forms.PictureBox pbox_Ultima;
		private System.Windows.Forms.Label lbl_Random;
		private System.Windows.Forms.PictureBox pbox_Random;
		private System.Windows.Forms.Label lbl_UltimaPoza;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker b_WorkCheck;
        private System.Windows.Forms.LinkLabel linkl_Link;
        private System.Windows.Forms.Label lbl_Vote;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Button btn_Backbtn_Back;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Label lbl_NrPoza;
        private System.ComponentModel.BackgroundWorker b_WorkBF;
	}
}

/*
 * Created by SharpDevelop.
 * User: Gabi
 * Date: 18.05.2009
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Beautiful_Wallpapers
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
			
		
		}
		
		RegistryKey kstart;
		
		void OptionsLoad(object sender, EventArgs e)
		{
			kstart = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (kstart.GetValue("Beautiful") != null)
            {
                cbox_startup.Checked = true;
                txt_Delay.Enabled = true;
            }
            else
            {
                cbox_startup.Checked = false;
                txt_Delay.Enabled = false;
            }
            txt_Delay.Text = "" + Properties.Settings.Default.delay;
					
			if(Properties.Settings.Default.auto_check==false)
				cbox_auto.Checked=false;
			else
				cbox_auto.Checked=true;
			
			if(Properties.Settings.Default.auto_set==true)
				rbuton_auto.Checked=true;
			else
				rbutton_announce.Checked=true;
			
			cbox_autosave.Checked = Properties.Settings.Default.auto_save;
			
			folderDialog_SaveLocation.SelectedPath = Properties.Settings.Default.save_location;
			
			this.toolTip_SaveLocation.SetToolTip(this.btn_SaveLocation, Properties.Settings.Default.save_location);
            
		}
		
		void Cbox_autoCheckedChanged(object sender, EventArgs e)
		{
			if(cbox_auto.Checked==false)
			{
				groupBox_lastpicture.Enabled=false;
			}
			else
			{
				groupBox_lastpicture.Enabled=true;
			}
		}
		
		void Btn_OKClick(object sender, EventArgs e)
		{
			//bool status=true;
			if(cbox_startup.Checked==true)
			{
				kstart.SetValue("Beautiful","\""+Application.ExecutablePath.ToString()+"\" -1");
			}
			else
			{
				kstart.DeleteValue("Beautiful", false);
			}			
		
				Properties.Settings.Default.auto_check=cbox_auto.Checked;
		
				Properties.Settings.Default.auto_set=rbuton_auto.Checked;
			
            if (cbox_startup.Enabled == true)
            {
                if (txt_Delay.Text == "")
                    txt_Delay.Text = "0";
                Properties.Settings.Default.delay = Convert.ToInt32(txt_Delay.Text);
            }
            
            if(cbox_autosave.Checked)
              if (Properties.Settings.Default.save_location != "" || folderDialog_SaveLocation.SelectedPath != "")
            {            	
            	Properties.Settings.Default.save_location = folderDialog_SaveLocation.SelectedPath;
            	
            }
            else            
            {
            	MessageBox.Show("No folder selected for autosave option!","Beautiful Wallpapers");
            	//status = false;
            }
            Properties.Settings.Default.auto_save = cbox_autosave.Checked;
            /*if(status)
            {*/
				Properties.Settings.Default.Save();
				this.Close();
            //}
		}
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.Close();
		}

        private void cbox_startup_CheckedChanged(object sender, EventArgs e)
        {
            txt_Delay.Enabled = !txt_Delay.Enabled;
        }

        private void txt_Delay_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if(e.KeyChar!='\b')
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true; ;
        }
        
		
		void Btn_SaveLocationClick(object sender, EventArgs e)
		{
			if(folderDialog_SaveLocation.ShowDialog()==DialogResult.OK)
			{
				this.toolTip_SaveLocation.SetToolTip(this.btn_SaveLocation, folderDialog_SaveLocation.SelectedPath);
			}
		}
	}
}

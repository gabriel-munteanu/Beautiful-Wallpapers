/*
 * Created by SharpDevelop.
 * User: Gabi
 * Date: 20.05.2009
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Xml;

namespace Beautiful_Wallpapers
{
	public partial class FHelp : Form
	{
		public FHelp()
		{
			InitializeComponent();
		}

        WebClient client = new WebClient();
		
		
		
		void Btn_OkClick(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btn_Donate_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "wyrdaprogramming@gmail.com";  // your paypal email
            string description = "Donation.";           // '%20' represents a space. remember HTML!
            string country = "RO";                  // AU, US, etc.
            string currency = "USD";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                    "?cmd=" + "\"" + "_donations" + "\"" +
                    "&business=" + "\"" + business + "\"" +
                    "&lc=" + "\"" + country + "\"" +
                    "&item_name=" + "\"" + description + "\"" +
                    "&currency_code=" + "\"" + currency + "\"" +
                    "&bn=" + "\"" + "PP%2dDonationsBF" + "\"";
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception exc1)
            {
                if (exc1.GetType().ToString() != "System.ComponentModel.Win32Exception")
                {
                    try
                    {

                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("IExplore.exe", url);

                        System.Diagnostics.Process.Start(startInfo);

                        startInfo = null;

                    }

                    catch (Exception exc2)
                    {
                        MessageBox.Show(exc2.Message);
                    }

                }
            } 
        }
		
        private void CheckUpdate()
        {
            try
            {
                string versiune;
                Stream htmlStream = client.OpenRead(@"http://wyrda.wsr3.net/versiune.php?id=1");
                StreamReader f = new StreamReader(htmlStream);
                versiune = f.ReadToEnd();
                if(versiune.Length > 10)
                	throw new Exception ();
                if (versiune != Properties.Settings.Default.versiune)
                {
                    if (MessageBox.Show(this, "Beautiful Wallpapers " + versiune + " available to download\nDo you want to download this version?", "Beautiful Wallpapers", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(@"http://wyrda.wsr3.net/download.php?list.4");
                }
                else
                    MessageBox.Show(this, "No new version available", "Beautiful Wallpapers");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Website problems!");
            }
            
        }

        private void btn_CheckUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate();
        }

        private void linklabel_Site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://wyrda.wsr3.net");
        }	
		
		
		
		
	}
}

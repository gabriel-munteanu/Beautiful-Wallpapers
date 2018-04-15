/*
 * Created by SharpDevelop.
 * User: Elev
 * Date: 3/27/2009
 * Time: 9:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Xml;
using System.Net;
using Microsoft.Win32;

namespace Beautiful_Wallpapers
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo( int uAction, int uParam, string lpvParam, int fuWinIni);	
		
		static string[] str_link = new string[30];
		
		XmlTextReader rssReader ;
		XmlDocument rssDoc = new XmlDocument();
        static XmlNode nodeRss;
		
		XmlNode nodeChannel;
		string html;
		WebClient client = new WebClient();		//folosit  de program la toate actiunile pe net:xml,download background...
		WebClient client2 = new WebClient();	//pt salvarea pozelor de catre utilizator
		
		int int_pozitie;
		string penultimapoza,ultimapoza,poza_reper;
		int poza_random=-1,poza_ultima=-1,nrpoza;
		int tip=1,update=1;
		
		System.Drawing.Graphics formGraphics;
		Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black);

		
		public MainForm()
		{			
			InitializeComponent();
            tmr_Check.Interval = 3600000;
            Properties.Settings.Default.Upgrade();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
            if (!Directory.Exists("c:\\temp"))
                Directory.CreateDirectory("c:\\temp");
 
			string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {                
                WindowState = FormWindowState.Minimized;
                Thread.Sleep(Properties.Settings.Default.delay*1000);
                Tmr_CheckTick(null, null);                
               
            }
            else
            {
                formGraphics = this.CreateGraphics();
                Tmr_CheckTick(null, null);
                
                
            }            	
            	if(Properties.Settings.Default.auto_check==true)
            		tmr_Check.Enabled=true;
                
            poza_reper = Properties.Settings.Default.link;
		}
		

        private void b_WorkMain_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        	try{
        	rssReader = new XmlTextReader("http://feeds.feedburner.com/cemimo?format=xml");
        	
        	lbl_Status.Text="Please wait! Loading last image and last 25 links";
			rssDoc.Load(rssReader);
			for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
			{  			 
   				if (rssDoc.ChildNodes[i].Name == "feed")
   				{     				
     				 nodeRss = rssDoc.ChildNodes[i];     				 
     				 break;
   				}
			}
			for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
			{  	
				
   				if (nodeRss.ChildNodes[i].Name == "entry")
   				{   
   					int_pozitie=i;
    				nodeChannel = nodeRss.ChildNodes[i];	
    				html=nodeChannel["content"].InnerText;	
    				int tmp1=html.IndexOf("href=\"http://");	
            		string tmp2=html.Substring(tmp1);	           
           			string[] url = new String[10];	
            		url=tmp2.Split('\"');	         		
            		Stream htmlStream = client.OpenRead(url[1]);	
            		StreamReader f = new StreamReader(htmlStream);	
            		html=f.ReadToEnd();	  
					tmp1=html.IndexOf("src=");	
					if(tmp1!=-1)
                        {
                        	tmp2 = html.Substring(tmp1);
                        	url = tmp2.Split('\"');
                        }
					
					ultimapoza=url[1];
                    html = null;
					if(penultimapoza!=ultimapoza||poza_ultima==-1)
					{						
						pbox_Ultima.Load(url[1]);
						penultimapoza=ultimapoza;
                        Properties.Settings.Default.link = ultimapoza;
                        Properties.Settings.Default.Save();
						poza_ultima=0;
					}
					htmlStream.Close();
					htmlStream.Dispose();
					f.Close();
					f.Dispose();
					break;
   				}
        	}
			penultimapoza=ultimapoza;
            Properties.Settings.Default.link = ultimapoza;
            Properties.Settings.Default.Save();
			//-----------------
			for(int i=int_pozitie,j=0 ;i <=int_pozitie+24  ;i++,j++)
			{
				nodeChannel = nodeRss.ChildNodes[i];	
    			html=nodeChannel["content"].InnerText;	
    			int tmp1=html.IndexOf("href=\"http://");	
            	string tmp2=html.Substring(tmp1);	           
           		string[] url = new String[10];	
            	url=tmp2.Split('\"');	         		
            	Stream htmlStream = client.OpenRead(url[1]);	
            	StreamReader f = new StreamReader(htmlStream);	
            	html=f.ReadToEnd();	  
				tmp1=html.IndexOf("src=");	
				if(tmp1!=-1)
                {
                        tmp2 = html.Substring(tmp1);
                        url = tmp2.Split('\"');
                }
				str_link[j]=url[1];
                html = null;
                htmlStream.Close();
				htmlStream.Dispose();
				f.Close();
				f.Dispose();
				
				poza_ultima=0;
			}
			lbl_Status.Text="Ready";
			} catch (Exception ex) {
        		b_WorkMain.CancelAsync();
        		lbl_Status.Text="Error - Ready";
        		//MessageBox.Show(ex.Message,"Eroarea1");
        		poza_ultima=-1;        		
        	}
            
        }
        void B_WorkRandomDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
        	try {
			lbl_Status.Text="Please wait! Loading random picture";
			Random rand = new Random();
			int img = rand.Next(1,24);	
			poza_random=img;
			pbox_Random.Load(str_link[img]);
			lbl_Status.Text="Ready";            
            nrpoza = img;
			} catch (Exception) {        		
        		lbl_Status.Text="Error - Ready";
        		poza_random=-1;
                b_WorkRandom.CancelAsync();
        	}
		}        
        	
		
		void Btn_RandomClick(object sender, EventArgs e)
		{
            if (!b_WorkMain.IsBusy && !b_WorkRandom.IsBusy && !b_WorkCheck.IsBusy && !b_WorkBF.IsBusy)
			{
				System.GC.Collect();			
				System.GC.WaitForPendingFinalizers();
				b_WorkRandom.RunWorkerAsync();
			}
		}
		
		void Btn_LoadLastClick(object sender, EventArgs e)
		{
            if (!b_WorkMain.IsBusy && !b_WorkRandom.IsBusy && !b_WorkCheck.IsBusy && !b_WorkBF.IsBusy)
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				b_WorkMain.RunWorkerAsync();
			}
		}	
		
		
		void Pbox_RandomMouseEnter(object sender, EventArgs e)
		{
			formGraphics.DrawRectangle(pen,45-2,304-2,286+3,177+3);
		}
		
		void Pbox_RandomMouseLeave(object sender, EventArgs e)
		{
			formGraphics.Clear(this.BackColor);
		}
		
		void Pbox_UltimaMouseEnter(object sender, EventArgs e)
		{
			formGraphics.DrawRectangle(pen,45-2,44-2,286+3,177+3);
		}
		
		void Pbox_UltimaMouseLeave(object sender, EventArgs e)
		{
			formGraphics.Clear(this.BackColor);
		}
		
		void SetWallpaper(int i)
		{
			try{				
				client.DownloadFile(str_link[i], "c:\\temp\\picture.jpg");
            	Image image = new Bitmap("c:\\temp\\picture.jpg");
            	image.Save("c:\\temp\\picture.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            	SystemParametersInfo(20, 0, "(None)", 0x01 | 0x02);
            	RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            	key.SetValue(@"WallpaperStyle", "2");
            	key.SetValue(@"TileWallpaper", "0");
            	SystemParametersInfo(20, 0, "c:\\temp\\picture.bmp", 0x01 | 0x02);
            	lbl_Status.Text="Ready";
			}
			catch(Exception ex)
			{
				lbl_Status.Text="Error - Ready";
				//MessageBox.Show(ex.Message,"Eroarea2");
			}

		}
		
		void Pbox_RandomDoubleClick(object sender, EventArgs e)
		{
			if(poza_random!=-1)
			{
				lbl_Status.Text="Please wait! Downloading and setting as wallpaper";
				this.Refresh();
				SetWallpaper(poza_random);
			}
			else
				MessageBox.Show("No random picture loaded!","Beautifull Wallpapers");
			
		}
		
		void Pbox_UltimaDoubleClick(object sender, EventArgs e)
		{
			if(poza_ultima!=-1)
			{
				lbl_Status.Text="Please wait! Downloading and setting as wallpaper";
				this.Refresh();
				SetWallpaper(poza_ultima);				
			}
			else
				MessageBox.Show("Last picture is not loaded!","Beautifull Wallpapers");
			
		}
		
		void Nico_IconDoubleClick(object sender, EventArgs e)
		{
			this.Show();
			this.ShowInTaskbar=true;
			WindowState=FormWindowState.Normal;
			formGraphics = this.CreateGraphics();
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
			{
				this.ShowInTaskbar=false;
                this.Hide();
				/*if(tip==1)
				{
					nico_Icon.BalloonTipText="I'm here";
					nico_Icon.ShowBalloonTip(1000);
					nico_Icon.BalloonTipText="Beautiful Wallpapers";
					tip=0;
				}*/
			}
		}
		
		void cmnu_icon_exitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void OptionsToolStripMenuItemClick(object sender, EventArgs e)
		{
			Options FOptions = new Options();
			FOptions.ShowDialog();
			FOptions.Dispose();
		}
		
		void Tmr_CheckTick(object sender, EventArgs e)
		{
            b_WorkCheck.RunWorkerAsync();
		}
		
		void HelpToolStripMenuItemClick(object sender, EventArgs e)
		{
			FHelp _FHelp = new FHelp();
			_FHelp.ShowDialog();
            _FHelp.Dispose();
		}

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.auto_check == true && tmr_Check.Enabled==false)
                tmr_Check.Enabled = true;
            if (Properties.Settings.Default.auto_check == false && tmr_Check.Enabled == true)
                tmr_Check.Enabled = false;
        }

        private void b_WorkCheck_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            lbl_Status.Text = "Please wait! Loading last image and last 25 links";
            try
            {
            	/*if (update == 1)
                {                    
                    CheckUpdate();
                }*/
                rssReader = new XmlTextReader("http://feeds.feedburner.com/cemimo?format=xml");
				
                rssDoc.Load(rssReader);
                for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
                {
                    if (rssDoc.ChildNodes[i].Name == "feed")
                    {
                        nodeRss = rssDoc.ChildNodes[i];
                        break;
                    }
                }
                //---------------------
                for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
                {

                    if (nodeRss.ChildNodes[i].Name == "entry")
                    {
                        int_pozitie = i;
                        nodeChannel = nodeRss.ChildNodes[i];
                        html = nodeChannel["content"].InnerText;
                        int tmp1 = html.IndexOf("http://");                       
                        tmp1 = html.IndexOf("http://", tmp1+1);
                        html = html.Substring(tmp1);
                        string[] url = html.Split('\"');
                        /*string tmp2 = html.Substring(tmp1);
                        string[] url = new String[10];
                        url = tmp2.Split('\"');*/
                        
                       // MessageBox.Show(url[0],"Eroarea3-1");
                        
                       /* Stream htmlStream = client.OpenRead(url[1]);
                        StreamReader f = new StreamReader(htmlStream);
                        html = f.ReadToEnd();
                        tmp1 = html.IndexOf("src=");
                        if(tmp1!=-1)
                        {
                        	tmp2 = html.Substring(tmp1);
                        	url = tmp2.Split('\"');
                        }*/
                        ultimapoza = url[0];                     
                        html = null;
                        Properties.Settings.Default.Upgrade();
                        penultimapoza = Properties.Settings.Default.link;
                        //MessageBox.Show("1","Eroarea3");
                        if (penultimapoza != ultimapoza || poza_ultima == -1)
                        {
                            pbox_Ultima.Load(url[0]);
                            if (Properties.Settings.Default.auto_check == true && penultimapoza != ultimapoza)
                            {
                                if (Properties.Settings.Default.auto_set == true)
                                {
                                    client.DownloadFile(url[0], "c:\\temp\\picture.jpg");
                                    Image image = new Bitmap("c:\\temp\\picture.jpg");
                                    image.Save("c:\\temp\\picture.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    SystemParametersInfo(20, 0, "(None)", 0x01 | 0x02);
                                    RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
                                    key.SetValue(@"WallpaperStyle", "2");
                                    key.SetValue(@"TileWallpaper", "0");
                                    SystemParametersInfo(20, 0, "c:\\temp\\picture.bmp", 0x01 | 0x02);
                                }
                                else
                                {
                                    nico_Icon.BalloonTipText = "New wallpaper avalaible";
                                    nico_Icon.ShowBalloonTip(2000);
                                    nico_Icon.BalloonTipText = "Beautiful Wallpapers";
                                }
                            }
                            penultimapoza = ultimapoza;
                            Properties.Settings.Default.link = ultimapoza;
                            poza_ultima = 0;
                            Properties.Settings.Default.Save();
                        }
                        /*htmlStream.Close();
                        htmlStream.Dispose();
                        f.Close();
                        f.Dispose();*/
                        break;
                    }
                }
                penultimapoza = ultimapoza;
                Properties.Settings.Default.link = ultimapoza;
                bool status=true;
                //-----------------
                for (int i = int_pozitie, j = 0; i <= int_pozitie + 24; i++, j++)
                {
                    nodeChannel = nodeRss.ChildNodes[i];
                    html = nodeChannel["content"].InnerText;
                    int tmp1 = html.IndexOf("http://");
                    tmp1 = html.IndexOf("http://", tmp1+1);
                    html = html.Substring(tmp1);
                    string[] url = html.Split('\"');
                    /*    
                    string tmp2 = html.Substring(tmp1);
                    string[] url = new String[10];
                    url = tmp2.Split('\"');
                    Stream htmlStream = client.OpenRead(url[1]);
                    StreamReader f = new StreamReader(htmlStream);
                    html = f.ReadToEnd();
                    tmp1 = html.IndexOf("src=");                    
                    if(tmp1!=-1)
                        {
                        	tmp2 = html.Substring(tmp1);
                        	url = tmp2.Split('\"');
                        }*/
                    str_link[j] = url[0];
                    poza_ultima = 0;
                    html = null;
                    //
                    if(poza_reper==str_link[j])
                    	status=false;
                    if(Properties.Settings.Default.auto_save&&status)
                    {
                    	string picture_name=str_link[j].Substring(str_link[j].LastIndexOf("/")+1);
                    	client2.DownloadFile(str_link[j], Properties.Settings.Default.save_location+"\\"+picture_name);
                    }
                    //                    
                    /*htmlStream.Close();
                    htmlStream.Dispose();
                    f.Close();
                    f.Dispose();*/
                     
                }
                
            }
            catch (Exception ex)
            {
                poza_ultima = -1;
                lbl_Status.Text = "Error - Ready";
                MessageBox.Show(ex.Message,"Eroarea3");
            }
            
        }

        private void linkl_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://cemimo.blogspot.com");
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
                //System.Diagnostics.Debug.Print(update.ToString());
                if (versiune != Properties.Settings.Default.versiune)
                {
                    if (MessageBox.Show(null, "Beautiful Wallpapers " + versiune + " available to download\nDo you want to download this version?", "Beautiful Wallpapers", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(@"http://wyrda.wsr3.net/download.php?list.4");
                }
                update = 0;
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
        }

        private void b_WorkCheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        	if(poza_ultima!=-1)
        	{
        		lbl_Update.Text = "Last update at: " + DateTime.Now.ToShortTimeString() + "  (1h)";
           	 	lbl_Status.Text = "Ready";
        	}
        	
            /*try
            {
                if (update == 1)
                {
                    update = 0;
                    CheckUpdate();                    
                }
            }
            catch(Exception)
            {
                lbl_Status.Text = "Error - Ready";
            }*/
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
           	
        }

        /* 
         * 		Back Forward Worker
         * */
        private void b_WorkBF_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            
                int arg = (int)e.Argument;
                if (arg == 1 && nrpoza != 24)
                {
                    try
                    {
                        lbl_Status.Text = "Please wait! Loading picture";
                        pbox_Random.Load(str_link[++nrpoza]);
                        lbl_Status.Text = "Ready"; 
                    }
                    catch (Exception ex)
                    {                        
                        lbl_Status.Text = "Error - Ready";
                        poza_random = -1;
                        b_WorkBF.CancelAsync();
                        //MessageBox.Show(ex.Message,"Eroarea");
                    }
                }
                if (arg == 0 && nrpoza != 1)
                {
                    try
                    {
                        lbl_Status.Text = "Please wait! Loading picture";
                        pbox_Random.Load(str_link[--nrpoza]);
                        lbl_Status.Text = "Ready";
                    }
                    catch (Exception ex)
                    {                        
                        lbl_Status.Text = "Error - Ready";
                        //MessageBox.Show(ex.Message,"Eroarea");
                        poza_random = -1;
                        b_WorkBF.CancelAsync();
                    }
                }
            
               

        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (!b_WorkMain.IsBusy && !b_WorkRandom.IsBusy && !b_WorkCheck.IsBusy && !b_WorkBF.IsBusy && poza_random!=-1)
            {                
                b_WorkBF.RunWorkerAsync(1);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
            }
        }

        private void btn_Backbtn_Back_Click(object sender, EventArgs e)
        {
            if (!b_WorkMain.IsBusy && !b_WorkRandom.IsBusy && !b_WorkCheck.IsBusy && !b_WorkBF.IsBusy && poza_random != -1)
            {               
                b_WorkBF.RunWorkerAsync(0);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
            }
        }

        private void b_WorkBF_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (poza_random != -1)
            {
                lbl_NrPoza.Text = (nrpoza + 1) + "/25";
                poza_random = nrpoza;
            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void b_WorkRandom_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (poza_random != -1)
                lbl_NrPoza.Text = (nrpoza + 1) + "/25";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }		
				
				
        public static void CopyStream(Stream input, Stream output)
		{
		    byte[] buffer = new byte[32768];
		    while (true)
		    {
		        int read = input.Read (buffer, 0, buffer.Length);
		        if (read <= 0)
		            return;
		        output.Write (buffer, 0, read);
		    }
		}

        
		void Btn_SavePictureClick(object sender, EventArgs e)
		{
			int picture_nr=0;
			string picture_name;
			bool status=true;
			if(cmnu_Pictures.SourceControl == pbox_Ultima)
			{
				if(poza_ultima!=-1)
					picture_nr = 0;
				else
				{
					MessageBox.Show("Last picture is not loaded!","Beautifull Wallpapers");
					status=false;
				}
			}
			else
			{
				if(poza_random!=-1)
					picture_nr = nrpoza;
				else
				{
					MessageBox.Show("No random picture loaded!","Beautifull Wallpapers");
					status=false;
				}
			}
			
			if(status)
			{
				picture_name=str_link[picture_nr].Substring(str_link[picture_nr].LastIndexOf("/")+1);
				
				saveFDlg_SavePicture.FileName = picture_name;
				saveFDlg_SavePicture.InitialDirectory = Properties.Settings.Default.save_location;
				if(saveFDlg_SavePicture.ShowDialog() == DialogResult.OK)
				{
					Stream save_stream=saveFDlg_SavePicture.OpenFile();
					Stream read_stream = client2.OpenRead(str_link[picture_nr]);
					CopyStream(read_stream,save_stream);
				}
			
			}
		}
	}
}

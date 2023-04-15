using ÇalarSaat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Timer = System.Windows.Forms.Timer;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalarSaat
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
            string selectedcombobox = File.ReadAllText("settingscombo.txt");
            settingscombo.Text = selectedcombobox;
            string themefile = File.ReadAllText("settingstheme.txt");
            if (themefile == "darkmode")
            {
                darkmode.Checked = true;
                lightmode.Checked = false;
                temainfo.Text = "";

                File.WriteAllText("settingstheme.txt", "darkmode");




            }
            else if (themefile == "lightmode")
            {
                darkmode.Checked = false;
                lightmode.Checked = true;
                temainfo.Text = "";



                this.BackColor = Color.FromArgb(249, 249, 249);
                pictureBox1.BackColor = Color.FromArgb(249, 249, 249);
                label1.ForeColor = Color.FromArgb(27, 27, 27);
                label2.ForeColor = Color.FromArgb(173, 173, 173);
                label3.ForeColor = Color.FromArgb(173, 173, 173);
                label4.ForeColor = Color.FromArgb(27, 27, 27);
                label5.ForeColor = Color.FromArgb(27, 27, 27);
                label6.ForeColor = Color.FromArgb(27, 27, 27);
                label7.ForeColor = Color.FromArgb(27, 27, 27);
                linkLabel1.LinkColor = Color.FromArgb(27, 27, 27); ;
                lightmode.ForeColor = Color.FromArgb(27, 27, 27);
                darkmode.ForeColor = Color.FromArgb(27, 27, 27);

                button1.BackColor = Color.FromArgb(220, 220, 220);
                button1.ForeColor = Color.FromArgb(27, 27, 27);
                button1.Image = Resources.whiteupdate;

                button2.BackColor = Color.FromArgb(220, 220, 220);
                button2.ForeColor = Color.FromArgb(27, 27, 27);
                button2.Image = Resources.whiterestart;

                settingscombo.BackColor = Color.FromArgb(220, 220, 220);
                settingscombo.ForeColor = Color.FromArgb(27, 27, 27);
            }
        }

        private void başlangıçta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingscombo.Text == "Saatler")
            {
                File.WriteAllText("settingscombo.txt", "saatler");
            }
            else if (settingscombo.Text == "SüreÖlçer")
            {
                File.WriteAllText("settingscombo.txt", "süreölçer");
            }
            else if (settingscombo.Text == "Kronometre")
            {
                File.WriteAllText("settingscombo.txt", "kronometre");

            }
            else if (settingscombo.Text == "Ayarlar")
            {
                File.WriteAllText("settingscombo.txt", "ayarlar");

            }
            else
            {
                //
            }
        }

        private void update()
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://github.com/h4ckchicken/CalarSaat/archive/refs/tags/V1.5.0.zip", @"C:\Downloads\Çalar-Saat_NewUpdate.zip");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bu özellik yakında kullanıma sunulacak.", "Çalar Saat");
            /*** WebClient client = new WebClient();
             string htmlString = client.DownloadString("https://github.com/h4ckchicken/CalarSaat/releases/tag/V1.5.0");
             HtmlAgilityPack.HtmlDocument htmlBelgesi = new HtmlAgilityPack.HtmlDocument();
             htmlBelgesi.OptionFixNestedTags = false;
             htmlBelgesi.LoadHtml(htmlString);
             HtmlAgilityPack.HtmlNodeCollection version = htmlBelgesi.DocumentNode.SelectNodes("//*[@id=\"repo-content-turbo-frame\"]/div/div/div/div[1]/div[1]/div[1]/div[1]/h1");

             string versioncontrol = "";
             versioncontrol += version[0].InnerText;

             if (versioncontrol == "V1.5.1")
             {
                 //
             }
             else
             {
                 DialogResult result = MessageBox.Show("Yeni bir sürüm mevcut, güncelleme indirilsin mi?", "Çalar Saat", MessageBoxButtons.YesNo);

                 if (result == DialogResult.Yes)
                 {
                     update();
                 }
                 else if (result == DialogResult.No)
                 {
                     //
                 }
             }
            ***/
        }

        private void lightmode_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("settingstheme.txt", "lightmode");
            temainfo.Text = "*Bir sonraki açılışta tema değişecek";
        }

        private void darkmode_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("settingstheme.txt", "darkmode");
            temainfo.Text = "*Bir sonraki açılışta tema değişecek";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/ll.arda.02/");
            }
            catch
            {
                System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "https://www.instagram.com/ll.arda.02/");

            }
        }
    }
}

using ÇalarSaat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalarSaat
{
    public partial class süreolcer : Form

    {

        private int remainingTimeInSeconds; // Geriye kalan saniye sayısı

        public süreolcer()
        {
            InitializeComponent();
            string themefile = File.ReadAllText("settingstheme.txt");
            if (themefile == "darkmode")
            {

            }
            else if (themefile == "lightmode")
            {
                this.BackColor = Color.FromArgb(249, 249, 249);
                this.ForeColor = Color.FromArgb(27, 27, 27);
                button1.BackColor = Color.FromArgb(220, 220, 220);
                button1.ForeColor = Color.FromArgb(27, 27, 27);
                button1.Image = Resources.whitestop;

                btnstart.BackColor = Color.FromArgb(220, 220, 220);
                btnstart.ForeColor = Color.FromArgb(27, 27, 27);
                btnstart.Image = Resources.whitestart;

                up1.BackColor = Color.FromArgb(248, 248, 248);
                up1.Image = Resources.whiteup;
                up2.BackColor = Color.FromArgb(248, 248, 248);
                up2.Image = Resources.whiteup;
                up3.BackColor = Color.FromArgb(248, 248, 248);
                up3.Image = Resources.whiteup;

                down1.BackColor = Color.FromArgb(248, 248, 248);
                down1.Image = Resources.lightdown;
                down2.BackColor = Color.FromArgb(248, 248, 248);
                down2.Image = Resources.lightdown;
                down3.BackColor = Color.FromArgb(248, 248, 248);
                down3.Image = Resources.lightdown;

                pictureBox1.BackColor = Color.FromArgb(243, 243, 243);
                pictureBox2.BackColor = Color.FromArgb(243, 243, 243);
                pictureBox3.BackColor = Color.FromArgb(243, 243, 243);

                label1.BackColor = Color.FromArgb(243, 243, 243);
                label2.BackColor = Color.FromArgb(243, 243, 243);
                label3.BackColor = Color.FromArgb(243, 243, 243);

                hourlabel.BackColor = Color.FromArgb(243, 243, 243);
                minutelabel.BackColor = Color.FromArgb(243, 243, 243);
                secondlabel.BackColor = Color.FromArgb(243, 243, 243);
                hoursayım.BackColor = Color.FromArgb(243, 243, 243);

            }
        }

        int hour = 0;

        private void up1_Click(object sender, EventArgs e)
        {
            if (hourlabel.Text == "99")
            {

            }
            else
            {
                hourlabel.Text = (++hour).ToString();
            }

        }

        private void down1_Click(object sender, EventArgs e)
        {
            if (hourlabel.Text == "00")
            {
                //
            }
            else if (hourlabel.Text == "0")
            {
                //
            }
            else
            {
                hourlabel.Text = (--hour).ToString();
            }
        }

        int minute = 0;

        private void up2_Click(object sender, EventArgs e)
        {

            if (minutelabel.Text == "59")
            {
                //
            }
            else
            {
                minutelabel.Text = (++minute).ToString();
            }
        }

        private void down2_Click(object sender, EventArgs e)
        {
            if (minutelabel.Text == "00")
            {
                //
            }
            else if (minutelabel.Text == "0")
            {
                //
            }
            else
            {
                minutelabel.Text = (--minute).ToString();
            }
        }

        int second = 0;

        private void up3_Click(object sender, EventArgs e)
        {
            if (secondlabel.Text == "59")
            {
                //
            }
            else
            {
                secondlabel.Text = (++second).ToString();
            }
        }

        private void down3_Click(object sender, EventArgs e)
        {
            if (secondlabel.Text == "00")
            {
                //
            }
            else if (secondlabel.Text == "0")
            {
                //
            }
            else
            {
                secondlabel.Text = (--second).ToString();
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            // Kullanıcının belirttiği süre
            int hours = Convert.ToInt32(hourlabel.Text);
            int minutes = Convert.ToInt32(minutelabel.Text);
            int seconds = Convert.ToInt32(secondlabel.Text);

            // Toplam saniye sayısı
            remainingTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Geriye doğru sayım başlat
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geriye kalan saat, dakika ve saniye sayıları
            int remainingHours = remainingTimeInSeconds / 3600;
            int remainingMinutes = (remainingTimeInSeconds % 3600) / 60;
            int remainingSeconds = remainingTimeInSeconds % 60;

            // Geriye kalan süreyi ekranda göster
            hoursayım.Text = string.Format("{0} : {1} : {2}", remainingHours, remainingMinutes, remainingSeconds);

            // Geriye kalan süreyi azalt
            remainingTimeInSeconds--;

            // Geriye doğru sayım tamamlandıysa timer'ı durdur
            if (remainingTimeInSeconds < 0)
            {
                timer1.Stop();
                // Bildirim simgesi oluşturun
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.Text = "Çalar Saat";
                ToolTip tooltip = new ToolTip();
                notifyIcon.Visible = true;

                // Bildirim gönder
                notifyIcon.ShowBalloonTip(5000, "Geri Sayım", "Geri Sayım Tamamlandı!", ToolTipIcon.Info);

                // Bildirimi kapatın ve simgeyi kaldırın
                notifyIcon.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hoursayım.Text = "0 : 0 : 0";
        }
    }
}
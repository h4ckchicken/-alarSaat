using ÇalarSaat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalarSaat
{
    public partial class kronometre : Form
    {
        public kronometre()
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
                button1.Image = Resources.whitestart;

                button2.BackColor = Color.FromArgb(220, 220, 220);
                button2.ForeColor = Color.FromArgb(27, 27, 27);
                button2.Image = Resources.whitestop;


            }
        }

        private int remainingTimeInSeconds;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            remainingTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int remainingHours = remainingTimeInSeconds / 3600;
            int remainingMinutes = (remainingTimeInSeconds % 3600) / 60;
            int remainingSeconds = remainingTimeInSeconds % 60;

            kronomtrelbl.Text = string.Format("{0} : {1} : {2}", remainingHours, remainingMinutes, remainingSeconds);

            remainingTimeInSeconds++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

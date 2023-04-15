using ÇalarSaat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalarSaat
{
    public partial class saatler : Form
    {
        public saatler()
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
                panel1.BackColor = Color.FromArgb(238, 238, 238);
                panel1.ForeColor = Color.FromArgb(27, 27, 27);

                panel2.BackColor = Color.FromArgb(238, 238, 238);
                panel2.ForeColor = Color.FromArgb(27, 27, 27);

                panel3.BackColor = Color.FromArgb(238, 238, 238);
                panel3.ForeColor = Color.FromArgb(27, 27, 27);

                panel4.BackColor = Color.FromArgb(238, 238, 238);
                panel4.ForeColor = Color.FromArgb(27, 27, 27);

                panel5.BackColor = Color.FromArgb(238, 238, 238);
                panel5.ForeColor = Color.FromArgb(27, 27, 27);

                panel6.BackColor = Color.FromArgb(238, 238, 238);
                panel6.ForeColor = Color.FromArgb(27, 27, 27);

                panel7.BackColor = Color.FromArgb(238, 238, 238);
                panel7.ForeColor = Color.FromArgb(27, 27, 27);

                panel8.BackColor = Color.FromArgb(238, 238, 238);
                panel8.ForeColor = Color.FromArgb(27, 27, 27);


            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime istanbulTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time"));
                DateTime ankaraTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time"));
                DateTime newYorkTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
                DateTime londonTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
                DateTime tokyoTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));
                DateTime parisTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"));
                DateTime berlinTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));
                DateTime moscowTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time"));

                istanbulbl.Text = istanbulTime.ToString();
                ankaralbl.Text = ankaraTime.ToString();
                newyorklbl.Text = newYorkTime.ToString();
                londralbl.Text = londonTime.ToString();
                tokyolbl.Text = tokyoTime.ToString();
                parislbl.Text = parisTime.ToString();
                berlinlbl.Text = berlinTime.ToString();
                moskovalbl.Text = moscowTime.ToString();


            }
            catch
            {
                MessageBox.Show("Saatler Çekilemedi!", "Hata");
            }
        }
    }
}

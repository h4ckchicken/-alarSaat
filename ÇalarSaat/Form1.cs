using ÇalarSaat.Properties;
using Timer = System.Windows.Forms.Timer;

namespace ÇalarSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string selectedcombobox = File.ReadAllText("settingscombo.txt");
            string themefile = File.ReadAllText("settingstheme.txt");
            try
            {
                if (themefile == "darkmode")
                {

                }
                else if (themefile == "lightmode")
                {

                    title.BackColor = Color.FromArgb(249, 249, 249);
                    button1.BackColor = Color.FromArgb(249, 249, 249);
                    button1.ForeColor = Color.FromArgb(27, 27, 27);
                    button1.Image = Resources.lightclose;

                    button2.BackColor = Color.FromArgb(249, 249, 249);
                    button2.ForeColor = Color.FromArgb(27, 27, 27);
                    button2.Image = Resources.lightminimize;

                    sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                    sreölcer.ForeColor = Color.FromArgb(27, 27, 27);
                    sreölcer.Image = Resources.whitesüreölçer;

                    alrm.BackColor = Color.FromArgb(240, 240, 240);
                    alrm.ForeColor = Color.FromArgb(27, 27, 27);
                    alrm.Image = Resources.whitealarm;

                    krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                    krnmtre.ForeColor = Color.FromArgb(27, 27, 27);
                    krnmtre.Image = Resources.whitetimer;

                    ayarlr.BackColor = Color.FromArgb(240, 240, 240);
                    ayarlr.ForeColor = Color.FromArgb(27, 27, 27);
                    ayarlr.Image = Resources.whitesettings;

                    this.BackColor = Color.FromArgb(240, 240, 240);
                    names.ForeColor = Color.FromArgb(27, 27, 27);
                    icons.BackColor = Color.FromArgb(240, 240, 240);

                }

            }
            catch
            {

            }
            if (selectedcombobox == "saatler")
            {
                if (themefile == "darkmode")
                {
                    alrm.BackColor = Color.FromArgb(39, 39, 39);
                    sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                    krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                    ayarlr.BackColor = Color.FromArgb(32, 32, 32);
                }
                else if (themefile == "lightmode")
                {
                    alrm.BackColor = Color.FromArgb(209, 209, 209);
                    sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                    krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                    ayarlr.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    //
                }
                saatler alarms = new saatler();
                alarms.TopLevel = false;
                sayfa.Controls.Clear();
                sayfa.Controls.Add(alarms);
                alarms.Show();
            }
            else if (selectedcombobox == "süreölçer")
            {
                if (themefile == "darkmode")
                {
                    alrm.BackColor = Color.FromArgb(32, 32, 32);
                    sreölcer.BackColor = Color.FromArgb(39, 39, 39);
                    krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                    ayarlr.BackColor = Color.FromArgb(32, 32, 32);
                }
                else if (themefile == "lightmode")
                {
                    alrm.BackColor = Color.FromArgb(240, 240, 240);
                    sreölcer.BackColor = Color.FromArgb(209, 209, 209);
                    krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                    ayarlr.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    //
                }
                süreolcer süreolcer = new süreolcer();
                süreolcer.TopLevel = false;
                sayfa.Controls.Clear();
                sayfa.Controls.Add(süreolcer);
                süreolcer.Show();
            }
            else if (selectedcombobox == "kronometre")
            {
                if (themefile == "darkmode")
                {
                    alrm.BackColor = Color.FromArgb(32, 32, 32);
                    sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                    krnmtre.BackColor = Color.FromArgb(39, 39, 39);
                    ayarlr.BackColor = Color.FromArgb(32, 32, 32);
                }
                else if (themefile == "lightmode")
                {
                    alrm.BackColor = Color.FromArgb(240, 240, 240);
                    sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                    krnmtre.BackColor = Color.FromArgb(209, 209, 209);
                    ayarlr.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    //
                }
                kronometre kronometres = new kronometre();
                kronometres.TopLevel = false;
                sayfa.Controls.Clear();
                sayfa.Controls.Add(kronometres);
                kronometres.Show();

            }
            else if (selectedcombobox == "ayarlar")
            {
                if (themefile == "darkmode")
                {
                    alrm.BackColor = Color.FromArgb(32, 32, 32);
                    sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                    krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                    ayarlr.BackColor = Color.FromArgb(39, 39, 39);
                }
                else if (themefile == "lightmode")
                {
                    alrm.BackColor = Color.FromArgb(240, 240, 240);
                    sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                    krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                    ayarlr.BackColor = Color.FromArgb(209, 209, 209);
                }
                else
                {
                    //
                }
                ayarlar ayarlars = new ayarlar();
                ayarlars.TopLevel = false;
                sayfa.Controls.Clear();
                sayfa.Controls.Add(ayarlars);
                ayarlars.Show();
            }
            else
            {
                File.WriteAllText("settingscombo.txt", "ayarlar");
                ayarlar ayarlars = new ayarlar();
                ayarlars.TopLevel = false;
                sayfa.Controls.Clear();
                sayfa.Controls.Add(ayarlars);
                ayarlars.Show();
            }


            this.Opacity = 0;

            var timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, ev) =>
            {
                this.Opacity += 0.08;

                if (this.Opacity >= 1)
                {
                    timer.Stop();
                    timer.Tick -= (ss, ee) => { };
                }
            };
            timer.Start();
            saat.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

            var timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, ev) =>
            {
                this.Opacity -= 0.07;

                if (this.Opacity >= 1)
                {
                    timer.Stop();
                    timer.Tick -= (ss, ee) => { };
                }
                else if (this.Opacity == 0)
                {
                    Application.Exit();
                }
            };
            timer.Start();
            saat.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Opacity = 1;

            var timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, ev) =>
            {
                this.Opacity -= 0.7;

                if (this.Opacity <= 1)
                {
                    timer.Stop();
                    timer.Tick += (ss, ee) => { };
                }
                else if (this.Opacity == 0)
                {
                    Application.Exit();
                }
            };
            timer.Start();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        string themefile = File.ReadAllText("settingstheme.txt");

        private void sreölcer_Click(object sender, EventArgs e)
        {
            if (themefile == "darkmode")
            {
                alrm.BackColor = Color.FromArgb(32, 32, 32);
                sreölcer.BackColor = Color.FromArgb(39, 39, 39);
                krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                ayarlr.BackColor = Color.FromArgb(32, 32, 32);
            }
            else if (themefile == "lightmode")
            {
                alrm.BackColor = Color.FromArgb(240, 240, 240);
                sreölcer.BackColor = Color.FromArgb(209, 209, 209);
                krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                ayarlr.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                //
            }
            süreolcer süreolcer = new süreolcer();
            süreolcer.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(süreolcer);
            süreolcer.Show();

        }

        private void alrm_Click(object sender, EventArgs e)
        {
            if (themefile == "darkmode")
            {
                alrm.BackColor = Color.FromArgb(39, 39, 39);
                sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                ayarlr.BackColor = Color.FromArgb(32, 32, 32);
            }
            else if (themefile == "lightmode")
            {
                alrm.BackColor = Color.FromArgb(209, 209, 209);
                sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                ayarlr.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                //
            }
            saatler alarms = new saatler();
            alarms.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(alarms);
            alarms.Show();
        }

        private void krnmtre_Click(object sender, EventArgs e)
        {
            if (themefile == "darkmode")
            {
                alrm.BackColor = Color.FromArgb(32, 32, 32);
                sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                krnmtre.BackColor = Color.FromArgb(39, 39, 39);
                ayarlr.BackColor = Color.FromArgb(32, 32, 32);
            }
            else if (themefile == "lightmode")
            {
                alrm.BackColor = Color.FromArgb(240, 240, 240);
                sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                krnmtre.BackColor = Color.FromArgb(209, 209, 209);
                ayarlr.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                //
            }

            kronometre kronometres = new kronometre();
            kronometres.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(kronometres);
            kronometres.Show();
        }

        private void ayarlr_Click(object sender, EventArgs e)
        {
            if (themefile == "darkmode")
            {
                alrm.BackColor = Color.FromArgb(32, 32, 32);
                sreölcer.BackColor = Color.FromArgb(32, 32, 32);
                krnmtre.BackColor = Color.FromArgb(32, 32, 32);
                ayarlr.BackColor = Color.FromArgb(39, 39, 39);
            }
            else if (themefile == "lightmode")
            {
                alrm.BackColor = Color.FromArgb(240, 240, 240);
                sreölcer.BackColor = Color.FromArgb(240, 240, 240);
                krnmtre.BackColor = Color.FromArgb(240, 240, 240);
                ayarlr.BackColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                //
            }
            ayarlar ayarlars = new ayarlar();
            ayarlars.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(ayarlars);
            ayarlars.Show();
        }
    }
}
namespace ÇalarSaat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            title = new Panel();
            button2 = new Button();
            button1 = new Button();
            names = new Label();
            icons = new PictureBox();
            saat = new System.Windows.Forms.Timer(components);
            ayarlr = new Button();
            krnmtre = new Button();
            alrm = new Button();
            sreölcer = new Button();
            sayfa = new Panel();
            title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icons).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(39, 39, 39);
            title.Controls.Add(button2);
            title.Controls.Add(button1);
            title.Location = new Point(185, 0);
            title.Name = "title";
            title.Size = new Size(639, 46);
            title.TabIndex = 0;
            title.MouseDown += panel1_MouseDown;
            title.MouseMove += panel1_MouseMove;
            title.MouseUp += panel1_MouseUp;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(552, 20);
            button2.Name = "button2";
            button2.Size = new Size(40, 20);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.darkclose;
            button1.Location = new Point(598, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // names
            // 
            names.AutoSize = true;
            names.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            names.Location = new Point(60, 21);
            names.Name = "names";
            names.Size = new Size(100, 28);
            names.TabIndex = 4;
            names.Text = "Çalar Saat";
            // 
            // icons
            // 
            icons.Image = (Image)resources.GetObject("icons.Image");
            icons.Location = new Point(24, 20);
            icons.Name = "icons";
            icons.Size = new Size(32, 32);
            icons.SizeMode = PictureBoxSizeMode.CenterImage;
            icons.TabIndex = 3;
            icons.TabStop = false;
            // 
            // saat
            // 
            saat.Interval = 1;
            saat.Tick += saat_Tick;
            // 
            // ayarlr
            // 
            ayarlr.BackColor = Color.FromArgb(32, 32, 32);
            ayarlr.FlatAppearance.BorderSize = 0;
            ayarlr.FlatStyle = FlatStyle.Flat;
            ayarlr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ayarlr.Image = Properties.Resources.darksettings;
            ayarlr.ImageAlign = ContentAlignment.MiddleLeft;
            ayarlr.Location = new Point(12, 397);
            ayarlr.Name = "ayarlr";
            ayarlr.Size = new Size(158, 37);
            ayarlr.TabIndex = 8;
            ayarlr.Text = "Ayarlar";
            ayarlr.UseVisualStyleBackColor = false;
            ayarlr.Click += ayarlr_Click;
            // 
            // krnmtre
            // 
            krnmtre.BackColor = Color.FromArgb(32, 32, 32);
            krnmtre.FlatAppearance.BorderSize = 0;
            krnmtre.FlatStyle = FlatStyle.Flat;
            krnmtre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            krnmtre.Image = Properties.Resources.darktimer;
            krnmtre.ImageAlign = ContentAlignment.MiddleLeft;
            krnmtre.Location = new Point(12, 200);
            krnmtre.Name = "krnmtre";
            krnmtre.Size = new Size(158, 37);
            krnmtre.TabIndex = 7;
            krnmtre.Text = "Kronometre";
            krnmtre.UseVisualStyleBackColor = false;
            krnmtre.Click += krnmtre_Click;
            // 
            // alrm
            // 
            alrm.BackColor = Color.FromArgb(32, 32, 32);
            alrm.FlatAppearance.BorderSize = 0;
            alrm.FlatStyle = FlatStyle.Flat;
            alrm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            alrm.Image = Properties.Resources.darkhour;
            alrm.ImageAlign = ContentAlignment.MiddleLeft;
            alrm.Location = new Point(12, 152);
            alrm.Name = "alrm";
            alrm.Size = new Size(158, 37);
            alrm.TabIndex = 6;
            alrm.Text = "Saatler";
            alrm.UseVisualStyleBackColor = false;
            alrm.Click += alrm_Click;
            // 
            // sreölcer
            // 
            sreölcer.BackColor = Color.FromArgb(32, 32, 32);
            sreölcer.FlatAppearance.BorderSize = 0;
            sreölcer.FlatStyle = FlatStyle.Flat;
            sreölcer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sreölcer.Image = Properties.Resources.darksüreölçer;
            sreölcer.ImageAlign = ContentAlignment.MiddleLeft;
            sreölcer.Location = new Point(12, 102);
            sreölcer.Name = "sreölcer";
            sreölcer.Size = new Size(158, 37);
            sreölcer.TabIndex = 5;
            sreölcer.Text = "Süre Ölçer";
            sreölcer.UseVisualStyleBackColor = false;
            sreölcer.Click += sreölcer_Click;
            // 
            // sayfa
            // 
            sayfa.BackColor = Color.FromArgb(39, 39, 39);
            sayfa.Location = new Point(185, 46);
            sayfa.Name = "sayfa";
            sayfa.Size = new Size(640, 409);
            sayfa.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(824, 450);
            Controls.Add(sayfa);
            Controls.Add(ayarlr);
            Controls.Add(krnmtre);
            Controls.Add(alrm);
            Controls.Add(title);
            Controls.Add(sreölcer);
            Controls.Add(icons);
            Controls.Add(names);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalar Saat";
            FormClosing += Form1_FormClosing;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel title;
        private Button button2;
        private Button button1;
        private Label names;
        private PictureBox icons;
        private System.Windows.Forms.Timer saat;
        private Button krnmtre;
        private Button alrm;
        private Button sreölcer;
        private Button ayarlr;
        private Panel sayfa;
    }
}
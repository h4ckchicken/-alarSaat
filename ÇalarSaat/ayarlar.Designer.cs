namespace ÇalarSaat
{
    partial class ayarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            lightmode = new RadioButton();
            darkmode = new RadioButton();
            label5 = new Label();
            settingscombo = new ComboBox();
            updateinfo = new Label();
            temainfo = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 13);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 1;
            label1.Text = "Çalar Saat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(170, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 13);
            label2.TabIndex = 2;
            label2.Text = "Version 1.5.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(170, 67);
            label3.Name = "label3";
            label3.Size = new Size(104, 13);
            label3.TabIndex = 3;
            label3.Text = "All Right Reserverd";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(49, 49, 49);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.darkupdate;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(369, 50);
            button1.Name = "button1";
            button1.Size = new Size(174, 39);
            button1.TabIndex = 4;
            button1.Text = "Güncellemeleri Denetle";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 174);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 5;
            label4.Text = "Tema Seçin :";
            // 
            // lightmode
            // 
            lightmode.AutoSize = true;
            lightmode.Location = new Point(160, 177);
            lightmode.Name = "lightmode";
            lightmode.Size = new Size(79, 19);
            lightmode.TabIndex = 6;
            lightmode.TabStop = true;
            lightmode.Text = "Açık Tema";
            lightmode.UseVisualStyleBackColor = true;
            lightmode.CheckedChanged += lightmode_CheckedChanged;
            // 
            // darkmode
            // 
            darkmode.AutoSize = true;
            darkmode.Location = new Point(245, 177);
            darkmode.Name = "darkmode";
            darkmode.Size = new Size(83, 19);
            darkmode.TabIndex = 7;
            darkmode.TabStop = true;
            darkmode.Text = "Koyu Tema";
            darkmode.UseVisualStyleBackColor = true;
            darkmode.CheckedChanged += darkmode_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 248);
            label5.Name = "label5";
            label5.Size = new Size(349, 21);
            label5.TabIndex = 8;
            label5.Text = "Program açıldığında ilk hangi sayfa gösterilsin :";
            // 
            // settingscombo
            // 
            settingscombo.BackColor = Color.FromArgb(42, 42, 42);
            settingscombo.DropDownStyle = ComboBoxStyle.DropDownList;
            settingscombo.FlatStyle = FlatStyle.Flat;
            settingscombo.ForeColor = SystemColors.Control;
            settingscombo.FormattingEnabled = true;
            settingscombo.Items.AddRange(new object[] { "SüreÖlçer", "Saatler", "Kronometre", "Ayarlar" });
            settingscombo.Location = new Point(147, 295);
            settingscombo.Name = "settingscombo";
            settingscombo.Size = new Size(121, 23);
            settingscombo.TabIndex = 9;
            settingscombo.SelectedIndexChanged += settingscombo_SelectedIndexChanged;
            // 
            // updateinfo
            // 
            updateinfo.AutoSize = true;
            updateinfo.ForeColor = Color.IndianRed;
            updateinfo.Location = new Point(362, 97);
            updateinfo.Name = "updateinfo";
            updateinfo.Size = new Size(0, 15);
            updateinfo.TabIndex = 10;
            // 
            // temainfo
            // 
            temainfo.AutoSize = true;
            temainfo.ForeColor = Color.IndianRed;
            temainfo.Location = new Point(152, 205);
            temainfo.Name = "temainfo";
            temainfo.Size = new Size(0, 15);
            temainfo.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(49, 49, 49);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.darkrestart;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(369, 167);
            button2.Name = "button2";
            button2.Size = new Size(126, 39);
            button2.TabIndex = 12;
            button2.Text = "Yeniden Başlat";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(70, 297);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "Sayfalar :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(170, 84);
            label7.Name = "label7";
            label7.Size = new Size(76, 17);
            label7.TabIndex = 14;
            label7.Text = "Developer :";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.Control;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9.55F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = SystemColors.Control;
            linkLabel1.Location = new Point(248, 84);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 17);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "İnstagram";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ayarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(640, 409);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(temainfo);
            Controls.Add(updateinfo);
            Controls.Add(settingscombo);
            Controls.Add(label5);
            Controls.Add(darkmode);
            Controls.Add(lightmode);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ayarlar";
            Text = "ayarlar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private RadioButton lightmode;
        private RadioButton darkmode;
        private Label label5;
        private ComboBox settingscombo;
        private Label updateinfo;
        private Label temainfo;
        private Button button2;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}
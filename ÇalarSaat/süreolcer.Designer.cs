namespace ÇalarSaat
{
    partial class süreolcer
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btnstart = new Button();
            hoursayım = new Label();
            secondlabel = new Label();
            minutelabel = new Label();
            hourlabel = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            down3 = new Button();
            up3 = new Button();
            down2 = new Button();
            up2 = new Button();
            up1 = new Button();
            down1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(44, 44, 44);
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(372, 84);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 20;
            label3.Text = "Saniye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(44, 44, 44);
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 19;
            label2.Text = "Dakika";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 44, 44);
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 83);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 18;
            label1.Text = "Saat";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(49, 49, 49);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.darkstop;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(316, 287);
            button1.Name = "button1";
            button1.Size = new Size(83, 37);
            button1.TabIndex = 17;
            button1.Text = "Dur";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnstart
            // 
            btnstart.BackColor = Color.FromArgb(49, 49, 49);
            btnstart.FlatAppearance.BorderSize = 0;
            btnstart.FlatStyle = FlatStyle.Flat;
            btnstart.Image = Properties.Resources.darkstart;
            btnstart.ImageAlign = ContentAlignment.MiddleLeft;
            btnstart.Location = new Point(227, 287);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(83, 37);
            btnstart.TabIndex = 16;
            btnstart.Text = "Başlat";
            btnstart.TextAlign = ContentAlignment.MiddleRight;
            btnstart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnstart.UseVisualStyleBackColor = false;
            btnstart.Click += btnstart_Click;
            // 
            // hoursayım
            // 
            hoursayım.AutoSize = true;
            hoursayım.BackColor = Color.FromArgb(39, 39, 39);
            hoursayım.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            hoursayım.Location = new Point(245, 219);
            hoursayım.Name = "hoursayım";
            hoursayım.Size = new Size(126, 45);
            hoursayım.TabIndex = 15;
            hoursayım.Text = "0 : 0 : 0";
            // 
            // secondlabel
            // 
            secondlabel.AutoSize = true;
            secondlabel.BackColor = Color.FromArgb(44, 44, 44);
            secondlabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            secondlabel.Location = new Point(383, 102);
            secondlabel.Name = "secondlabel";
            secondlabel.Size = new Size(25, 30);
            secondlabel.TabIndex = 14;
            secondlabel.Text = "0";
            // 
            // minutelabel
            // 
            minutelabel.AutoSize = true;
            minutelabel.BackColor = Color.FromArgb(44, 44, 44);
            minutelabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            minutelabel.Location = new Point(298, 102);
            minutelabel.Name = "minutelabel";
            minutelabel.Size = new Size(25, 30);
            minutelabel.TabIndex = 13;
            minutelabel.Text = "0";
            // 
            // hourlabel
            // 
            hourlabel.AutoSize = true;
            hourlabel.BackColor = Color.FromArgb(44, 44, 44);
            hourlabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hourlabel.Location = new Point(213, 102);
            hourlabel.Name = "hourlabel";
            hourlabel.Size = new Size(25, 30);
            hourlabel.TabIndex = 12;
            hourlabel.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(44, 44, 44);
            pictureBox3.Location = new Point(187, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 70);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(44, 44, 44);
            pictureBox2.Location = new Point(359, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 70);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(44, 44, 44);
            pictureBox1.Location = new Point(273, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 70);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // down3
            // 
            down3.BackColor = Color.FromArgb(40, 40, 40);
            down3.FlatAppearance.BorderSize = 0;
            down3.FlatStyle = FlatStyle.Flat;
            down3.Image = Properties.Resources.darkdown;
            down3.Location = new Point(374, 149);
            down3.Name = "down3";
            down3.Size = new Size(43, 40);
            down3.TabIndex = 8;
            down3.UseVisualStyleBackColor = false;
            down3.Click += down3_Click;
            // 
            // up3
            // 
            up3.BackColor = Color.FromArgb(40, 40, 40);
            up3.FlatAppearance.BorderSize = 0;
            up3.FlatStyle = FlatStyle.Flat;
            up3.Image = Properties.Resources.darkup;
            up3.Location = new Point(374, 26);
            up3.Name = "up3";
            up3.Size = new Size(43, 40);
            up3.TabIndex = 7;
            up3.UseVisualStyleBackColor = false;
            up3.Click += up3_Click;
            // 
            // down2
            // 
            down2.BackColor = Color.FromArgb(40, 40, 40);
            down2.FlatAppearance.BorderSize = 0;
            down2.FlatStyle = FlatStyle.Flat;
            down2.Image = Properties.Resources.darkdown;
            down2.Location = new Point(289, 149);
            down2.Name = "down2";
            down2.Size = new Size(43, 40);
            down2.TabIndex = 6;
            down2.UseVisualStyleBackColor = false;
            down2.Click += down2_Click;
            // 
            // up2
            // 
            up2.BackColor = Color.FromArgb(40, 40, 40);
            up2.FlatAppearance.BorderSize = 0;
            up2.FlatStyle = FlatStyle.Flat;
            up2.Image = Properties.Resources.darkup;
            up2.Location = new Point(289, 26);
            up2.Name = "up2";
            up2.Size = new Size(43, 40);
            up2.TabIndex = 5;
            up2.UseVisualStyleBackColor = false;
            up2.Click += up2_Click;
            // 
            // up1
            // 
            up1.BackColor = Color.FromArgb(40, 40, 40);
            up1.FlatAppearance.BorderSize = 0;
            up1.FlatStyle = FlatStyle.Flat;
            up1.Image = Properties.Resources.darkup;
            up1.Location = new Point(201, 26);
            up1.Name = "up1";
            up1.Size = new Size(43, 40);
            up1.TabIndex = 4;
            up1.UseVisualStyleBackColor = false;
            up1.Click += up1_Click;
            // 
            // down1
            // 
            down1.BackColor = Color.FromArgb(40, 40, 40);
            down1.FlatAppearance.BorderSize = 0;
            down1.FlatStyle = FlatStyle.Flat;
            down1.Image = Properties.Resources.darkdown;
            down1.Location = new Point(201, 149);
            down1.Name = "down1";
            down1.Size = new Size(43, 40);
            down1.TabIndex = 3;
            down1.UseVisualStyleBackColor = false;
            down1.Click += down1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // süreolcer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(640, 409);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(up2);
            Controls.Add(label1);
            Controls.Add(down1);
            Controls.Add(button1);
            Controls.Add(up1);
            Controls.Add(btnstart);
            Controls.Add(down2);
            Controls.Add(hoursayım);
            Controls.Add(up3);
            Controls.Add(secondlabel);
            Controls.Add(down3);
            Controls.Add(minutelabel);
            Controls.Add(pictureBox1);
            Controls.Add(hourlabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "süreolcer";
            Text = "p";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button down3;
        private Button up3;
        private Button down2;
        private Button up2;
        private Button up1;
        private Button down1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label secondlabel;
        private Label minutelabel;
        private Label hourlabel;
        private Label hoursayım;
        private System.Windows.Forms.Timer timer1;
        private Button btnstart;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
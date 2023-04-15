namespace ÇalarSaat
{
    partial class kronometre
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
            button1 = new Button();
            button2 = new Button();
            kronomtrelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(49, 49, 49);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.darkstart;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(236, 191);
            button1.Name = "button1";
            button1.Size = new Size(72, 42);
            button1.TabIndex = 0;
            button1.Text = "Başla";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 44, 44);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.darkstop;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(314, 191);
            button2.Name = "button2";
            button2.Size = new Size(72, 42);
            button2.TabIndex = 1;
            button2.Text = "Dur";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // kronomtrelbl
            // 
            kronomtrelbl.AutoSize = true;
            kronomtrelbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            kronomtrelbl.Location = new Point(223, 73);
            kronomtrelbl.Name = "kronomtrelbl";
            kronomtrelbl.Size = new Size(178, 65);
            kronomtrelbl.TabIndex = 2;
            kronomtrelbl.Text = "0 : 0 : 0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // kronometre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(640, 409);
            Controls.Add(kronomtrelbl);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "kronometre";
            Text = "kronometre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label kronomtrelbl;
        private System.Windows.Forms.Timer timer1;
    }
}
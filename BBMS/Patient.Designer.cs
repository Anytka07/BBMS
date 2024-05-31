namespace BBMS
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            PBGroupCb = new ComboBox();
            PAdressTb = new TextBox();
            label15 = new Label();
            label14 = new Label();
            PPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            PAgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            PNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            PGenCb = new ComboBox();
            label10 = new Label();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            panel1 = new Panel();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(736, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(872, 362);
            label16.Name = "label16";
            label16.Size = new Size(146, 28);
            label16.TabIndex = 45;
            label16.Text = "Blood Group";
            // 
            // PBGroupCb
            // 
            PBGroupCb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PBGroupCb.FormattingEnabled = true;
            PBGroupCb.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            PBGroupCb.Location = new Point(872, 408);
            PBGroupCb.Name = "PBGroupCb";
            PBGroupCb.Size = new Size(206, 29);
            PBGroupCb.TabIndex = 44;
            // 
            // PAdressTb
            // 
            PAdressTb.Location = new Point(663, 527);
            PAdressTb.Multiline = true;
            PAdressTb.Name = "PAdressTb";
            PAdressTb.Size = new Size(255, 104);
            PAdressTb.TabIndex = 43;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(663, 483);
            label15.Name = "label15";
            label15.Size = new Size(86, 28);
            label15.TabIndex = 42;
            label15.Text = "Adress";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(995, 221);
            label14.Name = "label14";
            label14.Size = new Size(123, 28);
            label14.TabIndex = 41;
            label14.Text = "Telephone";
            // 
            // PPhoneTb
            // 
            PPhoneTb.BackColor = Color.Red;
            PPhoneTb.BorderColor = Color.Red;
            PPhoneTb.BorderThickness = 3;
            PPhoneTb.CustomizableEdges = customizableEdges1;
            PPhoneTb.DefaultText = "";
            PPhoneTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PPhoneTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PPhoneTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PPhoneTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PPhoneTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PPhoneTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PPhoneTb.ForeColor = Color.Red;
            PPhoneTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PPhoneTb.Location = new Point(995, 259);
            PPhoneTb.Margin = new Padding(4, 3, 4, 3);
            PPhoneTb.Name = "PPhoneTb";
            PPhoneTb.PasswordChar = '\0';
            PPhoneTb.PlaceholderText = "";
            PPhoneTb.SelectedText = "";
            PPhoneTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PPhoneTb.Size = new Size(180, 37);
            PPhoneTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            PPhoneTb.TabIndex = 40;
            // 
            // PAgeTb
            // 
            PAgeTb.BackColor = Color.Red;
            PAgeTb.BorderColor = Color.Red;
            PAgeTb.BorderThickness = 3;
            PAgeTb.CustomizableEdges = customizableEdges3;
            PAgeTb.DefaultText = "";
            PAgeTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PAgeTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PAgeTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PAgeTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PAgeTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PAgeTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PAgeTb.ForeColor = Color.Red;
            PAgeTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PAgeTb.Location = new Point(696, 259);
            PAgeTb.Margin = new Padding(4, 3, 4, 3);
            PAgeTb.Name = "PAgeTb";
            PAgeTb.PasswordChar = '\0';
            PAgeTb.PlaceholderText = "";
            PAgeTb.SelectedText = "";
            PAgeTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PAgeTb.Size = new Size(180, 37);
            PAgeTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            PAgeTb.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(411, 362);
            label13.Name = "label13";
            label13.Size = new Size(91, 28);
            label13.TabIndex = 38;
            label13.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(696, 221);
            label12.Name = "label12";
            label12.Size = new Size(53, 28);
            label12.TabIndex = 37;
            label12.Text = "Age";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(411, 221);
            label11.Name = "label11";
            label11.Size = new Size(76, 28);
            label11.TabIndex = 36;
            label11.Text = "Name";
            // 
            // PNameTb
            // 
            PNameTb.BackColor = Color.Red;
            PNameTb.BorderColor = Color.Red;
            PNameTb.BorderThickness = 3;
            PNameTb.CustomizableEdges = customizableEdges5;
            PNameTb.DefaultText = "";
            PNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PNameTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PNameTb.ForeColor = Color.Red;
            PNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PNameTb.Location = new Point(411, 259);
            PNameTb.Margin = new Padding(4, 3, 4, 3);
            PNameTb.Name = "PNameTb";
            PNameTb.PasswordChar = '\0';
            PNameTb.PlaceholderText = "";
            PNameTb.SelectedText = "";
            PNameTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PNameTb.Size = new Size(180, 37);
            PNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            PNameTb.TabIndex = 35;
            // 
            // PGenCb
            // 
            PGenCb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PGenCb.FormattingEnabled = true;
            PGenCb.Items.AddRange(new object[] { "Male", "Female" });
            PGenCb.Location = new Point(411, 408);
            PGenCb.Name = "PGenCb";
            PGenCb.Size = new Size(206, 29);
            PGenCb.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(716, 71);
            label10.Name = "label10";
            label10.Size = new Size(134, 40);
            label10.TabIndex = 47;
            label10.Text = "Patient";
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.Firebrick;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.Firebrick;
            bunifuThinButton21.BackColor = Color.White;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Save";
            bunifuThinButton21.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.Red;
            bunifuThinButton21.IdleForecolor = Color.White;
            bunifuThinButton21.IdleLineColor = Color.Red;
            bunifuThinButton21.Location = new Point(733, 667);
            bunifuThinButton21.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(130, 56);
            bunifuThinButton21.TabIndex = 48;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 761);
            panel1.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 206);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 17;
            label1.Text = "Donate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(63, 702);
            label9.Name = "label9";
            label9.Size = new Size(111, 35);
            label9.TabIndex = 15;
            label9.Text = "Logout";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(53, 585);
            label8.Name = "label8";
            label8.Size = new Size(157, 33);
            label8.TabIndex = 14;
            label8.Text = "Dashboard";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(53, 517);
            label7.Name = "label7";
            label7.Size = new Size(208, 33);
            label7.TabIndex = 12;
            label7.Text = "Blood Transfer";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(53, 438);
            label6.Name = "label6";
            label6.Size = new Size(168, 33);
            label6.TabIndex = 10;
            label6.Text = "Blood Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 362);
            label5.Name = "label5";
            label5.Size = new Size(198, 33);
            label5.TabIndex = 8;
            label5.Text = "View Patients";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 133);
            label4.Name = "label4";
            label4.Size = new Size(180, 33);
            label4.TabIndex = 6;
            label4.Text = "View Donors";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(26, 286);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 37);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 283);
            label3.Name = "label3";
            label3.Size = new Size(112, 33);
            label3.TabIndex = 4;
            label3.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 59);
            label2.Name = "label2";
            label2.Size = new Size(94, 33);
            label2.TabIndex = 2;
            label2.Text = "Donor";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1303, 761);
            Controls.Add(panel1);
            Controls.Add(bunifuThinButton21);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label16);
            Controls.Add(PBGroupCb);
            Controls.Add(PAdressTb);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(PPhoneTb);
            Controls.Add(PAgeTb);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(PNameTb);
            Controls.Add(PGenCb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label16;
        private ComboBox PBGroupCb;
        private TextBox PAdressTb;
        private Label label15;
        private Label label14;
        private Guna.UI2.WinForms.Guna2TextBox PPhoneTb;
        private Guna.UI2.WinForms.Guna2TextBox PAgeTb;
        private Label label13;
        private Label label12;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox PNameTb;
        private ComboBox PGenCb;
        private Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Panel panel1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Label label2;
    }
}
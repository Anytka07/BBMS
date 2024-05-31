namespace BBMS
{
    partial class BloodTransfert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodTransfert));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label13 = new Label();
            PatientldCb = new ComboBox();
            label11 = new Label();
            PatNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            BloodGroup = new Guna.UI2.WinForms.Guna2TextBox();
            label12 = new Label();
            AvailableLbl = new Label();
            TransferBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            panel1 = new Panel();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel8 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(763, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(671, 86);
            label10.Name = "label10";
            label10.Size = new Size(266, 40);
            label10.TabIndex = 35;
            label10.Text = "Blood Transfert";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(389, 280);
            label13.Name = "label13";
            label13.Size = new Size(119, 28);
            label13.TabIndex = 40;
            label13.Text = "Patient Id";
            // 
            // PatientldCb
            // 
            PatientldCb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatientldCb.FormattingEnabled = true;
            PatientldCb.Location = new Point(389, 326);
            PatientldCb.Name = "PatientldCb";
            PatientldCb.Size = new Size(206, 29);
            PatientldCb.TabIndex = 39;
            PatientldCb.SelectionChangeCommitted += PatientldCb_SelectionChangeCommitted;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(696, 280);
            label11.Name = "label11";
            label11.Size = new Size(161, 28);
            label11.TabIndex = 41;
            label11.Text = "Patient Name";
            // 
            // PatNameTb
            // 
            PatNameTb.BackColor = Color.Red;
            PatNameTb.BorderColor = Color.Red;
            PatNameTb.BorderThickness = 3;
            PatNameTb.CustomizableEdges = customizableEdges1;
            PatNameTb.DefaultText = "";
            PatNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatNameTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatNameTb.ForeColor = Color.Red;
            PatNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatNameTb.Location = new Point(696, 318);
            PatNameTb.Margin = new Padding(4, 3, 4, 3);
            PatNameTb.Name = "PatNameTb";
            PatNameTb.PasswordChar = '\0';
            PatNameTb.PlaceholderText = "";
            PatNameTb.SelectedText = "";
            PatNameTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PatNameTb.Size = new Size(180, 37);
            PatNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            PatNameTb.TabIndex = 52;
            // 
            // BloodGroup
            // 
            BloodGroup.BackColor = Color.Red;
            BloodGroup.BorderColor = Color.Red;
            BloodGroup.BorderThickness = 3;
            BloodGroup.CustomizableEdges = customizableEdges3;
            BloodGroup.DefaultText = "";
            BloodGroup.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BloodGroup.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BloodGroup.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BloodGroup.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BloodGroup.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodGroup.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BloodGroup.ForeColor = Color.Red;
            BloodGroup.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodGroup.Location = new Point(993, 318);
            BloodGroup.Margin = new Padding(4, 3, 4, 3);
            BloodGroup.Name = "BloodGroup";
            BloodGroup.PasswordChar = '\0';
            BloodGroup.PlaceholderText = "";
            BloodGroup.SelectedText = "";
            BloodGroup.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BloodGroup.Size = new Size(180, 37);
            BloodGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            BloodGroup.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(993, 280);
            label12.Name = "label12";
            label12.Size = new Size(146, 28);
            label12.TabIndex = 53;
            label12.Text = "Blood Group";
            // 
            // AvailableLbl
            // 
            AvailableLbl.AutoSize = true;
            AvailableLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AvailableLbl.ForeColor = Color.Red;
            AvailableLbl.Location = new Point(696, 438);
            AvailableLbl.Name = "AvailableLbl";
            AvailableLbl.Size = new Size(198, 27);
            AvailableLbl.TabIndex = 55;
            AvailableLbl.Text = "AvailableOrNot";
            AvailableLbl.Visible = false;
            // 
            // TransferBtn
            // 
            TransferBtn.ActiveBorderThickness = 1;
            TransferBtn.ActiveCornerRadius = 20;
            TransferBtn.ActiveFillColor = Color.Firebrick;
            TransferBtn.ActiveForecolor = Color.White;
            TransferBtn.ActiveLineColor = Color.Firebrick;
            TransferBtn.BackColor = Color.White;
            TransferBtn.BackgroundImage = (Image)resources.GetObject("TransferBtn.BackgroundImage");
            TransferBtn.ButtonText = "Transfert";
            TransferBtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TransferBtn.ForeColor = Color.SeaGreen;
            TransferBtn.IdleBorderThickness = 1;
            TransferBtn.IdleCornerRadius = 20;
            TransferBtn.IdleFillColor = Color.Red;
            TransferBtn.IdleForecolor = Color.White;
            TransferBtn.IdleLineColor = Color.Red;
            TransferBtn.Location = new Point(658, 494);
            TransferBtn.Margin = new Padding(6, 6, 6, 6);
            TransferBtn.Name = "TransferBtn";
            TransferBtn.Size = new Size(275, 56);
            TransferBtn.TabIndex = 62;
            TransferBtn.TextAlign = ContentAlignment.MiddleCenter;
            TransferBtn.Visible = false;
            TransferBtn.Click += TransferBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 761);
            panel1.TabIndex = 63;
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
            label8.Click += label8_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(26, 515);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 37);
            panel8.TabIndex = 11;
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
            label6.Click += label6_Click;
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
            label3.Click += label3_Click;
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
            // BloodTransfert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1303, 761);
            Controls.Add(panel1);
            Controls.Add(TransferBtn);
            Controls.Add(AvailableLbl);
            Controls.Add(BloodGroup);
            Controls.Add(label12);
            Controls.Add(PatNameTb);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(PatientldCb);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BloodTransfert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodTransfert";
            Load += BloodTransfert_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label10;
        private Label label13;
        private ComboBox PatientldCb;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox PatNameTb;
        private Guna.UI2.WinForms.Guna2TextBox BloodGroup;
        private Label label12;
        private Label AvailableLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 TransferBtn;
        private Panel panel1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Panel panel8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
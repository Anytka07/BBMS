namespace BBMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EmpIdTb = new TextBox();
            EmpPassTb = new TextBox();
            label3 = new Label();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(100, 26);
            label1.Name = "label1";
            label1.Size = new Size(457, 33);
            label1.TabIndex = 1;
            label1.Text = "Blood Bank Management System ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(288, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(119, 170);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // EmpIdTb
            // 
            EmpIdTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdTb.Location = new Point(260, 167);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(203, 32);
            EmpIdTb.TabIndex = 4;
            // 
            // EmpPassTb
            // 
            EmpPassTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPassTb.Location = new Point(260, 223);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.Size = new Size(203, 32);
            EmpPassTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(119, 226);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton21.BackColor = Color.White;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Login";
            bunifuThinButton21.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.Red;
            bunifuThinButton21.IdleForecolor = Color.White;
            bunifuThinButton21.IdleLineColor = Color.Red;
            bunifuThinButton21.Location = new Point(222, 278);
            bunifuThinButton21.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(241, 54);
            bunifuThinButton21.TabIndex = 7;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(241, 350);
            label4.Name = "label4";
            label4.Size = new Size(190, 23);
            label4.TabIndex = 8;
            label4.Text = "Continue As Admin";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(611, 9);
            label5.Name = "label5";
            label5.Size = new Size(24, 23);
            label5.TabIndex = 9;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 411);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(bunifuThinButton21);
            Controls.Add(EmpPassTb);
            Controls.Add(label3);
            Controls.Add(EmpIdTb);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox EmpIdTb;
        private TextBox EmpPassTb;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label4;
        private Label label5;
    }
}
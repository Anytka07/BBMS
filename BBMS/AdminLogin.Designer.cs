namespace BBMS
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label5 = new Label();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            AdminPassTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(646, 9);
            label5.Name = "label5";
            label5.Size = new Size(24, 23);
            label5.TabIndex = 14;
            label5.Text = "X";
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
            bunifuThinButton21.Location = new Point(235, 234);
            bunifuThinButton21.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(241, 54);
            bunifuThinButton21.TabIndex = 13;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // AdminPassTb
            // 
            AdminPassTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdminPassTb.Location = new Point(289, 162);
            AdminPassTb.Name = "AdminPassTb";
            AdminPassTb.Size = new Size(203, 32);
            AdminPassTb.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(154, 165);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(129, 35);
            label1.Name = "label1";
            label1.Size = new Size(457, 33);
            label1.TabIndex = 10;
            label1.Text = "Blood Bank Management System ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(311, 315);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 15;
            label4.Text = "Cancel";
            label4.Click += label4_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 390);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(bunifuThinButton21);
            Controls.Add(AdminPassTb);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private TextBox AdminPassTb;
        private Label label3;
        private Label label1;
        private Label label4;
    }
}
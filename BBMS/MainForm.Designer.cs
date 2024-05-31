namespace BBMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(53, 206);
            label10.Name = "label10";
            label10.Size = new Size(109, 33);
            label10.TabIndex = 17;
            label10.Text = "Donate";
            label10.Click += label10_Click;
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
            label9.Click += label9_Click;
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
            label4.Click += label4_Click;
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
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(277, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 48);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(457, 33);
            label1.TabIndex = 2;
            label1.Text = "Blood Bank Management System ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(561, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1303, 761);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label10;
    }
}
namespace BBMS
{
    partial class Employee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel10 = new Panel();
            label2 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            EmployeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            EmpPassTb = new Guna.UI2.WinForms.Guna2TextBox();
            label12 = new Label();
            label11 = new Label();
            EmpNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label10 = new Label();
            bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(38, 73);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 37);
            panel10.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 70);
            label2.Name = "label2";
            label2.Size = new Size(155, 33);
            label2.TabIndex = 17;
            label2.Text = "Employees";
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
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(277, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 48);
            panel2.TabIndex = 69;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 761);
            panel1.TabIndex = 68;
            // 
            // EmployeeDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmployeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeeDGV.ColumnHeadersHeight = 28;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeeDGV.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeDGV.Location = new Point(364, 197);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersVisible = false;
            EmployeeDGV.RowHeadersWidth = 51;
            EmployeeDGV.RowTemplate.Height = 25;
            EmployeeDGV.Size = new Size(838, 306);
            EmployeeDGV.TabIndex = 64;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeDGV.ThemeStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = Color.Red;
            EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeDGV.ThemeStyle.HeaderStyle.Height = 28;
            EmployeeDGV.ThemeStyle.ReadOnly = false;
            EmployeeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeDGV.ThemeStyle.RowsStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = Color.White;
            EmployeeDGV.ThemeStyle.RowsStyle.Height = 25;
            EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Firebrick;
            EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
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
            bunifuThinButton21.IdleFillColor = Color.MediumVioletRed;
            bunifuThinButton21.IdleForecolor = Color.White;
            bunifuThinButton21.IdleLineColor = Color.MediumVioletRed;
            bunifuThinButton21.Location = new Point(570, 665);
            bunifuThinButton21.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(130, 56);
            bunifuThinButton21.TabIndex = 62;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // EmpPassTb
            // 
            EmpPassTb.BackColor = Color.Red;
            EmpPassTb.BorderColor = Color.Red;
            EmpPassTb.BorderThickness = 3;
            EmpPassTb.CustomizableEdges = customizableEdges1;
            EmpPassTb.DefaultText = "";
            EmpPassTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmpPassTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmpPassTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmpPassTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmpPassTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpPassTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPassTb.ForeColor = Color.Red;
            EmpPassTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpPassTb.Location = new Point(870, 586);
            EmpPassTb.Margin = new Padding(4, 3, 4, 3);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.PasswordChar = '\0';
            EmpPassTb.PlaceholderForeColor = Color.White;
            EmpPassTb.PlaceholderText = "";
            EmpPassTb.SelectedText = "";
            EmpPassTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmpPassTb.Size = new Size(193, 37);
            EmpPassTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            EmpPassTb.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(870, 548);
            label12.Name = "label12";
            label12.Size = new Size(115, 28);
            label12.TabIndex = 60;
            label12.Text = "Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(570, 548);
            label11.Name = "label11";
            label11.Size = new Size(76, 28);
            label11.TabIndex = 59;
            label11.Text = "Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BackColor = Color.Red;
            EmpNameTb.BorderColor = Color.Red;
            EmpNameTb.BorderThickness = 3;
            EmpNameTb.CustomizableEdges = customizableEdges3;
            EmpNameTb.DefaultText = "";
            EmpNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmpNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmpNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmpNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmpNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpNameTb.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.ForeColor = Color.Red;
            EmpNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpNameTb.Location = new Point(570, 586);
            EmpNameTb.Margin = new Padding(4, 3, 4, 3);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.PasswordChar = '\0';
            EmpNameTb.PlaceholderForeColor = Color.White;
            EmpNameTb.PlaceholderText = "";
            EmpNameTb.SelectedText = "";
            EmpNameTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmpNameTb.Size = new Size(194, 37);
            EmpNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            EmpNameTb.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(700, 63);
            label10.Name = "label10";
            label10.Size = new Size(188, 40);
            label10.TabIndex = 57;
            label10.Text = "Employees";
            // 
            // bunifuThinButton22
            // 
            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = Color.Firebrick;
            bunifuThinButton22.ActiveForecolor = Color.White;
            bunifuThinButton22.ActiveLineColor = Color.Firebrick;
            bunifuThinButton22.BackColor = Color.White;
            bunifuThinButton22.BackgroundImage = (Image)resources.GetObject("bunifuThinButton22.BackgroundImage");
            bunifuThinButton22.ButtonText = "Edit";
            bunifuThinButton22.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton22.ForeColor = Color.SeaGreen;
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = Color.ForestGreen;
            bunifuThinButton22.IdleForecolor = Color.White;
            bunifuThinButton22.IdleLineColor = Color.ForestGreen;
            bunifuThinButton22.Location = new Point(758, 665);
            bunifuThinButton22.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new Size(130, 56);
            bunifuThinButton22.TabIndex = 70;
            bunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton22.Click += bunifuThinButton22_Click;
            // 
            // bunifuThinButton23
            // 
            bunifuThinButton23.ActiveBorderThickness = 1;
            bunifuThinButton23.ActiveCornerRadius = 20;
            bunifuThinButton23.ActiveFillColor = Color.Firebrick;
            bunifuThinButton23.ActiveForecolor = Color.White;
            bunifuThinButton23.ActiveLineColor = Color.Firebrick;
            bunifuThinButton23.BackColor = Color.White;
            bunifuThinButton23.BackgroundImage = (Image)resources.GetObject("bunifuThinButton23.BackgroundImage");
            bunifuThinButton23.ButtonText = "Delete";
            bunifuThinButton23.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton23.ForeColor = Color.SeaGreen;
            bunifuThinButton23.IdleBorderThickness = 1;
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleFillColor = Color.Red;
            bunifuThinButton23.IdleForecolor = Color.White;
            bunifuThinButton23.IdleLineColor = Color.Red;
            bunifuThinButton23.Location = new Point(933, 665);
            bunifuThinButton23.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton23.Name = "bunifuThinButton23";
            bunifuThinButton23.Size = new Size(130, 56);
            bunifuThinButton23.TabIndex = 71;
            bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton23.Click += bunifuThinButton23_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1303, 761);
            Controls.Add(bunifuThinButton23);
            Controls.Add(bunifuThinButton22);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(EmployeeDGV);
            Controls.Add(pictureBox1);
            Controls.Add(bunifuThinButton21);
            Controls.Add(EmpPassTb);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(EmpNameTb);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel10;
        private Label label2;
        private Label label9;
        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDGV;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI2.WinForms.Guna2TextBox EmpPassTb;
        private Label label12;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTb;
        private Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}
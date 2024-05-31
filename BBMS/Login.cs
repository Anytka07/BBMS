using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin Adm = new AdminLogin();
            Adm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTbl where EmpId = '" + EmpIdTb.Text + "'and EmpPass='" + EmpPassTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm Main = new MainForm();
                Main.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            GetData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor DO = new Donor();
            DO.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DonorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from TransferTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            TransferLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from EmployeeTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserLbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert BT = new BloodTransfert();
            BT.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DonateBlood DonBl = new DonateBlood();
            DonBl.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

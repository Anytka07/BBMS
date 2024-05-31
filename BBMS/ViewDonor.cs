using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBMS
{
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string Query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewDonor_Load(object sender, EventArgs e)
        {

        }

        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor DN = new Donor();
            DN.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DonateBlood DB = new DonateBlood();
            DB.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient PA = new Patient();
            PA.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock BS = new BloodStock();
            BS.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert BTR = new BloodTransfert();
            BTR.Show();
            this.Hide();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BBMS
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
            bloodStock();
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

        private void bloodStock()
        {
            Con.Open();
            string Query = "select * from BloodTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStockDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonateBlood_Load(object sender, EventArgs e)
        {

        }
        int oldstock;
        private void GetStock(string Bgroup)
        {
            Con.Open();
            string query = "select * from BloodTbl where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());

            }
            Con.Close();
        }

        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = DonorDGV.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);
        }

        private void reset()
        {
            DNameTb.Text = "";
            BGroupTb.Text = "";


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Select a Donor");
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = "update BloodTbl set BStock=" + stock + "where BGroup='" + BGroupTb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull");
                    Con.Close();
                    reset();
                    bloodStock();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient PT = new Patient();
            PT.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BBMS
{
    public partial class BloodTransfert : Form
    {
        public BloodTransfert()
        {
            InitializeComponent();
            fillPatientCb();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");

        private void fillPatientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PName", typeof(string));
            dt.Load(rdr);
            PatientldCb.ValueMember = "PNum";
            PatientldCb.DataSource = dt;
            Con.Close();
        }
        private void GetData()
        {
            Con.Open();
            string query = "select * from PatientTbl where PNum='" + PatientldCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PName"].ToString();
                BloodGroup.Text = dr["PBGroup"].ToString();


            }
            Con.Close();
        }
        int stock = 0;
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
                stock = Convert.ToInt32(dr["BStock"].ToString());

            }
            Con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard DB = new DashBoard();
            DB.Show();
            this.Hide();
        }

        private void BloodTransfert_Load(object sender, EventArgs e)
        {

        }
        /*int oldstock;
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
        }*/
        private void PatientldCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroup.Text);
            if (stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available STock";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Stock not Available";
                AvailableLbl.Visible = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }
        private void Reset()
        {
            PatNameTb.Text = "";
            //PatientldCb.SelectedIndex = -1;
            BloodGroup.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update BloodTbl set BStock=" + newstock + "where BGroup='" + BloodGroup.Text + "';";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Patient Successfully Edit");
                Con.Close();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTbl values('" + PatNameTb.Text + "','" + BloodGroup.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull Transfer");
                    Con.Close();
                    GetStock(BloodGroup.Text);
                    updateStock();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock Bstock = new BloodStock();
            Bstock.Show();
            this.Hide();
        }
    }
}

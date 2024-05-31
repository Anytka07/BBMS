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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCB.SelectedIndex = -1;
            DAddressTb.Text = "";
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCB.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into DonorTbl values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCB.SelectedItem.ToString() + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved");
                    Con.Close();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }


        private void label4_Click_1(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
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

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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void Patient_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAdressTb.Text = "";
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAdressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into PatientTbl values('" + PNameTb.Text + "'," + PAgeTb.Text + ",'" + PPhoneTb.Text + "','" + PGenCb.SelectedItem.ToString() + "','" + PBGroupCb.SelectedItem.ToString() + "','" + PAdressTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Saved");
                    Con.Close();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void label5_Click_1(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert Bt = new BloodTransfert();
            Bt.Show();
            this.Hide();
        }
    }
}

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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string Query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewPatients_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
            key = 0;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Patient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
                    Con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    string query = "update PatientTbl set PName='" + PNameTb.Text + "',PAge=" + PAgeTb.Text + ",PPhone='" + PPhoneTb.Text + "',PGender='" + PGenCb.SelectedItem.ToString() + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "',PAddress='" + PAddressTb.Text + "'where PNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated");
                    Con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();
            VD.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor DD = new Donor();
            DD.Show();
            this.Hide();
        }


        private void label6_Click_1(object sender, EventArgs e)
        {
            BloodStock BS = new BloodStock();
            BS.Show();
            this.Hide();
        }
    }
}

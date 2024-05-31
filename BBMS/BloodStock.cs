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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            bloodStock();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert BT = new BloodTransfert();
            BT.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1TDJKD4;Initial Catalog=BloodBankDb;Integrated Security=True");
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
        private void BloodStock_Load(object sender, EventArgs e)
        {

        }
    }
}

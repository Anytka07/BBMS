using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor Don = new Donor();
            Don.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewDonor ViDon = new ViewDonor();
            ViDon.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DonateBlood Donate = new DonateBlood();
            Donate.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }
    }
}

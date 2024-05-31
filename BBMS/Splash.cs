namespace BBMS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}
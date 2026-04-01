namespace Projekt_Sharikov_Andrii
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1 % 100;
                timer1.Stop();
                HlavniMenu form1 = new HlavniMenu();
                form1.Show();
                this.Hide();
            
        }

    }
}

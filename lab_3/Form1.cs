namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unitTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnitTestForm f = new UnitTestForm();
            f.Show();
            this.Hide();
        }
    }
}

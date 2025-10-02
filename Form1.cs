namespace personal_planning_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }







        private void todoListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 abs = new Form6();
            abs.Show();
        }

        private void addBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 abs = new Form2();
            abs.Show();
        }

        private void viewBudgetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 abs = new Form3();
            abs.Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 abs = new Form5();
            abs.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

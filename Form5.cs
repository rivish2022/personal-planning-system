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

namespace personal_planning_system
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 abs = new Form1();
            abs.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedDate=dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string text = textBox1.Text;

            richTextBox1.AppendText($"{text}, {selectedDate}\n");

            textBox1.Clear();   


            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }
    }
}

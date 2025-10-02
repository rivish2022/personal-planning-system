using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox;
using static System.Windows.Forms.CheckBox;

namespace personal_planning_system
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Add checkbox names to ComboBox
            comboBox1.Items.Add("Checkbox 1");
            comboBox1.Items.Add("Checkbox 2");
            comboBox1.Items.Add("Checkbox 3");
            comboBox1.Items.Add("Checkbox 4");
            comboBox1.Items.Add("Checkbox 5");


            // Optional: set first item as selected
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newText = textBox1.Text; // the user input

            switch (comboBox1.SelectedIndex)
            {
                case 0: checkBox1.Text = newText; break;
                case 1: checkBox2.Text = newText; break;
                case 2: checkBox3.Text = newText; break;
                case 3: checkBox4.Text = newText; break;
                case 4: checkBox5.Text = newText; break;

            }
            textBox1.Clear();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    checkBox1.Text = "Checkbox 1";
                    checkBox1.Checked = false;
                    break;
                case 1:
                    checkBox2.Text = "Checkbox 2";
                    checkBox2.Checked = false;
                    break;
                case 2:
                    checkBox3.Text = "Checkbox 3";
                    checkBox3.Checked = false;
                    break;
                case 3:
                    checkBox4.Text = "Checkbox 4";
                    checkBox4.Checked = false;
                    break;
                case 4:
                    checkBox5.Text = "Checkbox 5";
                    checkBox5.Checked = false;
                    break;
                default:
                    MessageBox.Show("Invalid selection.");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Text = "Checkbox 1";
            checkBox1.Checked = false;

            checkBox2.Text = "Checkbox 2";
            checkBox2.Checked = false;

            checkBox3.Text = "Checkbox 3";
            checkBox3.Checked = false;

            checkBox4.Text = "Checkbox 4";
            checkBox4.Checked = false;

            checkBox5.Text = "Checkbox 5";
            checkBox5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 abs=new Form1();
            abs.Show();
            this.Close();

        }
    }
}

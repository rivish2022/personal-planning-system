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

namespace personal_planning_system
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-RRVCRRH\\SQLEXPRESS;Initial Catalog = Planit; Integrated Security = True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 abs = new Form3();
            abs.Show();
            this.Hide();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 abs = new Form1();
            abs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "INSERT INTO ViewBudget (Name, Cost, Date) VALUES (@Name,@Cost,@Date)";
                SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Cost", textcost.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
            //how to store a date

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            textcost.Clear();
            textname.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();   
        }
    }
}

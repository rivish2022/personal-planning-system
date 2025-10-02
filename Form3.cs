using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_planning_system
{
    public partial class Form3 : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        private string connectionString = "Data Source=DESKTOP-RRVCRRH\\SQLEXPRESS;Initial Catalog = Planit; Integrated Security = True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter("SELECT * FROM ViewBudget", connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataGridView1.AllowUserToDeleteRows = true;
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dataTable);
                MessageBox.Show("Changes saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 abs = new Form1();
            abs.Show();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace personal_planning_system
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=DESKTOP-RRVCRRH\\SQLEXPRESS;Initial Catalog = Planit; Integrated Security = True;";
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//make variables to save whatever in the text boxes
            string enteredUsername = txtUsername.Text.Trim();// delete white spaces before or after 
            string enteredPassword = txtPassword.Text;

            //username , password can not be empty
            if (enteredUsername == "" || enteredPassword == "")
            {
                MessageBox.Show("Please enter both username and password.");
                txtPassword.Clear();
                txtUsername.Clear();
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //check for matching row count
                string sql = "SELECT COUNT(*) FROM Login WHERE username = @username AND password = @password";
                //@username:A named placeholder for a safe parameter
                SqlCommand cmd = new SqlCommand(sql, conn);


                //get whetever in the textboxes to variables
                cmd.Parameters.AddWithValue("@username", enteredUsername);
                cmd.Parameters.AddWithValue("@password", enteredPassword);
                //addWithVlue: Passes the actual value to SQL securely


                try
                {
                    conn.Open();
                    int userCount = (int)cmd.ExecuteScalar();//How many users have this exact username and password?
                    //This tells SQL Server: “Count how many rows match.” and returns that number
                    //

                    if (userCount == 1)
                    {
                        //Did we find one and only one matching user? If yes, let them in
                        this.Hide(); // hides the login form
                        Form1 abs = new Form1();
                        abs.Show();


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login error: " + ex.Message);
                }
                finally
                {
                    conn.Close(); //Always closes the connection, even after error
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Shows the text (no masking)
            }
            else
            {
                txtPassword.PasswordChar = '•'; // Hides the text (mask with asterisk)
            }
        }
    }
}
    

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

namespace Nova
{
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = username.Text.Trim();
            string enteredPassword = password.Text.Trim();

            string role = GetUserDetailsAndSetSession(enteredUsername, enteredPassword);  

            if (role == "student")
            {
                student mainform = new student();
                this.Hide();
                mainform.ShowDialog();
              
            }
            else if (role == "teacher")
            {
                teacher mainform = new teacher();
                this.Hide();
                mainform.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
        private string GetUserDetailsAndSetSession(string username, string password)
        {
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT role, photoparth FROM [user] WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        string photoPath = reader["photoparth"].ToString();

                        Session.SetLoggedInUser(username, password, photoPath); 
                        return role;
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return null;
                }
            }
        }
        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
        
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }

}




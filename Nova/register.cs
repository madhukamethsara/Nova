using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System .Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova
{
    public partial class register : Form
    {
        private string savedImagePath = "";
        string connectionString = Environment.GetEnvironmentVariable("CON_STRING");
        public register()
        {
            InitializeComponent();
        }

        private void student_Click(object sender, EventArgs e)
        {
            groupstudent.Visible = true;
            groupteacher.Visible = false;
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            groupstudent.Visible = false;
            groupteacher.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);

                // FIXED: Use same folder structure as registration
                string destinationFolder = Path.Combine(Application.StartupPath, "Images", "Profiles");

                // Create folder if it doesn't exist
                Directory.CreateDirectory(destinationFolder);

                // Save path for DB
                savedImagePath = Path.Combine(destinationFolder, fileName);

                try
                {
                    File.Copy(sourcePath, savedImagePath, true);
                    MessageBox.Show("Image uploaded successfully. It will be saved to DB on Submit.");

                    // Show it in PictureBox
                    teacherpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    teacherpicbox.Image = Image.FromFile(savedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath); // unique name
                string destinationFolder = Path.Combine(Application.StartupPath, "UploadedPhotos");

                // Create folder if it doesn't exist
                Directory.CreateDirectory(destinationFolder);

                // Save path for DB
                savedImagePath = Path.Combine(destinationFolder, fileName);


                try
                {
                    File.Copy(sourcePath, savedImagePath, true); // overwrite if same name
                    MessageBox.Show("Image uploaded successfully. It will be saved to DB on Submit.");

                    // Optionally show it in PictureBox if you want
                    studentpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    studentpicbox.Image = Image.FromFile(savedImagePath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message);
                }
            }
        }

        private void studentreg_Click(object sender, EventArgs e)
        {
            //implimenting variables
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string email = emailtxt.Text;
            string age = agetxt.Text;
            string role = "student";


            // Read the selected subject from radio buttons
            string subject = "";

            if (radioButton1.Checked)
                subject = "al";
            if (radioButton2.Checked)
                subject = "ol";
             if (radioButton3.Checked)
                subject = "uni";

            //validating input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload a profile picture.");
                return;
            }
            if (!int.TryParse(age, out int parsedAge) || parsedAge <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            if (parsedAge < 10 || parsedAge > 100)
            {
                MessageBox.Show("Age must be between 10 and 100.");
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            string folderPath = Path.Combine(Application.StartupPath, "Images", "Profiles");
            Directory.CreateDirectory(folderPath); // Creates folder if it doesn't exist

            string imageFileName = Guid.NewGuid().ToString() + ".jpg";
            string imageFullPath = Path.Combine(folderPath, imageFileName);

            try
            {
                pictureBox1.Image.Save(imageFullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save profile image: " + ex.Message);
                return;
            }

            //connect to database 
            string query = "INSERT INTO [user] (username, password, email, age,role,subject,photoparth) VALUES (@username, @password, @email, @age,@role,@subject,@photopath)";

            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@subject", subject);
                    cmd.Parameters.AddWithValue("@photopath", imageFileName);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student registered successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string username = usernamet.Text;
            string password = passwordt.Text;
            string email = emailt.Text;
            string mobile = phonet.Text;
            string qualification = qualificationt.Text;
            string role = "teacher";
            string subject = subjectt.Text;

            // FIXED: Check if image was uploaded using button1
            if (string.IsNullOrEmpty(savedImagePath))
            {
                MessageBox.Show("Please upload a profile picture first.");
                return;
            }

            // Validating input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(mobile) ||
                string.IsNullOrWhiteSpace(qualification) || string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!Regex.IsMatch(mobile, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid mobile number (10 digits).");
                return;
            }

            if (qualification.Length < 3)
            {
                MessageBox.Show("Qualification must be at least 3 characters long.");
                return;
            }

            if (subject.Length < 3)
            {
                MessageBox.Show("Subject must be at least 3 characters long.");
                return;
            }

            // FIXED: Use the already saved image path from button1_Click
            string savePath = savedImagePath;

            string query = "INSERT INTO [user] (username, password, email, mobile, qualification, subject, role, photoparth) " +
                           "VALUES (@username, @password, @email, @mobile, @qualification, @subject, @role, @photopath)";

            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@qualification", qualification);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@subject", subject);
                    cmd.Parameters.AddWithValue("@photopath", savePath);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher registered successfully.");
                            // Clear the saved path after successful registration
                            savedImagePath = "";
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current Register form
            login loginForm = new login(); // Create a new instance of Login
            loginForm.Show(); // Show the login form
        }
    }
}
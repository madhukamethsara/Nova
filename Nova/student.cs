using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nova
{
    public partial class student: Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private bool isFullScreen = true;


        public student()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelmenu.Controls.Add(leftBorderBtn);

        }
        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 0, 0);
            public static Color color2 = Color.FromArgb(0, 188, 212);
            public static Color color3 = Color.FromArgb(128, 0, 0);
            public static Color color4 = Color.FromArgb(156, 39, 176);
            public static Color color5 = Color.FromArgb(233, 30, 99);
           
        }

        //methods 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeactivateButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(46, 139, 87);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DeactivateButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(46, 139, 87);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void resetui()
        {
            flowLayoutPanel2.Hide(); // Hide enrolled gigs panel
            flowLayoutPanel1.Hide();
            requestbox.Hide();
            profile.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // Show panels in specific order
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Visible = false; // initially hidden
            this.Controls.Add(flowLayoutPanel1); // or panelMain.Controls.Add(...)
            resetui();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
            LoadGigsToDashboard(); // Load gigs when the button is clicked
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            resetui();
            LoadStudentRequests();
            requestbox.Show();
            profile.Show(); 
            comboBoxTeachers.Items.Clear(); 
            comboBoxTeachers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTeachers.AutoCompleteSource = AutoCompleteSource.ListItems;

            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT username FROM [user] WHERE role = 'teacher'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxTeachers.Items.Add(reader["username"].ToString());
                }
            }
        }
       
        private void btnrequest_Click(object sender, EventArgs e)
        {

            if (comboBoxTeachers.SelectedItem == null || string.IsNullOrWhiteSpace(message.Text))
            {
                MessageBox.Show("Please select a teacher and enter a message.");
                return;
            }
            string student = Session.GetLoggedInUsername();
            string teacher = comboBoxTeachers.SelectedItem.ToString();
            string message1 = message.Text;
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO [request] (teachername, message,studentname) VALUES (@teacher, @message1,@student)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teacher", teacher);
                cmd.Parameters.AddWithValue("@message1", message1);
                cmd.Parameters.AddWithValue("@student", student);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Request sent successfully!");

        }

        private void enroll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Visible = false; 
            this.Controls.Add(flowLayoutPanel2);
            resetui();
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.Show();
            flowLayoutPanel2.BringToFront();
            LoadEnrolledGigs(); 
        }

        private void classvod_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            resetui();
            profile.Show();
            studentProfile();              
        }
        private void logout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DeactivateButton();
            leftBorderBtn.Visible = false;
        }

        private void student_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized; // Makes the form full screen
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
           
        }
        private void studentProfile()
        {
            try
            {
                string username = Session.GetLoggedInUsername();
                string password = Session.GetLoggedInPassword();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Session data is missing. Please log in again.");
                    return;
                }

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nova\Nova\Nova\Database1.mdf;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT username, email, mobile, subject, age FROM [user] WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        name2.Text = reader["username"]?.ToString() ?? "N/A";
                        email2.Text = reader["email"]?.ToString() ?? "N/A";
                        mobile2.Text = reader["mobile"]?.ToString() ?? "N/A";
                        sub2.Text = reader["subject"]?.ToString() ?? "N/A";
                        age2.Text = reader["age"]?.ToString() ?? "N/A";
                    }
                    else
                    {
                        MessageBox.Show("Student profile not found in the database.");
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}");
            }
        }
        private void LoadStudentRequests()
        {
            flowStudentRequests.Controls.Clear();

            string studentUsername = Session.GetLoggedInUsername();
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT message, reply, status FROM [request] WHERE studentname = @student AND status = 'Done'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student", studentUsername);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string message = reader.GetString(0);
                    string reply = reader.GetString(1);
                    string status = reader.GetString(2);

                    
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Size = new Size(500, 100);
                    Label lblMsg = new Label();
                    lblMsg.Text = "Your Message: " + message;
                    lblMsg.Location = new Point(10, 10);
                    lblMsg.AutoSize = false;
                    lblMsg.Size= new Size(380, 20); 

                    
                    Label lblReply = new Label();
                    lblReply.Text = "Teacher Reply: " + reply;
                    lblReply.Location = new Point(10, 35);
                    lblReply.AutoSize = true;

                    // Label for the status
                    Label lblStatus = new Label();
                    lblStatus.Text = "Status: " + status;
                    lblStatus.Location = new Point(10, 80);
                    lblStatus.AutoSize = true;

                    // Add labels to panel
                    panel.Controls.Add(lblMsg);
                    panel.Controls.Add(lblReply);
                    panel.Controls.Add(lblStatus);

                    // Add panel to flow layout
                    flowStudentRequests.Controls.Add(panel);
                }
            }
        }

        private void LoadGigsToDashboard()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * FROM upload";

            using (SqlConnection con = new SqlConnection(Environment.GetEnvironmentVariable("CON_STRING")))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tname = reader["tname"].ToString();
                    string title = reader["title"].ToString();
                    string discription = reader["description"].ToString();
                    string subject = reader["subject1"].ToString();
                    string grade = reader["grade"].ToString();
                    string date = reader["date"].ToString();
                    string pdfPath = reader["pdf"].ToString();
                    string photoPath = reader["photo"].ToString();

                    Panel card = new Panel
                    {
                        Width = 350,
                        Height = 420,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(15),
                        BackColor = Color.SeaGreen
                    };

                    Label lblTitle = new Label
                    {
                        Text = title,
                        Location = new Point(10, 10),
                        Width = 330,
                        Height = 30,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.DarkSlateBlue,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoEllipsis = true
                    };

                    PictureBox pic = new PictureBox
                    {
                        Size = new Size(200, 200),
                        Location = new Point((card.Width - 200) / 2, 50),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White
                    };

                    // Load the image from photoPath
                    try
                    {
                        if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                        {
                            // Load image from file path
                            pic.Image = Image.FromFile(photoPath);
                        }
                        else
                        {
                            // Set a default image or placeholder
                            pic.BackColor = Color.LightGray;
                            // Optionally add text to indicate no image
                            Label noImageLabel = new Label
                            {
                                Text = "No Image",
                                TextAlign = ContentAlignment.MiddleCenter,
                                Dock = DockStyle.Fill,
                                Font = new Font("Segoe UI", 10),
                                ForeColor = Color.Gray
                            };
                            pic.Controls.Add(noImageLabel);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle image loading errors
                        pic.BackColor = Color.LightGray;
                        Label errorLabel = new Label
                        {
                            Text = "Image Error",
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill,
                            Font = new Font("Segoe UI", 9),
                            ForeColor = Color.Red
                        };
                        pic.Controls.Add(errorLabel);

                        // Optional: Log the error for debugging
                        Console.WriteLine($"Error loading image: {ex.Message}");
                    }

                    int infoStartY = pic.Location.Y + pic.Height + 10;

                    Label lblTname = new Label
                    {
                        Text = $"👨‍🏫 {tname}",
                        Location = new Point(10, infoStartY),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic)
                    };

                    Label lblSubject = new Label
                    {
                        Text = $"📘 Subject: {subject}",
                        Location = new Point(10, infoStartY + 25),
                        AutoSize = true
                    };

                    Label lblGrade = new Label
                    {
                        Text = $"🎓 Grade: {grade}",
                        Location = new Point(10, infoStartY + 50),
                        AutoSize = true
                    };

                    Label lblDate = new Label
                    {
                        Text = $"🗓️ Date: {date}",
                        Location = new Point(10, infoStartY + 75),
                        AutoSize = true
                    };

                    Button btnPdf = new Button
                    {
                        Text = "View PDF",
                        Location = new Point(30, infoStartY + 110),
                        Width = 120,
                        Height = 40,
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    btnPdf.FlatAppearance.BorderSize = 0;
                    btnPdf.Click += (s, e2) =>
                    {
                        try { System.Diagnostics.Process.Start(pdfPath); }
                        catch { MessageBox.Show("PDF cannot be opened."); }
                    };

                    Button btnEnroll = new Button
                    {
                        Text = "Enroll",
                        Location = new Point(180, infoStartY + 110),
                        Width = 120,
                        Height = 40,
                        BackColor = Color.MediumSeaGreen,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    btnEnroll.FlatAppearance.BorderSize = 0;
                    btnEnroll.Click += (s, e2) =>
                    {
                        try
                        {
                            string loggedstudent = Session.GetLoggedInUsername(); 

                            using (SqlConnection con2 = new SqlConnection(Environment.GetEnvironmentVariable("CON_STRING")))
                            {
                                con2.Open();
                                string insertQuery = "INSERT INTO enrolled (name, tname, title, subject, grade, date, pdf, photo,description) " +
                                                     "VALUES (@name, @tname, @title, @subject, @grade, @date, @pdf, @photo,@description)";

                                SqlCommand insertCmd = new SqlCommand(insertQuery, con2);
                                insertCmd.Parameters.AddWithValue("@name", loggedstudent);
                                insertCmd.Parameters.AddWithValue("@tname", tname);
                                insertCmd.Parameters.AddWithValue("@title", title);
                                insertCmd.Parameters.AddWithValue("@subject", subject);
                                insertCmd.Parameters.AddWithValue("@grade", grade);
                                insertCmd.Parameters.AddWithValue("@date", date);
                                insertCmd.Parameters.AddWithValue("@pdf", pdfPath);
                                insertCmd.Parameters.AddWithValue("@photo", photoPath);
                                insertCmd.Parameters.AddWithValue("@description", discription); // Add description parameter

                                int rowsAffected = insertCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Successfully enrolled in: {title}");
                                }
                                else
                                {
                                    MessageBox.Show("Enrollment failed.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error during enrollment: " + ex.Message);
                        }
                    };

                    card.Controls.Add(lblTitle);
                    card.Controls.Add(pic);
                    card.Controls.Add(lblTname);
                    card.Controls.Add(lblSubject);
                    card.Controls.Add(lblGrade);
                    card.Controls.Add(lblDate);
                    card.Controls.Add(btnPdf);
                    card.Controls.Add(btnEnroll);

                    flowLayoutPanel1.Controls.Add(card);
                }
                reader.Close();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {     
           this.WindowState = FormWindowState.Minimized;   
        }

        private void size_Click(object sender, EventArgs e)
        {
            {
                if (isFullScreen)
                {
                    // Switch to windowed mode
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(1280, 720);
                    this.StartPosition = FormStartPosition.CenterScreen;
                    isFullScreen = false;
                }
                else
                {
                    // Switch back to full screen
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    this.Bounds = Screen.PrimaryScreen.Bounds;
                    isFullScreen = true;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the application
            new login().Show(); // Show the login form
        }

        private void LoadEnrolledGigs()
        {
            flowLayoutPanel2.Controls.Clear(); // Clear old cards if any

            string studentName = Session.GetLoggedInUsername();

            string query = "SELECT * FROM enrolled WHERE name = @studentName";

            using (SqlConnection con = new SqlConnection(Environment.GetEnvironmentVariable("CON_STRING")))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentName", studentName);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tname = reader["tname"].ToString();
                    string title = reader["title"].ToString();
                    string subject = reader["subject"].ToString();
                    string grade = reader["grade"].ToString();
                    string date = reader["date"].ToString();
                    string pdfPath = reader["pdf"].ToString();
                    string photoPath = reader["photo"].ToString();
                    string description = reader["description"].ToString();

                    // Parse description into list of video (title, url)
                    List<(string title, string url)> videoLinks = new List<(string, string)>();

                    if (!string.IsNullOrEmpty(description))
                    {
                        // Split entries by comma
                        var entries = description.Split(',');

                        foreach (var entry in entries)
                        {
                            string vidTitle = "No Title";
                            string vidUrl = "";

                            // Split by dash '-'
                            var parts = entry.Split('-');

                            if (parts.Length >= 2)
                            {
                                vidTitle = parts[0].Trim();
                                vidUrl = parts[1].Trim();
                            }
                            else
                            {
                                vidTitle = entry.Trim();
                                vidUrl = "";
                            }

                            videoLinks.Add((vidTitle, vidUrl));

                            if (videoLinks.Count >= 5) break; // Limit to 5 links max
                        }
                    }
                    else
                    {
                        videoLinks.Add(("No Video", ""));
                    }

                    // Create bigger card panel
                    Panel card = new Panel
                    {
                        Width = 700,
                        Height = 350,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(15),
                        BackColor = Color.SeaGreen,
                    };

                    // Teacher Image
                    PictureBox pic = new PictureBox
                    {
                        Size = new Size(200, 200),
                        Location = new Point(20, 20),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                    {
                        pic.Image = Image.FromFile(photoPath);
                    }
                    else
                    {
                        pic.BackColor = Color.LightGray;
                    }

                    // Title Label
                    Label lblTitle = new Label
                    {
                        Text = title,
                        Location = new Point(240, 20),
                        Font = new Font("Segoe UI", 16, FontStyle.Bold),
                        Width = 400,
                        AutoEllipsis = true,
                        AutoSize = true  // Add this
                    };

                    // Subject Label
                    Label lblSubject = new Label
                    {
                        Text = $"📘 Subject: {subject}",
                        Location = new Point(240, 60),
                        Width = 400
                    };

                    // Grade Label
                    Label lblGrade = new Label
                    {
                        Text = $"🎓 Grade: {grade}",
                        Location = new Point(240, 90),
                        Width = 400
                    };

                    // Date Label
                    Label lblDate = new Label
                    {
                        Text = $"🗓️ Date: {date}",
                        Location = new Point(240, 120),
                        Width = 400
                    };

                    // Teacher Name Label
                    Label lblTname = new Label
                    {
                        Text = $"👨‍🏫 Teacher: {tname}",
                        Location = new Point(240, 150),
                        Width = 400
                    };

                    // Panel for video links
                    Panel videoLinksPanel = new Panel
                    {
                        Location = new Point(240, 190),
                        Size = new Size(400, 140),
                        AutoScroll = true,
                        BackColor = Color.Transparent
                    };

                    int linkLabelTop = 0;
                    foreach (var (vidTitle, vidUrl) in videoLinks)
                    {
                        LinkLabel linkLabel = new LinkLabel
                        {
                            Text = $"▶️ {vidTitle}",
                            Tag = vidUrl,
                            Location = new Point(0, linkLabelTop),
                            Width = 380,
                            AutoEllipsis = true,
                            LinkColor = Color.DarkSlateBlue,
                            Font = new Font("Segoe UI", 10, FontStyle.Regular)
                        };

                        linkLabel.Click += (s, e2) =>
                        {
                            var lbl = s as LinkLabel;
                            string linkUrl = lbl?.Tag as string;
                            if (!string.IsNullOrEmpty(linkUrl))
                            {
                                try
                                {
                                    System.Diagnostics.Process.Start(linkUrl);
                                }
                                catch
                                {
                                    MessageBox.Show("Video link is invalid.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No video link available.");
                            }
                        };

                        videoLinksPanel.Controls.Add(linkLabel);
                        linkLabelTop += 25;
                    }

                    // View PDF Button
                    Button btnPdf = new Button
                    {
                        Text = "View PDF",
                        Location = new Point(240, 340 - 60),
                        Width = 120,
                        Height = 40,
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    btnPdf.FlatAppearance.BorderSize = 0;
                    btnPdf.Click += (s, e2) =>
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(pdfPath);
                        }
                        catch
                        {
                            MessageBox.Show("PDF cannot be opened.");
                        }
                    };

                    // Add controls to card
                    card.Controls.Add(pic);
                    card.Controls.Add(lblTitle);
                    card.Controls.Add(lblSubject);
                    card.Controls.Add(lblGrade);
                    card.Controls.Add(lblDate);
                    card.Controls.Add(lblTname);
                    card.Controls.Add(videoLinksPanel);
                    card.Controls.Add(btnPdf);

                    // Add card to flowLayoutPanel
                    flowLayoutPanel2.Controls.Add(card);
                }

                reader.Close();
            }
        }
    }

}

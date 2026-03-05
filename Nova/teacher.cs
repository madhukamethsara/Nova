using FontAwesome.Sharp;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static Nova.login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace Nova
{
    public partial class teacher : Form
    {

        string connectionstring = Environment.GetEnvironmentVariable("CON_STRING");
        private string savedPdfPath = "";
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private bool isFullScreen = true; // Track full screen state


        public teacher()
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
            flowLayoutPanel2.Hide();  // Hide dashboard
            groupBox1.Hide();         // Hide upload panel
            request.Hide();           // Hide request panel
            profile.Hide();           // Hide profile panel
        }

        private void Dashboardt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            // Show panels in specific order
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Visible = false; // initially hidden
            this.Controls.Add(flowLayoutPanel2); // or panelMain.Controls.Add(...)
            resetui();
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.Show();
            flowLayoutPanel2.BringToFront();
            LoadDashboardContent();
        }

        private void LoadDashboardContent()
        {
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.Controls.Clear();

            try
            {
                LoadGigsToDashboard();
            }
            finally
            {
                flowLayoutPanel2.ResumeLayout(true);
                flowLayoutPanel2.Refresh();
            }
        }

        private void Requestt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            resetui();
            request.Show();
            LoadRequests(); 
            profile.Show();

        }

        private void gigst_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            teacherProfile();
            resetui();
            profile.Show();
        }

        private void uploadt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            resetui();
            groupBox1.Show();
        }

        private void logoutt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);


        }
        private void Teacher_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized; // Makes the form full screen
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void upload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void uploadpdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourcePath);
                string destinationFolder = Path.Combine(Application.StartupPath, "UploadedPDFs");

                if (!Directory.Exists(destinationFolder))
                    Directory.CreateDirectory(destinationFolder);

                savedPdfPath = Path.Combine(destinationFolder, fileName);
                File.Copy(sourcePath, savedPdfPath, true); // copy file

                MessageBox.Show("PDF uploaded successfully. It will be saved to DB on Submit.");
            }
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            // Get values from form inputs
            string Tname = name.Text;
            string gig = gigtitle.Text;
            string description1 = description.Text;
            string subject = subject1.Text;
            string grade1 = grade.Text;
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string photo1 = Session.GetLoggedInPhotoPath(); // Get photo path from session

            if (string.IsNullOrEmpty(savedPdfPath))
            {
                MessageBox.Show("Please upload a PDF file before submitting.");
                return;
            }

            string[] ytvideos = await SearchYTVideos(description1);

            if (ytvideos.Length == 0)
            {
                MessageBox.Show("No YouTube videos found for the given description.");
                return;
            }

            string vod = string.Join(",", ytvideos);

            // Define connection string and query
            string connectionstring = Environment.GetEnvironmentVariable("CON_STRING");
            string query = "INSERT INTO [dbo].[upload] (tname, title, description, subject1, grade,date,pdf,photo) VALUES (@Tname, @gigtitle, @description1, @subject, @grade1,@selectedDate,@pdf_path,@photo1)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Fix parameter names to match the SQL query
                    command.Parameters.AddWithValue("@Tname", Tname);
                    command.Parameters.AddWithValue("@gigtitle", gig);
                    command.Parameters.AddWithValue("@description1", vod);
                    command.Parameters.AddWithValue("@subject", subject);
                    command.Parameters.AddWithValue("@grade1", grade1);
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);
                    command.Parameters.AddWithValue("@pdf_path", savedPdfPath); // Use the saved path
                    command.Parameters.AddWithValue("@photo1", photo1); // Use the photo path from session

                    // Open the connection and execute the query
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Optional: Check if the insert was successful
                    if (result > 0)
                    {
                        MessageBox.Show("Gig uploaded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Upload failed.");
                    }
                }
            }
        }

        private async Task<string[]> SearchYTVideos(string query)
        {
            string apikey = Environment.GetEnvironmentVariable("YOUTUBE_API_KEY");
            
            if (string.IsNullOrEmpty(apikey))
            {
                MessageBox.Show("YouTube API key is not set. Please set the YOUTUBE_API_KEY environment variable.");
                MessageBox.Show("check.env for an api key");
                return new string[0]; 
            }

            var youtubeservice = new YouTubeService(new BaseClientService.Initializer
            {
                ApiKey = apikey,
                
                ApplicationName = "YTSearchApplication"
            });

            var searchRequest = youtubeservice.Search.List("snippet");
            searchRequest.Q = $"{query} tutorials";
            searchRequest.Type = "video";
            searchRequest.MaxResults = 5;
            searchRequest.Fields = "items(id/videoId,snippet/title)";


            var searchResponse = await searchRequest.ExecuteAsync();
           /* if (searchResponse != null)
            {
                MessageBox.Show("Failed to reach youtube");
            }*/

            string[] results = new string[searchResponse.Items.Count];

            for (int i = 0; i < searchResponse.Items.Count; i++)
            {
                var item = searchResponse.Items[i];
                string videoId = item.Id.VideoId;
                if (String.IsNullOrEmpty(videoId))
                {
                    continue;
                }
                string title = item.Snippet.Title;
                string url = $"https://www.youtube.com/watch?v={videoId}";
                results[i] = $"{title}-{url}";
            }

            return results;
        }

        private void teacherProfile()
        {
            string username = Session.GetLoggedInUsername();
            string password = Session.GetLoggedInPassword();
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [user] WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userName = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string mobile = reader["mobile"].ToString();
                    string subject = reader["subject"].ToString();
                    string qualification = reader["qualification"].ToString();

                    // Set values to labels in groupBox2
                    name1.Text = userName;
                    email1.Text = email;
                    mobile1.Text = mobile;
                    sub1.Text = subject;
                    qualification1.Text = qualification;
                }
                else
                {
                    MessageBox.Show("Teacher profile not found.");
                }
            }
        }

        private void profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadRequests()
        {
            request.Controls.Clear(); // Clear previous cards
            string teacher = Session.GetLoggedInUsername(); // Logged-in teacher username
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, message, status FROM [request] WHERE teachername = @teacher AND status = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teacher", teacher);

                SqlDataReader reader = cmd.ExecuteReader();
                int yPosition = 10; // vertical position to place each card

                while (reader.Read())
                {
                    int requestId = reader.GetInt32(0);
                    string message = reader.GetString(1);

                    // Create card panel
                    Panel card = new Panel
                    {
                        Width = request.Width - 25, // adjust width to fit inside panel
                        Height = 160,
                        Location = new Point(10, yPosition),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.SeaGreen
                    };

                    // Message label
                    Label lblMessage = new Label
                    {
                        Text = "Message: " + message,
                        Location = new Point(10, 10),
                        Width = card.Width - 20,
                        Height = 40,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };

                    // Reply textbox
                    TextBox txtReply = new TextBox
                    {
                        Location = new Point(10, 60),
                        Width = card.Width - 20,
                        Height = 40,
                        Multiline = true
                    };

                    // Send reply button
                    Button btnSendReply = new Button
                    {
                        Text = "Send Reply",
                        Location = new Point(10, 110),
                        Width = 100,
                        Height = 50,
                    };

                    btnSendReply.Click += (s, e) =>
                    {
                        string reply = txtReply.Text.Trim();
                        if (string.IsNullOrEmpty(reply))
                        {
                            MessageBox.Show("Reply cannot be empty.");
                            return;
                        }

                        SendReply(requestId, reply);
                    };

                    // Add controls to card
                    card.Controls.Add(lblMessage);
                    card.Controls.Add(txtReply);
                    card.Controls.Add(btnSendReply);

                    // Add card to panel
                    request.Controls.Add(card);

                    yPosition += card.Height + 10; // increment Y position for next card
                }
            }
        }
        private void SendReply(int requestId, string replyText)
        {
            string connectionString = Environment.GetEnvironmentVariable("CON_STRING");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE [request] SET reply = @reply, status = 'Done' WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reply", replyText);
                cmd.Parameters.AddWithValue("@id", requestId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Reply sent and request marked as done.");
            LoadRequests(); // Refresh the cards
        }



        private void LoadGigsToDashboard()
        {
            flowLayoutPanel2.Controls.Clear();
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
                        Location = new Point(100, infoStartY + 110),
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

                    card.Controls.Add(lblTitle);
                    card.Controls.Add(pic);
                    card.Controls.Add(lblTname);
                    card.Controls.Add(lblSubject);
                    card.Controls.Add(lblGrade);
                    card.Controls.Add(lblDate);
                    card.Controls.Add(btnPdf);
                    //card.Controls.Add(btnEnroll);

                    flowLayoutPanel2.Controls.Add(card);
                }
                reader.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the form
            new login().ShowDialog(); // Show the login form
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimize the form
        }

        private void size_Click(object sender, EventArgs e)
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
}


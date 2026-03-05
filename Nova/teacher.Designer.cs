namespace Nova
{
    partial class teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button close;
            this.panelmenu = new System.Windows.Forms.Panel();
            this.uploadt = new FontAwesome.Sharp.IconButton();
            this.logoutt = new FontAwesome.Sharp.IconButton();
            this.gigst = new FontAwesome.Sharp.IconButton();
            this.Requestt = new FontAwesome.Sharp.IconButton();
            this.Dashboardt = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.btnhomet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            this.uploadpdf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grade = new System.Windows.Forms.TextBox();
            this.subject1 = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.gigtitle = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Panel();
            this.request = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sub1 = new System.Windows.Forms.Label();
            this.qualification1 = new System.Windows.Forms.Label();
            this.mobile1 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            close = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profile.SuspendLayout();
            this.request.SuspendLayout();
            this.flowLayoutPanelRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            close.BackColor = System.Drawing.Color.SeaGreen;
            close.BackgroundImage = global::Nova.Properties.Resources.Close3;
            close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            close.Dock = System.Windows.Forms.DockStyle.Right;
            close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            close.Location = new System.Drawing.Point(824, 0);
            close.Name = "close";
            close.Size = new System.Drawing.Size(36, 39);
            close.TabIndex = 0;
            close.UseMnemonic = false;
            close.UseVisualStyleBackColor = false;
            close.Click += new System.EventHandler(this.close_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelmenu.Controls.Add(this.uploadt);
            this.panelmenu.Controls.Add(this.logoutt);
            this.panelmenu.Controls.Add(this.gigst);
            this.panelmenu.Controls.Add(this.Requestt);
            this.panelmenu.Controls.Add(this.Dashboardt);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(288, 600);
            this.panelmenu.TabIndex = 1;
            // 
            // uploadt
            // 
            this.uploadt.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadt.FlatAppearance.BorderSize = 0;
            this.uploadt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadt.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.uploadt.IconColor = System.Drawing.Color.White;
            this.uploadt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.uploadt.IconSize = 32;
            this.uploadt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadt.Location = new System.Drawing.Point(0, 368);
            this.uploadt.Name = "uploadt";
            this.uploadt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.uploadt.Size = new System.Drawing.Size(288, 62);
            this.uploadt.TabIndex = 5;
            this.uploadt.Text = "Upload Gigs";
            this.uploadt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadt.UseVisualStyleBackColor = true;
            this.uploadt.Click += new System.EventHandler(this.uploadt_Click);
            // 
            // logoutt
            // 
            this.logoutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutt.FlatAppearance.BorderSize = 0;
            this.logoutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutt.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.logoutt.IconColor = System.Drawing.Color.White;
            this.logoutt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutt.IconSize = 32;
            this.logoutt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutt.Location = new System.Drawing.Point(0, 538);
            this.logoutt.Name = "logoutt";
            this.logoutt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutt.Size = new System.Drawing.Size(288, 62);
            this.logoutt.TabIndex = 4;
            this.logoutt.Text = "Log Out";
            this.logoutt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutt.UseVisualStyleBackColor = true;
            this.logoutt.Click += new System.EventHandler(this.logoutt_Click);
            // 
            // gigst
            // 
            this.gigst.Dock = System.Windows.Forms.DockStyle.Top;
            this.gigst.FlatAppearance.BorderSize = 0;
            this.gigst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gigst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gigst.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.gigst.IconColor = System.Drawing.Color.White;
            this.gigst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gigst.IconSize = 32;
            this.gigst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gigst.Location = new System.Drawing.Point(0, 306);
            this.gigst.Name = "gigst";
            this.gigst.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.gigst.Size = new System.Drawing.Size(288, 62);
            this.gigst.TabIndex = 3;
            this.gigst.Text = "Profile";
            this.gigst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gigst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gigst.UseVisualStyleBackColor = true;
            this.gigst.Click += new System.EventHandler(this.gigst_Click);
            // 
            // Requestt
            // 
            this.Requestt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Requestt.FlatAppearance.BorderSize = 0;
            this.Requestt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Requestt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requestt.IconChar = FontAwesome.Sharp.IconChar.Sms;
            this.Requestt.IconColor = System.Drawing.Color.White;
            this.Requestt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Requestt.IconSize = 32;
            this.Requestt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requestt.Location = new System.Drawing.Point(0, 244);
            this.Requestt.Name = "Requestt";
            this.Requestt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Requestt.Size = new System.Drawing.Size(288, 62);
            this.Requestt.TabIndex = 2;
            this.Requestt.Text = "Request ";
            this.Requestt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requestt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Requestt.UseVisualStyleBackColor = true;
            this.Requestt.Click += new System.EventHandler(this.Requestt_Click);
            // 
            // Dashboardt
            // 
            this.Dashboardt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboardt.FlatAppearance.BorderSize = 0;
            this.Dashboardt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardt.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.Dashboardt.IconColor = System.Drawing.Color.White;
            this.Dashboardt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboardt.IconSize = 32;
            this.Dashboardt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardt.Location = new System.Drawing.Point(0, 182);
            this.Dashboardt.Name = "Dashboardt";
            this.Dashboardt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Dashboardt.Size = new System.Drawing.Size(288, 62);
            this.Dashboardt.TabIndex = 1;
            this.Dashboardt.Text = "Dashboard";
            this.Dashboardt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboardt.UseVisualStyleBackColor = true;
            this.Dashboardt.Click += new System.EventHandler(this.Dashboardt_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.btnhomet);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(288, 182);
            this.panellogo.TabIndex = 0;
            // 
            // btnhomet
            // 
            this.btnhomet.BackgroundImage = global::Nova.Properties.Resources.Leonardo_Lightning_XL_Design_a_modern_and_minimalistic_logo_fo_1;
            this.btnhomet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhomet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhomet.Location = new System.Drawing.Point(0, 0);
            this.btnhomet.Name = "btnhomet";
            this.btnhomet.Size = new System.Drawing.Size(288, 182);
            this.btnhomet.TabIndex = 0;
            this.btnhomet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.uploadpdf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Controls.Add(this.subject1);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.gigtitle);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1760, 1022);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nova.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(837, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 767);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(516, 941);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(262, 45);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // uploadpdf
            // 
            this.uploadpdf.Location = new System.Drawing.Point(182, 941);
            this.uploadpdf.Name = "uploadpdf";
            this.uploadpdf.Size = new System.Drawing.Size(262, 45);
            this.uploadpdf.TabIndex = 13;
            this.uploadpdf.Text = "Upload";
            this.uploadpdf.UseVisualStyleBackColor = true;
            this.uploadpdf.Click += new System.EventHandler(this.uploadpdf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 941);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Upload PDF";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(182, 636);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(182, 558);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(640, 22);
            this.grade.TabIndex = 10;
            // 
            // subject1
            // 
            this.subject1.Location = new System.Drawing.Point(182, 490);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(640, 22);
            this.subject1.TabIndex = 9;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(182, 372);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(640, 74);
            this.description.TabIndex = 8;
            this.description.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // gigtitle
            // 
            this.gigtitle.Location = new System.Drawing.Point(182, 285);
            this.gigtitle.Name = "gigtitle";
            this.gigtitle.Size = new System.Drawing.Size(640, 22);
            this.gigtitle.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(182, 223);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(640, 22);
            this.name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade Level";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key Words";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gig Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.profile.Controls.Add(this.request);
            this.profile.Controls.Add(this.pictureBox2);
            this.profile.Controls.Add(this.sub1);
            this.profile.Controls.Add(this.qualification1);
            this.profile.Controls.Add(this.mobile1);
            this.profile.Controls.Add(this.email1);
            this.profile.Controls.Add(this.label12);
            this.profile.Controls.Add(this.label11);
            this.profile.Controls.Add(this.label10);
            this.profile.Controls.Add(this.label9);
            this.profile.Controls.Add(this.label8);
            this.profile.Controls.Add(this.name1);
            this.profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.Location = new System.Drawing.Point(0, 0);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(860, 561);
            this.profile.TabIndex = 2;
            this.profile.Paint += new System.Windows.Forms.PaintEventHandler(this.profile_Paint);
            // 
            // request
            // 
            this.request.AutoScroll = true;
            this.request.Controls.Add(this.flowLayoutPanel2);
            this.request.Controls.Add(this.flowLayoutPanelRequests);
            this.request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.request.Location = new System.Drawing.Point(0, 0);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(860, 561);
            this.request.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(860, 561);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanelRequests
            // 
            this.flowLayoutPanelRequests.AutoSize = true;
            this.flowLayoutPanelRequests.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanelRequests.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanelRequests.Name = "flowLayoutPanelRequests";
            this.flowLayoutPanelRequests.Size = new System.Drawing.Size(739, 109);
            this.flowLayoutPanelRequests.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nova.Properties.Resources._9;
            this.pictureBox2.Location = new System.Drawing.Point(786, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(836, 825);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // sub1
            // 
            this.sub1.AutoSize = true;
            this.sub1.Location = new System.Drawing.Point(331, 580);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(0, 25);
            this.sub1.TabIndex = 10;
            // 
            // qualification1
            // 
            this.qualification1.AutoSize = true;
            this.qualification1.Location = new System.Drawing.Point(331, 468);
            this.qualification1.Name = "qualification1";
            this.qualification1.Size = new System.Drawing.Size(0, 25);
            this.qualification1.TabIndex = 9;
            // 
            // mobile1
            // 
            this.mobile1.AutoSize = true;
            this.mobile1.Location = new System.Drawing.Point(331, 367);
            this.mobile1.Name = "mobile1";
            this.mobile1.Size = new System.Drawing.Size(0, 25);
            this.mobile1.TabIndex = 8;
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Location = new System.Drawing.Point(331, 263);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(0, 25);
            this.email1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Subject";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Qualification";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mobile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "E mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(331, 164);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(0, 25);
            this.name1.TabIndex = 1;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.background.Controls.Add(this.profile);
            this.background.Controls.Add(this.groupBox1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(288, 39);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(860, 561);
            this.background.TabIndex = 2;
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(288, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 39);
            this.panel1.TabIndex = 3;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.SeaGreen;
            this.minimize.BackgroundImage = global::Nova.Properties.Resources.Minus;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.Location = new System.Drawing.Point(751, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(37, 39);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.SeaGreen;
            this.size.BackgroundImage = global::Nova.Properties.Resources.Virtual_Machine;
            this.size.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size.Dock = System.Windows.Forms.DockStyle.Right;
            this.size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.size.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.size.Location = new System.Drawing.Point(788, 0);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(36, 39);
            this.size.TabIndex = 1;
            this.size.UseVisualStyleBackColor = false;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 600);
            this.Controls.Add(this.background);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            this.request.ResumeLayout(false);
            this.request.PerformLayout();
            this.flowLayoutPanelRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton uploadt;
        private FontAwesome.Sharp.IconButton logoutt;
        private FontAwesome.Sharp.IconButton gigst;
        private FontAwesome.Sharp.IconButton Requestt;
        private FontAwesome.Sharp.IconButton Dashboardt;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button btnhomet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox subject1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox gigtitle;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button uploadpdf;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label sub1;
        private System.Windows.Forms.Label qualification1;
        private System.Windows.Forms.Label mobile1;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel request;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel background;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button size;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
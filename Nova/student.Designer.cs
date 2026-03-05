namespace Nova
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.classvod = new FontAwesome.Sharp.IconButton();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.enroll = new FontAwesome.Sharp.IconButton();
            this.Request = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.requestbox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStudentRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnrequest = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.name2 = new System.Windows.Forms.Label();
            this.email2 = new System.Windows.Forms.Label();
            this.mobile2 = new System.Windows.Forms.Label();
            this.sub2 = new System.Windows.Forms.Label();
            this.age2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.requestbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelmenu.Controls.Add(this.classvod);
            this.panelmenu.Controls.Add(this.logout);
            this.panelmenu.Controls.Add(this.enroll);
            this.panelmenu.Controls.Add(this.Request);
            this.panelmenu.Controls.Add(this.Dashboard);
            this.panelmenu.Controls.Add(this.panellogo);
            resources.ApplyResources(this.panelmenu, "panelmenu");
            this.panelmenu.Name = "panelmenu";
            // 
            // classvod
            // 
            resources.ApplyResources(this.classvod, "classvod");
            this.classvod.FlatAppearance.BorderSize = 0;
            this.classvod.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.classvod.IconColor = System.Drawing.Color.White;
            this.classvod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.classvod.IconSize = 32;
            this.classvod.Name = "classvod";
            this.classvod.UseVisualStyleBackColor = true;
            this.classvod.Click += new System.EventHandler(this.classvod_Click);
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.logout.IconColor = System.Drawing.Color.White;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 32;
            this.logout.Name = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // enroll
            // 
            resources.ApplyResources(this.enroll, "enroll");
            this.enroll.FlatAppearance.BorderSize = 0;
            this.enroll.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.enroll.IconColor = System.Drawing.Color.White;
            this.enroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.enroll.IconSize = 32;
            this.enroll.Name = "enroll";
            this.enroll.UseVisualStyleBackColor = true;
            this.enroll.Click += new System.EventHandler(this.enroll_Click);
            // 
            // Request
            // 
            resources.ApplyResources(this.Request, "Request");
            this.Request.FlatAppearance.BorderSize = 0;
            this.Request.IconChar = FontAwesome.Sharp.IconChar.Sms;
            this.Request.IconColor = System.Drawing.Color.White;
            this.Request.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Request.IconSize = 32;
            this.Request.Name = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this.Dashboard, "Dashboard");
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.Dashboard.IconColor = System.Drawing.Color.White;
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 32;
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.btnhome);
            resources.ApplyResources(this.panellogo, "panellogo");
            this.panellogo.Name = "panellogo";
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImage = global::Nova.Properties.Resources.Leonardo_Lightning_XL_Design_a_modern_and_minimalistic_logo_fo_1;
            resources.ApplyResources(this.btnhome, "btnhome");
            this.btnhome.Name = "btnhome";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // requestbox
            // 
            this.requestbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.requestbox.Controls.Add(this.flowLayoutPanel2);
            this.requestbox.Controls.Add(this.flowLayoutPanel1);
            this.requestbox.Controls.Add(this.flowStudentRequests);
            this.requestbox.Controls.Add(this.pictureBox2);
            this.requestbox.Controls.Add(this.btnrequest);
            this.requestbox.Controls.Add(this.message);
            this.requestbox.Controls.Add(this.label7);
            this.requestbox.Controls.Add(this.label6);
            this.requestbox.Controls.Add(this.comboBoxTeachers);
            resources.ApplyResources(this.requestbox, "requestbox");
            this.requestbox.Name = "requestbox";
            this.requestbox.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowStudentRequests
            // 
            resources.ApplyResources(this.flowStudentRequests, "flowStudentRequests");
            this.flowStudentRequests.Name = "flowStudentRequests";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nova.Properties.Resources.Green_Screen_3D_Character_Man1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnrequest
            // 
            this.btnrequest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnrequest.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnrequest.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnrequest, "btnrequest");
            this.btnrequest.Name = "btnrequest";
            this.btnrequest.UseVisualStyleBackColor = false;
            this.btnrequest.Click += new System.EventHandler(this.btnrequest_Click);
            // 
            // message
            // 
            resources.ApplyResources(this.message, "message");
            this.message.Name = "message";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DropDownHeight = 200;
            resources.ApplyResources(this.comboBoxTeachers, "comboBoxTeachers");
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(this.close);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.TabStop = true;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.SeaGreen;
            this.minimize.BackgroundImage = global::Nova.Properties.Resources.Minus;
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.Name = "minimize";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.SeaGreen;
            this.size.BackgroundImage = global::Nova.Properties.Resources.Virtual_Machine;
            resources.ApplyResources(this.size, "size");
            this.size.FlatAppearance.BorderSize = 0;
            this.size.ForeColor = System.Drawing.Color.Black;
            this.size.Name = "size";
            this.size.UseVisualStyleBackColor = false;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.SeaGreen;
            this.close.BackgroundImage = global::Nova.Properties.Resources.Close3;
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // name2
            // 
            resources.ApplyResources(this.name2, "name2");
            this.name2.Name = "name2";
            // 
            // email2
            // 
            resources.ApplyResources(this.email2, "email2");
            this.email2.Name = "email2";
            // 
            // mobile2
            // 
            resources.ApplyResources(this.mobile2, "mobile2");
            this.mobile2.Name = "mobile2";
            // 
            // sub2
            // 
            resources.ApplyResources(this.sub2, "sub2");
            this.sub2.Name = "sub2";
            // 
            // age2
            // 
            resources.ApplyResources(this.age2, "age2");
            this.age2.Name = "age2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nova.Properties.Resources._9;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.profile.Controls.Add(this.requestbox);
            this.profile.Controls.Add(this.pictureBox1);
            this.profile.Controls.Add(this.age2);
            this.profile.Controls.Add(this.sub2);
            this.profile.Controls.Add(this.mobile2);
            this.profile.Controls.Add(this.email2);
            this.profile.Controls.Add(this.name2);
            this.profile.Controls.Add(this.label5);
            this.profile.Controls.Add(this.label4);
            this.profile.Controls.Add(this.label3);
            this.profile.Controls.Add(this.label2);
            this.profile.Controls.Add(this.label1);
            resources.ApplyResources(this.profile, "profile");
            this.profile.Name = "profile";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // student
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "student";
            this.Load += new System.EventHandler(this.student_Load);
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.requestbox.ResumeLayout(false);
            this.requestbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton Dashboard;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton logout;
        private FontAwesome.Sharp.IconButton enroll;
        private FontAwesome.Sharp.IconButton Request;
        private FontAwesome.Sharp.IconButton classvod;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.GroupBox requestbox;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button btnrequest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowStudentRequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button size;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label email2;
        private System.Windows.Forms.Label mobile2;
        private System.Windows.Forms.Label sub2;
        private System.Windows.Forms.Label age2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
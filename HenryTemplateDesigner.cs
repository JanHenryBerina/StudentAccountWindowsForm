namespace JanHenryBerina___WinFormsTemplate
{
    partial class frmDictStudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictStudentForm));
            this.lblGreetingsDict = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblPurpose2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbMission = new System.Windows.Forms.ListBox();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblVission = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbStudentNumber = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.lbLoginGreeting = new System.Windows.Forms.Label();
            this.lblLoginGreetins2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreetingsDict
            // 
            this.lblGreetingsDict.AutoSize = true;
            this.lblGreetingsDict.BackColor = System.Drawing.Color.Transparent;
            this.lblGreetingsDict.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreetingsDict.ForeColor = System.Drawing.Color.Gold;
            this.lblGreetingsDict.Location = new System.Drawing.Point(522, 146);
            this.lblGreetingsDict.Name = "lblGreetingsDict";
            this.lblGreetingsDict.Size = new System.Drawing.Size(450, 33);
            this.lblGreetingsDict.TabIndex = 0;
            this.lblGreetingsDict.Text = "Welcome To DICT Student Login Form";
            this.lblGreetingsDict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGreetingsDict.Click += new System.EventHandler(this.GreetingsDict_Click);
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.BackColor = System.Drawing.Color.Transparent;
            this.lblPurpose.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPurpose.ForeColor = System.Drawing.Color.Maroon;
            this.lblPurpose.Location = new System.Drawing.Point(195, 244);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(1184, 28);
            this.lblPurpose.TabIndex = 1;
            this.lblPurpose.Text = "\"The form of Dict in Polytechnic University of the Philippines strived for better" +
    " organization of data from the Students.  ";
            this.lblPurpose.Click += new System.EventHandler(this.lblPurpose_Click);
            // 
            // lblPurpose2
            // 
            this.lblPurpose2.AutoSize = true;
            this.lblPurpose2.BackColor = System.Drawing.Color.Transparent;
            this.lblPurpose2.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPurpose2.ForeColor = System.Drawing.Color.Maroon;
            this.lblPurpose2.Location = new System.Drawing.Point(355, 318);
            this.lblPurpose2.Name = "lblPurpose2";
            this.lblPurpose2.Size = new System.Drawing.Size(821, 28);
            this.lblPurpose2.TabIndex = 2;
            this.lblPurpose2.Text = " This Application will serve as a database of student status in learning educatio" +
    "n.\"";
            this.lblPurpose2.Click += new System.EventHandler(this.lblPurpose2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JanHenryBerina___WinFormsTemplate.Properties.Resources.PUPLogo;
            this.pictureBox1.Location = new System.Drawing.Point(568, 411);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1462, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 1056);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbMission
            // 
            this.lbMission.BackColor = System.Drawing.Color.Black;
            this.lbMission.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMission.ForeColor = System.Drawing.Color.White;
            this.lbMission.FormattingEnabled = true;
            this.lbMission.ItemHeight = 20;
            this.lbMission.Items.AddRange(new object[] {
            "- provide democratized access to educatiprovide democratized access to educationa" +
                "l opportunities ",
            "for the holistic development of individuals with global perspective.",
            "",
            "- offer industry-oriented curricula that produce highly-skilled professionals",
            " with managerial and technical capabilities and a strong sense of public service " +
                "for nation building.",
            "",
            "- embed a culture of research and innovation.",
            "",
            "- continuously develop faculty and employees with the highest level of ",
            "professionalism.",
            "",
            "- establish a strong presence and impact in the international academic community"});
            this.lbMission.Location = new System.Drawing.Point(12, 522);
            this.lbMission.Name = "lbMission";
            this.lbMission.Size = new System.Drawing.Size(553, 284);
            this.lbMission.TabIndex = 5;
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.BackColor = System.Drawing.Color.Transparent;
            this.lblMission.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMission.ForeColor = System.Drawing.Color.Gold;
            this.lblMission.Location = new System.Drawing.Point(178, 451);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(192, 50);
            this.lblMission.TabIndex = 6;
            this.lblMission.Text = "MISSION:";
            // 
            // lblVission
            // 
            this.lblVission.AutoSize = true;
            this.lblVission.BackColor = System.Drawing.Color.Transparent;
            this.lblVission.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVission.ForeColor = System.Drawing.Color.Gold;
            this.lblVission.Location = new System.Drawing.Point(1132, 451);
            this.lblVission.Name = "lblVission";
            this.lblVission.Size = new System.Drawing.Size(164, 50);
            this.lblVission.TabIndex = 7;
            this.lblVission.Text = "VISION:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "To develop globally competitive students who will play proactive roles ",
            "in national and international development. Quality Instruction-",
            "To providequality instruction responsive to global needs and expectations. ",
            "Wider Accessibility- To democratize access to graduate education ",
            "to all qualified Filipinos and foreigners."});
            this.listBox1.Location = new System.Drawing.Point(958, 522);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 264);
            this.listBox1.TabIndex = 8;
            // 
            // tbStudentNumber
            // 
            this.tbStudentNumber.BackColor = System.Drawing.Color.Maroon;
            this.tbStudentNumber.Location = new System.Drawing.Point(1589, 163);
            this.tbStudentNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tbStudentNumber.Name = "tbStudentNumber";
            this.tbStudentNumber.PlaceholderText = "Student Number";
            this.tbStudentNumber.Size = new System.Drawing.Size(200, 27);
            this.tbStudentNumber.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Maroon;
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(1589, 267);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(200, 27);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // cbMonths
            // 
            this.cbMonths.BackColor = System.Drawing.Color.Maroon;
            this.cbMonths.ForeColor = System.Drawing.Color.White;
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonths.Location = new System.Drawing.Point(1477, 213);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(134, 28);
            this.cbMonths.TabIndex = 11;
            this.cbMonths.Text = "Birthmonth";
            // 
            // lbLoginGreeting
            // 
            this.lbLoginGreeting.AutoSize = true;
            this.lbLoginGreeting.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLoginGreeting.ForeColor = System.Drawing.Color.Gold;
            this.lbLoginGreeting.Location = new System.Drawing.Point(1559, 9);
            this.lbLoginGreeting.Name = "lbLoginGreeting";
            this.lbLoginGreeting.Size = new System.Drawing.Size(261, 53);
            this.lbLoginGreeting.TabIndex = 12;
            this.lbLoginGreeting.Text = "WELCOME";
            // 
            // lblLoginGreetins2
            // 
            this.lblLoginGreetins2.AutoSize = true;
            this.lblLoginGreetins2.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginGreetins2.ForeColor = System.Drawing.Color.Gold;
            this.lblLoginGreetins2.Location = new System.Drawing.Point(1494, 78);
            this.lblLoginGreetins2.Name = "lblLoginGreetins2";
            this.lblLoginGreetins2.Size = new System.Drawing.Size(374, 53);
            this.lblLoginGreetins2.TabIndex = 13;
            this.lblLoginGreetins2.Text = "DICT STUDENT";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Maroon;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(1617, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Day";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1757, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Year";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnLogin.Location = new System.Drawing.Point(1617, 372);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 57);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(1628, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(111, 29);
            this.progressBar1.TabIndex = 18;
            // 
            // frmDictStudentForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLoginGreetins2);
            this.Controls.Add(this.lbLoginGreeting);
            this.Controls.Add(this.cbMonths);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbStudentNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblVission);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lbMission);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPurpose2);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblGreetingsDict);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmDictStudentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICT STUDENT FORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HenryTemplate_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetingsDict;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblPurpose2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lbMission;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblVission;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbStudentNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.Label lbLoginGreeting;
        private System.Windows.Forms.Label lblLoginGreetins2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

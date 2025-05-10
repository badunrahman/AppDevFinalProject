namespace StudentManagementSystem.Models
{
    partial class AdminDashboard
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
            this.adminPictureBox = new System.Windows.Forms.PictureBox();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studnetManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.athletesStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partTimeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullTimeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpQuickSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.coursesTextBox = new System.Windows.Forms.TextBox();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBoxt = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panelVerticalLine = new System.Windows.Forms.FlowLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpQuickSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPictureBox
            // 
            this.adminPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPictureBox.Location = new System.Drawing.Point(30, 35);
            this.adminPictureBox.Name = "adminPictureBox";
            this.adminPictureBox.Size = new System.Drawing.Size(100, 100);
            this.adminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPictureBox.TabIndex = 0;
            this.adminPictureBox.TabStop = false;
            this.adminPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.adminPictureBox_Paint);
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNameLabel.Location = new System.Drawing.Point(168, 69);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(0, 19);
            this.adminNameLabel.TabIndex = 1;
            this.adminNameLabel.Click += new System.EventHandler(this.adminNameLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studnetManagementToolStripMenuItem,
            this.teacherManagementToolStripMenuItem,
            this.academicTrackingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studnetManagementToolStripMenuItem
            // 
            this.studnetManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStudentToolStripMenuItem,
            this.manageStudentToolStripMenuItem,
            this.athletesStudentToolStripMenuItem});
            this.studnetManagementToolStripMenuItem.Name = "studnetManagementToolStripMenuItem";
            this.studnetManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studnetManagementToolStripMenuItem.Text = "Studnet Management";
            // 
            // createStudentToolStripMenuItem
            // 
            this.createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            this.createStudentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createStudentToolStripMenuItem.Text = "Create Student";
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // athletesStudentToolStripMenuItem
            // 
            this.athletesStudentToolStripMenuItem.Name = "athletesStudentToolStripMenuItem";
            this.athletesStudentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.athletesStudentToolStripMenuItem.Text = "Athletes Student";
            // 
            // teacherManagementToolStripMenuItem
            // 
            this.teacherManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTeacherToolStripMenuItem});
            this.teacherManagementToolStripMenuItem.Name = "teacherManagementToolStripMenuItem";
            this.teacherManagementToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.teacherManagementToolStripMenuItem.Text = "Teacher Management";
            // 
            // createTeacherToolStripMenuItem
            // 
            this.createTeacherToolStripMenuItem.Name = "createTeacherToolStripMenuItem";
            this.createTeacherToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createTeacherToolStripMenuItem.Text = "Create Teacher";
            // 
            // academicTrackingToolStripMenuItem
            // 
            this.academicTrackingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partTimeStudentToolStripMenuItem,
            this.fullTimeStudentToolStripMenuItem});
            this.academicTrackingToolStripMenuItem.Name = "academicTrackingToolStripMenuItem";
            this.academicTrackingToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.academicTrackingToolStripMenuItem.Text = "Academic Tracking";
            // 
            // partTimeStudentToolStripMenuItem
            // 
            this.partTimeStudentToolStripMenuItem.Name = "partTimeStudentToolStripMenuItem";
            this.partTimeStudentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.partTimeStudentToolStripMenuItem.Text = "PartTime Student";
            // 
            // fullTimeStudentToolStripMenuItem
            // 
            this.fullTimeStudentToolStripMenuItem.Name = "fullTimeStudentToolStripMenuItem";
            this.fullTimeStudentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fullTimeStudentToolStripMenuItem.Text = "FullTime Student";
            // 
            // grpQuickSearchGroupBox
            // 
            this.grpQuickSearchGroupBox.Controls.Add(this.contactTextBox);
            this.grpQuickSearchGroupBox.Controls.Add(this.coursesTextBox);
            this.grpQuickSearchGroupBox.Controls.Add(this.gpaTextBox);
            this.grpQuickSearchGroupBox.Controls.Add(this.lNameTextBox);
            this.grpQuickSearchGroupBox.Controls.Add(this.fNameTextBoxt);
            this.grpQuickSearchGroupBox.Controls.Add(this.contactLabel);
            this.grpQuickSearchGroupBox.Controls.Add(this.coursesLabel);
            this.grpQuickSearchGroupBox.Controls.Add(this.gpaLabel);
            this.grpQuickSearchGroupBox.Controls.Add(this.lastNameLabel);
            this.grpQuickSearchGroupBox.Controls.Add(this.firstNameLabel);
            this.grpQuickSearchGroupBox.Controls.Add(this.panelVerticalLine);
            this.grpQuickSearchGroupBox.Controls.Add(this.searchButton);
            this.grpQuickSearchGroupBox.Controls.Add(this.studentIdTextBox);
            this.grpQuickSearchGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpQuickSearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuickSearchGroupBox.Location = new System.Drawing.Point(30, 173);
            this.grpQuickSearchGroupBox.Name = "grpQuickSearchGroupBox";
            this.grpQuickSearchGroupBox.Size = new System.Drawing.Size(810, 403);
            this.grpQuickSearchGroupBox.TabIndex = 3;
            this.grpQuickSearchGroupBox.TabStop = false;
            this.grpQuickSearchGroupBox.Text = "Quick Search";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(483, 313);
            this.contactTextBox.Multiline = true;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(298, 33);
            this.contactTextBox.TabIndex = 12;
            // 
            // coursesTextBox
            // 
            this.coursesTextBox.Location = new System.Drawing.Point(483, 254);
            this.coursesTextBox.Multiline = true;
            this.coursesTextBox.Name = "coursesTextBox";
            this.coursesTextBox.Size = new System.Drawing.Size(298, 33);
            this.coursesTextBox.TabIndex = 11;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(483, 181);
            this.gpaTextBox.Multiline = true;
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(298, 33);
            this.gpaTextBox.TabIndex = 10;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(483, 112);
            this.lNameTextBox.Multiline = true;
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(298, 33);
            this.lNameTextBox.TabIndex = 9;
            // 
            // fNameTextBoxt
            // 
            this.fNameTextBoxt.Location = new System.Drawing.Point(483, 55);
            this.fNameTextBoxt.Multiline = true;
            this.fNameTextBoxt.Name = "fNameTextBoxt";
            this.fNameTextBoxt.Size = new System.Drawing.Size(298, 33);
            this.fNameTextBoxt.TabIndex = 8;
            // 
            // contactLabel
            // 
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(328, 322);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(108, 24);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact:";
            // 
            // coursesLabel
            // 
            this.coursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesLabel.Location = new System.Drawing.Point(328, 263);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(108, 24);
            this.coursesLabel.TabIndex = 6;
            this.coursesLabel.Text = "Courses:";
            // 
            // gpaLabel
            // 
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.Location = new System.Drawing.Point(328, 190);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(108, 24);
            this.gpaLabel.TabIndex = 5;
            this.gpaLabel.Text = "GPA:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(328, 121);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(108, 24);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "LastName:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(328, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(108, 24);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "FirstName:";
            // 
            // panelVerticalLine
            // 
            this.panelVerticalLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelVerticalLine.Location = new System.Drawing.Point(298, 32);
            this.panelVerticalLine.Name = "panelVerticalLine";
            this.panelVerticalLine.Size = new System.Drawing.Size(2, 337);
            this.panelVerticalLine.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(94, 226);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(30, 163);
            this.studentIdTextBox.Multiline = true;
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(223, 30);
            this.studentIdTextBox.TabIndex = 0;
            this.studentIdTextBox.TextChanged += new System.EventHandler(this.studentIdTextBox_TextChanged);
            this.studentIdTextBox.Enter += new System.EventHandler(this.studentIdTextBox_Enter);
            this.studentIdTextBox.Leave += new System.EventHandler(this.studentIdTextBox_Leave);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 601);
            this.Controls.Add(this.grpQuickSearchGroupBox);
            this.Controls.Add(this.adminNameLabel);
            this.Controls.Add(this.adminPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpQuickSearchGroupBox.ResumeLayout(false);
            this.grpQuickSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox adminPictureBox;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studnetManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem athletesStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partTimeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullTimeStudentToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpQuickSearchGroupBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel panelVerticalLine;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox coursesTextBox;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBoxt;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label coursesLabel;
    }
}
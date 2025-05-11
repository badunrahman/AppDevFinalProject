namespace StudentManagementSystem.Forms
{
    partial class StudentProfileView
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
            this.studentProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.studentTypeTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.studentTypeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teachAndCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.teacherIdComboBox = new System.Windows.Forms.ComboBox();
            this.teachersNameComboBox = new System.Windows.Forms.ComboBox();
            this.feedBackForEachCourseTextBox = new System.Windows.Forms.TextBox();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.teacherIdLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.gradesInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.feedBackTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePictureBox)).BeginInit();
            this.studentInfoGroupBox.SuspendLayout();
            this.teachAndCoursesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentProfilePictureBox
            // 
            this.studentProfilePictureBox.Location = new System.Drawing.Point(30, 23);
            this.studentProfilePictureBox.Name = "studentProfilePictureBox";
            this.studentProfilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.studentProfilePictureBox.TabIndex = 0;
            this.studentProfilePictureBox.TabStop = false;
            this.studentProfilePictureBox.Click += new System.EventHandler(this.studentProfilePictureBox_Click);
            this.studentProfilePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.studentProfilePictureBox_Paint);
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.studentTypeTextBox);
            this.studentInfoGroupBox.Controls.Add(this.contactTextBox);
            this.studentInfoGroupBox.Controls.Add(this.addressTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentTypeLabel);
            this.studentInfoGroupBox.Controls.Add(this.contactLabel);
            this.studentInfoGroupBox.Controls.Add(this.label1);
            this.studentInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfoGroupBox.Location = new System.Drawing.Point(30, 183);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Size = new System.Drawing.Size(453, 279);
            this.studentInfoGroupBox.TabIndex = 1;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "StudentInfo";
            this.studentInfoGroupBox.Enter += new System.EventHandler(this.studentInfoGroupBox_Enter);
            // 
            // studentTypeTextBox
            // 
            this.studentTypeTextBox.Location = new System.Drawing.Point(188, 198);
            this.studentTypeTextBox.Name = "studentTypeTextBox";
            this.studentTypeTextBox.Size = new System.Drawing.Size(259, 23);
            this.studentTypeTextBox.TabIndex = 8;
            this.studentTypeTextBox.TextChanged += new System.EventHandler(this.studentTypeTextBox_TextChanged);
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(188, 131);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(259, 23);
            this.contactTextBox.TabIndex = 7;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(188, 67);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(259, 23);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // studentTypeLabel
            // 
            this.studentTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTypeLabel.Location = new System.Drawing.Point(6, 199);
            this.studentTypeLabel.Name = "studentTypeLabel";
            this.studentTypeLabel.Size = new System.Drawing.Size(94, 24);
            this.studentTypeLabel.TabIndex = 2;
            this.studentTypeLabel.Text = "Student Type";
            // 
            // contactLabel
            // 
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(6, 131);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(54, 19);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // teachAndCoursesGroupBox
            // 
            this.teachAndCoursesGroupBox.Controls.Add(this.chooseCoursesComboBox);
            this.teachAndCoursesGroupBox.Controls.Add(this.teacherIdComboBox);
            this.teachAndCoursesGroupBox.Controls.Add(this.teachersNameComboBox);
            this.teachAndCoursesGroupBox.Controls.Add(this.feedBackForEachCourseTextBox);
            this.teachAndCoursesGroupBox.Controls.Add(this.coursesLabel);
            this.teachAndCoursesGroupBox.Controls.Add(this.teacherIdLabel);
            this.teachAndCoursesGroupBox.Controls.Add(this.teacherLabel);
            this.teachAndCoursesGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachAndCoursesGroupBox.Location = new System.Drawing.Point(516, 183);
            this.teachAndCoursesGroupBox.Name = "teachAndCoursesGroupBox";
            this.teachAndCoursesGroupBox.Size = new System.Drawing.Size(453, 279);
            this.teachAndCoursesGroupBox.TabIndex = 2;
            this.teachAndCoursesGroupBox.TabStop = false;
            this.teachAndCoursesGroupBox.Text = "TeacherCoursesInfo";
            this.teachAndCoursesGroupBox.Enter += new System.EventHandler(this.teachAndCoursesGroupBox_Enter);
            // 
            // chooseCoursesComboBox
            // 
            this.chooseCoursesComboBox.FormattingEnabled = true;
            this.chooseCoursesComboBox.Location = new System.Drawing.Point(101, 127);
            this.chooseCoursesComboBox.Name = "chooseCoursesComboBox";
            this.chooseCoursesComboBox.Size = new System.Drawing.Size(299, 23);
            this.chooseCoursesComboBox.TabIndex = 14;
            this.chooseCoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseCoursesComboBox_SelectedIndexChanged);
            // 
            // teacherIdComboBox
            // 
            this.teacherIdComboBox.FormattingEnabled = true;
            this.teacherIdComboBox.Location = new System.Drawing.Point(101, 77);
            this.teacherIdComboBox.Name = "teacherIdComboBox";
            this.teacherIdComboBox.Size = new System.Drawing.Size(299, 23);
            this.teacherIdComboBox.TabIndex = 13;
            this.teacherIdComboBox.SelectedIndexChanged += new System.EventHandler(this.teacherIdComboBox_SelectedIndexChanged);
            // 
            // teachersNameComboBox
            // 
            this.teachersNameComboBox.FormattingEnabled = true;
            this.teachersNameComboBox.Location = new System.Drawing.Point(101, 30);
            this.teachersNameComboBox.Name = "teachersNameComboBox";
            this.teachersNameComboBox.Size = new System.Drawing.Size(299, 23);
            this.teachersNameComboBox.TabIndex = 12;
            this.teachersNameComboBox.SelectedIndexChanged += new System.EventHandler(this.teachersNameComboBox_SelectedIndexChanged);
            // 
            // feedBackForEachCourseTextBox
            // 
            this.feedBackForEachCourseTextBox.Location = new System.Drawing.Point(9, 157);
            this.feedBackForEachCourseTextBox.Multiline = true;
            this.feedBackForEachCourseTextBox.Name = "feedBackForEachCourseTextBox";
            this.feedBackForEachCourseTextBox.Size = new System.Drawing.Size(438, 98);
            this.feedBackForEachCourseTextBox.TabIndex = 6;
            this.feedBackForEachCourseTextBox.TextChanged += new System.EventHandler(this.feedBackForEachCourseTextBox_TextChanged);
            // 
            // coursesLabel
            // 
            this.coursesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesLabel.Location = new System.Drawing.Point(6, 131);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(54, 19);
            this.coursesLabel.TabIndex = 11;
            this.coursesLabel.Text = "Course";
            // 
            // teacherIdLabel
            // 
            this.teacherIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIdLabel.Location = new System.Drawing.Point(6, 79);
            this.teacherIdLabel.Name = "teacherIdLabel";
            this.teacherIdLabel.Size = new System.Drawing.Size(80, 21);
            this.teacherIdLabel.TabIndex = 10;
            this.teacherIdLabel.Text = "Teacher ID";
            // 
            // teacherLabel
            // 
            this.teacherLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(6, 30);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(54, 19);
            this.teacherLabel.TabIndex = 9;
            this.teacherLabel.Text = "Name";
            // 
            // gradesInfoGroupBox
            // 
            this.gradesInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesInfoGroupBox.Location = new System.Drawing.Point(1000, 183);
            this.gradesInfoGroupBox.Name = "gradesInfoGroupBox";
            this.gradesInfoGroupBox.Size = new System.Drawing.Size(338, 279);
            this.gradesInfoGroupBox.TabIndex = 2;
            this.gradesInfoGroupBox.TabStop = false;
            this.gradesInfoGroupBox.Text = "GradesInfo";
            this.gradesInfoGroupBox.Enter += new System.EventHandler(this.gradesInfoGroupBox_Enter);
            // 
            // feedBackTextBox
            // 
            this.feedBackTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBackTextBox.Location = new System.Drawing.Point(30, 533);
            this.feedBackTextBox.Multiline = true;
            this.feedBackTextBox.Name = "feedBackTextBox";
            this.feedBackTextBox.Size = new System.Drawing.Size(1308, 180);
            this.feedBackTextBox.TabIndex = 3;
            this.feedBackTextBox.TextChanged += new System.EventHandler(this.feedBackTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(145, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(218, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // StudentProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 781);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.feedBackTextBox);
            this.Controls.Add(this.gradesInfoGroupBox);
            this.Controls.Add(this.teachAndCoursesGroupBox);
            this.Controls.Add(this.studentInfoGroupBox);
            this.Controls.Add(this.studentProfilePictureBox);
            this.Name = "StudentProfileView";
            this.Text = "StudentProfileView";
            this.Load += new System.EventHandler(this.StudentProfileView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePictureBox)).EndInit();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.teachAndCoursesGroupBox.ResumeLayout(false);
            this.teachAndCoursesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentProfilePictureBox;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.GroupBox teachAndCoursesGroupBox;
        private System.Windows.Forms.GroupBox gradesInfoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox feedBackTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox studentTypeTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label studentTypeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.ComboBox teacherIdComboBox;
        private System.Windows.Forms.ComboBox teachersNameComboBox;
        private System.Windows.Forms.TextBox feedBackForEachCourseTextBox;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Label teacherIdLabel;
        private System.Windows.Forms.ComboBox chooseCoursesComboBox;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.studentProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.allGradeInputLabel = new System.Windows.Forms.Label();
            this.feedBackTextBox = new System.Windows.Forms.TextBox();
            this.searchIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.studentDBDataSet = new StudentManagementSystem.StudentDBDataSet();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter = new StudentManagementSystem.StudentDBDataSetTableAdapters.GradesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePictureBox)).BeginInit();
            this.studentInfoGroupBox.SuspendLayout();
            this.teachAndCoursesGroupBox.SuspendLayout();
            this.gradesInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentProfilePictureBox
            // 
            this.studentProfilePictureBox.Location = new System.Drawing.Point(30, 23);
            this.studentProfilePictureBox.Name = "studentProfilePictureBox";
            this.studentProfilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.studentProfilePictureBox.TabIndex = 0;
            this.studentProfilePictureBox.TabStop = false;
            this.studentProfilePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.studentProfilePictureBox_Paint);
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.nameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.nameLabel);
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
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(188, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 23);
            this.nameTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 19);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // studentTypeTextBox
            // 
            this.studentTypeTextBox.Location = new System.Drawing.Point(188, 198);
            this.studentTypeTextBox.Name = "studentTypeTextBox";
            this.studentTypeTextBox.Size = new System.Drawing.Size(259, 23);
            this.studentTypeTextBox.TabIndex = 8;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(188, 131);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(259, 23);
            this.contactTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(188, 67);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(259, 23);
            this.addressTextBox.TabIndex = 6;
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
            this.gradesInfoGroupBox.Controls.Add(this.gradesDataGridView);
            this.gradesInfoGroupBox.Controls.Add(this.allGradeInputLabel);
            this.gradesInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesInfoGroupBox.Location = new System.Drawing.Point(1000, 183);
            this.gradesInfoGroupBox.Name = "gradesInfoGroupBox";
            this.gradesInfoGroupBox.Size = new System.Drawing.Size(338, 279);
            this.gradesInfoGroupBox.TabIndex = 2;
            this.gradesInfoGroupBox.TabStop = false;
            this.gradesInfoGroupBox.Text = "GradesInfo";
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradesDataGridView.Location = new System.Drawing.Point(3, 19);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.Size = new System.Drawing.Size(332, 257);
            this.gradesDataGridView.TabIndex = 2;
            // 
            // allGradeInputLabel
            // 
            this.allGradeInputLabel.AutoSize = true;
            this.allGradeInputLabel.Location = new System.Drawing.Point(139, 35);
            this.allGradeInputLabel.Name = "allGradeInputLabel";
            this.allGradeInputLabel.Size = new System.Drawing.Size(55, 15);
            this.allGradeInputLabel.TabIndex = 1;
            this.allGradeInputLabel.Text = "All Grade";
            // 
            // feedBackTextBox
            // 
            this.feedBackTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBackTextBox.Location = new System.Drawing.Point(30, 533);
            this.feedBackTextBox.Multiline = true;
            this.feedBackTextBox.Name = "feedBackTextBox";
            this.feedBackTextBox.Size = new System.Drawing.Size(1308, 180);
            this.feedBackTextBox.TabIndex = 3;
            // 
            // searchIdLabel
            // 
            this.searchIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIdLabel.Location = new System.Drawing.Point(145, 62);
            this.searchIdLabel.Name = "searchIdLabel";
            this.searchIdLabel.Size = new System.Drawing.Size(52, 25);
            this.searchIdLabel.TabIndex = 4;
            this.searchIdLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(218, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(161, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(249, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // studentDBDataSetBindingSource1
            // 
            this.studentDBDataSetBindingSource1.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource1.Position = 0;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.studentDBDataSetBindingSource1;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 781);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.searchIdLabel);
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
            this.gradesInfoGroupBox.ResumeLayout(false);
            this.gradesInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
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
        private System.Windows.Forms.Label searchIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label allGradeInputLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private StudentDBDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
    }
}
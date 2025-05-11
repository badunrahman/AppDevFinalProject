namespace StudentManagementSystem.Forms
{
    partial class TeacherDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            this.titleLabel = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new StudentManagementSystem.StudentDBDataSet();
            this.teacherProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.sendFeedbackButton = new System.Windows.Forms.Button();
            this.updateGradesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.chooseCourseLabel = new System.Windows.Forms.Label();
            this.lightModeButton = new System.Windows.Forms.Button();
            this.frenchButton = new System.Windows.Forms.Button();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentManagementSystem.StudentDBDataSetTableAdapters.StudentsTableAdapter();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            this.teacherProfileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(420, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 61);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Student Management System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Controls.Add(this.gradeTextBox);
            this.dashboardPanel.Controls.Add(this.studentDataGridView);
            this.dashboardPanel.Controls.Add(this.teacherProfileGroupBox);
            this.dashboardPanel.Controls.Add(this.feedbackLabel);
            this.dashboardPanel.Controls.Add(this.feedbackTextBox);
            this.dashboardPanel.Controls.Add(this.sendFeedbackButton);
            this.dashboardPanel.Controls.Add(this.updateGradesButton);
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Controls.Add(this.courseComboBox);
            this.dashboardPanel.Controls.Add(this.chooseCourseLabel);
            this.dashboardPanel.Location = new System.Drawing.Point(12, 73);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(983, 410);
            this.dashboardPanel.TabIndex = 2;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grade});
            this.studentDataGridView.Location = new System.Drawing.Point(14, 62);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(455, 332);
            this.studentDataGridView.TabIndex = 9;
            // 
            // studentDBDataSetBindingSource1
            // 
            this.studentDBDataSetBindingSource1.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource1.Position = 0;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherProfileGroupBox
            // 
            this.teacherProfileGroupBox.Controls.Add(this.coursesLabel);
            this.teacherProfileGroupBox.Controls.Add(this.coursesListBox);
            this.teacherProfileGroupBox.Controls.Add(this.nameLabel);
            this.teacherProfileGroupBox.Controls.Add(this.IdLabel);
            this.teacherProfileGroupBox.Location = new System.Drawing.Point(646, 12);
            this.teacherProfileGroupBox.Name = "teacherProfileGroupBox";
            this.teacherProfileGroupBox.Size = new System.Drawing.Size(326, 150);
            this.teacherProfileGroupBox.TabIndex = 8;
            this.teacherProfileGroupBox.TabStop = false;
            this.teacherProfileGroupBox.Text = "Teacher Profile";
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Location = new System.Drawing.Point(129, 24);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(78, 13);
            this.coursesLabel.TabIndex = 3;
            this.coursesLabel.Text = "Courses taught";
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.Location = new System.Drawing.Point(132, 42);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(188, 108);
            this.coursesListBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 29);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "User ID:";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Location = new System.Drawing.Point(486, 163);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(124, 23);
            this.feedbackLabel.TabIndex = 7;
            this.feedbackLabel.Text = "Feedback";
            this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(489, 189);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(483, 166);
            this.feedbackTextBox.TabIndex = 6;
            // 
            // sendFeedbackButton
            // 
            this.sendFeedbackButton.Location = new System.Drawing.Point(851, 361);
            this.sendFeedbackButton.Name = "sendFeedbackButton";
            this.sendFeedbackButton.Size = new System.Drawing.Size(121, 33);
            this.sendFeedbackButton.TabIndex = 5;
            this.sendFeedbackButton.Text = "Send feedback";
            this.sendFeedbackButton.UseVisualStyleBackColor = true;
            // 
            // updateGradesButton
            // 
            this.updateGradesButton.Location = new System.Drawing.Point(489, 62);
            this.updateGradesButton.Name = "updateGradesButton";
            this.updateGradesButton.Size = new System.Drawing.Size(151, 33);
            this.updateGradesButton.TabIndex = 4;
            this.updateGradesButton.Text = "Update Grade";
            this.updateGradesButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(156, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(141, 12);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseComboBox.TabIndex = 1;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // chooseCourseLabel
            // 
            this.chooseCourseLabel.Location = new System.Drawing.Point(11, 12);
            this.chooseCourseLabel.Name = "chooseCourseLabel";
            this.chooseCourseLabel.Size = new System.Drawing.Size(124, 23);
            this.chooseCourseLabel.TabIndex = 0;
            this.chooseCourseLabel.Text = "Choose course to view:";
            // 
            // lightModeButton
            // 
            this.lightModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lightModeButton.BackgroundImage")));
            this.lightModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightModeButton.ForeColor = System.Drawing.Color.Silver;
            this.lightModeButton.Location = new System.Drawing.Point(956, 12);
            this.lightModeButton.Name = "lightModeButton";
            this.lightModeButton.Size = new System.Drawing.Size(31, 30);
            this.lightModeButton.TabIndex = 5;
            this.lightModeButton.UseVisualStyleBackColor = true;
            // 
            // frenchButton
            // 
            this.frenchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frenchButton.BackgroundImage")));
            this.frenchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frenchButton.ForeColor = System.Drawing.Color.Silver;
            this.frenchButton.Location = new System.Drawing.Point(916, 12);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(31, 30);
            this.frenchButton.TabIndex = 4;
            this.frenchButton.UseVisualStyleBackColor = true;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(489, 36);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(151, 20);
            this.gradeTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(486, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Grade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 495);
            this.Controls.Add(this.lightModeButton);
            this.Controls.Add(this.frenchButton);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "TeacherDashboard";
            this.Text = "TeacherDashboard";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            this.teacherProfileGroupBox.ResumeLayout(false);
            this.teacherProfileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button lightModeButton;
        private System.Windows.Forms.Button frenchButton;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label chooseCourseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.GroupBox teacherProfileGroupBox;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.Button sendFeedbackButton;
        private System.Windows.Forms.Button updateGradesButton;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}
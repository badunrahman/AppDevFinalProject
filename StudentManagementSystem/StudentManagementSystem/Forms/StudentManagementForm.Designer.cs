namespace StudentManagementSystem.Forms
{
    partial class StudentManagementForm
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
            this.createStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.studentTypeLabel = new System.Windows.Forms.Label();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.coursesTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.fullTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.partTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.athleteRadioButton = new System.Windows.Forms.RadioButton();
            this.creatStudnetTitleLabel = new System.Windows.Forms.Label();
            this.createStudentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createStudentGroupBox
            // 
            this.createStudentGroupBox.Controls.Add(this.creatStudnetTitleLabel);
            this.createStudentGroupBox.Controls.Add(this.athleteRadioButton);
            this.createStudentGroupBox.Controls.Add(this.partTimeRadioButton);
            this.createStudentGroupBox.Controls.Add(this.fullTimeRadioButton);
            this.createStudentGroupBox.Controls.Add(this.teacherTextBox);
            this.createStudentGroupBox.Controls.Add(this.coursesTextBox);
            this.createStudentGroupBox.Controls.Add(this.contactTextBox);
            this.createStudentGroupBox.Controls.Add(this.addressTextBox);
            this.createStudentGroupBox.Controls.Add(this.nameTextBox);
            this.createStudentGroupBox.Controls.Add(this.clearButton);
            this.createStudentGroupBox.Controls.Add(this.savebutton);
            this.createStudentGroupBox.Controls.Add(this.teacherLabel);
            this.createStudentGroupBox.Controls.Add(this.coursesLabel);
            this.createStudentGroupBox.Controls.Add(this.studentTypeLabel);
            this.createStudentGroupBox.Controls.Add(this.contactLabel);
            this.createStudentGroupBox.Controls.Add(this.addressLabel);
            this.createStudentGroupBox.Controls.Add(this.nameLabel);
            this.createStudentGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStudentGroupBox.Location = new System.Drawing.Point(22, 33);
            this.createStudentGroupBox.Name = "createStudentGroupBox";
            this.createStudentGroupBox.Size = new System.Drawing.Size(856, 488);
            this.createStudentGroupBox.TabIndex = 0;
            this.createStudentGroupBox.TabStop = false;
            this.createStudentGroupBox.Text = "\'";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 27);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(31, 127);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(86, 30);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(31, 185);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(118, 27);
            this.contactLabel.TabIndex = 2;
            this.contactLabel.Text = "Contact #:";
            // 
            // studentTypeLabel
            // 
            this.studentTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTypeLabel.Location = new System.Drawing.Point(31, 249);
            this.studentTypeLabel.Name = "studentTypeLabel";
            this.studentTypeLabel.Size = new System.Drawing.Size(131, 26);
            this.studentTypeLabel.TabIndex = 3;
            this.studentTypeLabel.Text = "Student Type:";
            // 
            // coursesLabel
            // 
            this.coursesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesLabel.Location = new System.Drawing.Point(31, 312);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(93, 29);
            this.coursesLabel.TabIndex = 4;
            this.coursesLabel.Text = "Courses:";
            // 
            // teacherLabel
            // 
            this.teacherLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(31, 381);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(93, 32);
            this.teacherLabel.TabIndex = 5;
            this.teacherLabel.Text = "Teacher:";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(352, 424);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(94, 30);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(510, 424);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 30);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(310, 63);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(526, 27);
            this.nameTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(310, 127);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(526, 27);
            this.addressTextBox.TabIndex = 10;
            // 
            // contactTextBox
            // 
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.Location = new System.Drawing.Point(310, 185);
            this.contactTextBox.Multiline = true;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(526, 27);
            this.contactTextBox.TabIndex = 11;
            // 
            // coursesTextBox
            // 
            this.coursesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursesTextBox.Location = new System.Drawing.Point(310, 314);
            this.coursesTextBox.Multiline = true;
            this.coursesTextBox.Name = "coursesTextBox";
            this.coursesTextBox.Size = new System.Drawing.Size(526, 27);
            this.coursesTextBox.TabIndex = 13;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherTextBox.Location = new System.Drawing.Point(310, 381);
            this.teacherTextBox.Multiline = true;
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(526, 27);
            this.teacherTextBox.TabIndex = 14;
            // 
            // fullTimeRadioButton
            // 
            this.fullTimeRadioButton.AutoSize = true;
            this.fullTimeRadioButton.Location = new System.Drawing.Point(310, 257);
            this.fullTimeRadioButton.Name = "fullTimeRadioButton";
            this.fullTimeRadioButton.Size = new System.Drawing.Size(93, 25);
            this.fullTimeRadioButton.TabIndex = 15;
            this.fullTimeRadioButton.TabStop = true;
            this.fullTimeRadioButton.Text = "Full-Time";
            this.fullTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // partTimeRadioButton
            // 
            this.partTimeRadioButton.AutoSize = true;
            this.partTimeRadioButton.Location = new System.Drawing.Point(485, 257);
            this.partTimeRadioButton.Name = "partTimeRadioButton";
            this.partTimeRadioButton.Size = new System.Drawing.Size(95, 25);
            this.partTimeRadioButton.TabIndex = 16;
            this.partTimeRadioButton.TabStop = true;
            this.partTimeRadioButton.Text = "Part-Time";
            this.partTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // athleteRadioButton
            // 
            this.athleteRadioButton.AutoSize = true;
            this.athleteRadioButton.Location = new System.Drawing.Point(680, 257);
            this.athleteRadioButton.Name = "athleteRadioButton";
            this.athleteRadioButton.Size = new System.Drawing.Size(84, 25);
            this.athleteRadioButton.TabIndex = 17;
            this.athleteRadioButton.TabStop = true;
            this.athleteRadioButton.Text = "Athletes";
            this.athleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // creatStudnetTitleLabel
            // 
            this.creatStudnetTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatStudnetTitleLabel.Location = new System.Drawing.Point(347, 0);
            this.creatStudnetTitleLabel.Name = "creatStudnetTitleLabel";
            this.creatStudnetTitleLabel.Size = new System.Drawing.Size(216, 43);
            this.creatStudnetTitleLabel.TabIndex = 18;
            this.creatStudnetTitleLabel.Text = "Create student";
            this.creatStudnetTitleLabel.Click += new System.EventHandler(this.creatStudnetTitleLabel_Click);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 552);
            this.Controls.Add(this.createStudentGroupBox);
            this.Name = "StudentManagementForm";
            this.Text = "StudentManagementForm";
            this.createStudentGroupBox.ResumeLayout(false);
            this.createStudentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createStudentGroupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Label studentTypeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.TextBox coursesTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RadioButton athleteRadioButton;
        private System.Windows.Forms.RadioButton partTimeRadioButton;
        private System.Windows.Forms.RadioButton fullTimeRadioButton;
        private System.Windows.Forms.Label creatStudnetTitleLabel;
    }
}
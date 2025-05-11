namespace StudentManagementSystem.Forms
{
    partial class athleteStudentView
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
            this.athleteDataGridView = new System.Windows.Forms.DataGridView();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.athleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // athleteDataGridView
            // 
            this.athleteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.athleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.athleteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Courses});
            this.athleteDataGridView.Location = new System.Drawing.Point(12, 65);
            this.athleteDataGridView.Name = "athleteDataGridView";
            this.athleteDataGridView.ReadOnly = true;
            this.athleteDataGridView.Size = new System.Drawing.Size(653, 318);
            this.athleteDataGridView.TabIndex = 0;
            // 
            // Courses
            // 
            this.Courses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Courses.HeaderText = "Courses";
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            this.Courses.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athlete Students Information";
            // 
            // athleteStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.athleteDataGridView);
            this.Name = "athleteStudentView";
            this.Text = "Athlete Students";
            this.Load += new System.EventHandler(this.athleteStudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.athleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView athleteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
    }
}
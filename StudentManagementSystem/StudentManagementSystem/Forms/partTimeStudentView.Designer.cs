namespace StudentManagementSystem.Forms
{
    partial class partTimeStudentView
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.partTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.partTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(219, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(260, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Part Time Students Information";
            // 
            // partTimeDataGridView
            // 
            this.partTimeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.partTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Courses});
            this.partTimeDataGridView.Location = new System.Drawing.Point(12, 58);
            this.partTimeDataGridView.Name = "partTimeDataGridView";
            this.partTimeDataGridView.ReadOnly = true;
            this.partTimeDataGridView.Size = new System.Drawing.Size(653, 318);
            this.partTimeDataGridView.TabIndex = 2;
            // 
            // Courses
            // 
            this.Courses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Courses.HeaderText = "Courses";
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            this.Courses.Width = 70;
            // 
            // partTimeStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 398);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.partTimeDataGridView);
            this.Name = "partTimeStudentView";
            this.Text = "Part Time Students";
            this.Load += new System.EventHandler(this.partTimeStudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView partTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
    }
}
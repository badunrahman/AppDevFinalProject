namespace StudentManagementSystem.Forms
{
    partial class PartTimeStudentView
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
            this.partTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partTimeDataGridView
            // 
            this.partTimeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.partTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Courses});
            this.partTimeDataGridView.Location = new System.Drawing.Point(12, 42);
            this.partTimeDataGridView.Name = "partTimeDataGridView";
            this.partTimeDataGridView.ReadOnly = true;
            this.partTimeDataGridView.Size = new System.Drawing.Size(653, 318);
            this.partTimeDataGridView.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part Time Students Information";
            // 
            // PartTimeStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partTimeDataGridView);
            this.Name = "PartTimeStudentView";
            this.Text = "PartTimeStudentView";
            this.Load += new System.EventHandler(this.PartTimeStudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
        private System.Windows.Forms.Label label1;
    }
}
namespace StudentManagementSystem.Forms
{
    partial class FullTimeStudent
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
            this.fullTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentDBDataSet = new StudentManagementSystem.StudentDBDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new StudentManagementSystem.StudentDBDataSetTableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullTimeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullTimeDataGridView
            // 
            this.fullTimeDataGridView.AutoGenerateColumns = false;
            this.fullTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.fullTimeDataGridView.DataSource = this.studentDBDataSet;
            this.fullTimeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullTimeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.fullTimeDataGridView.Name = "fullTimeDataGridView";
            this.fullTimeDataGridView.Size = new System.Drawing.Size(770, 313);
            this.fullTimeDataGridView.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(287, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(159, 21);
            this.Title.TabIndex = 1;
            this.Title.Text = "All Full Time Students";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullTimeDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.studentDBDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // FullTimeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.Name = "FullTimeStudent";
            this.Text = "FullTimeStudent";
            this.Load += new System.EventHandler(this.FullTimeStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullTimeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fullTimeDataGridView;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private StudentDBDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}
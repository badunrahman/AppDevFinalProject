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
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentProfilePictureBox
            // 
            this.studentProfilePictureBox.Location = new System.Drawing.Point(12, 12);
            this.studentProfilePictureBox.Name = "studentProfilePictureBox";
            this.studentProfilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.studentProfilePictureBox.TabIndex = 0;
            this.studentProfilePictureBox.TabStop = false;
            this.studentProfilePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.studentProfilePictureBox_Paint);
            // 
            // StudentProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 768);
            this.Controls.Add(this.studentProfilePictureBox);
            this.Name = "StudentProfileView";
            this.Text = "StudentProfileView";
            this.Load += new System.EventHandler(this.StudentProfileView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox studentProfilePictureBox;
    }
}
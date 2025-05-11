using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class StudentProfileView : Form
    {
        public StudentProfileView()
        {
            InitializeComponent();
        }

        private void CircularPictureBox(PictureBox picBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picBox.Width - 1, picBox.Height - 1);
            picBox.Region = new Region(gp);
        }

        private void StudentProfileView_Load(object sender, EventArgs e)
        {
            CircularPictureBox(studentProfilePictureBox);
        }

        private void studentProfilePictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            using (Pen pen = new Pen(Color.Black, 4)) // Color + thickness
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                e.Graphics.DrawEllipse(pen, 1, 1, picBox.Width - 3, picBox.Height - 3);
            }
        }
    }
}

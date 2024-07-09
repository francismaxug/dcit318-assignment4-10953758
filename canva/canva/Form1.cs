using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace canva
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private bool isDrawing = false;
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (graphics == null)
                {
                    graphics = pictureBox1.CreateGraphics();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                }
                graphics.DrawLine(pen, startPoint, e.Location);
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}

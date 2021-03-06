﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPaint
{
    public partial class Form1 : Form
    {
        //vars
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        //Mouse Events
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3,1);
                pictureBox1.Image = bmp;
            }
        }

        //Color Events
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange; 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            p.Color = Color.Indigo;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            p.Color = Color.Violet;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }
    }
}

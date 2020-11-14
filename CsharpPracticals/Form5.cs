using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpPracticals
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int readypaint = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form5_MouseUp(object sender, MouseEventArgs e)
        {
            readypaint = 0;
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            readypaint = 1;
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (readypaint == 1)
            {
                Graphics g = CreateGraphics();
                Pen p = new Pen(Color.Red);
                SolidBrush sb=new SolidBrush(Color.Red);
                g.DrawEllipse(p, e.X, e.Y, 10, 10);
                g.FillEllipse(sb, e.X, e.Y, 10, 10);
            }
        }
    }
}

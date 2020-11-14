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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] items = new string[4];
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            items[0]="Fill Ellipse";
            items[1]="Draw Rectangle";
            items[2]="Draw Ellipse";
            items[3]="Draw Square";
            comboBox1.Items.AddRange(items);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = base.CreateGraphics();
            Pen p = new Pen(Color.Blue);
            SolidBrush sb = new SolidBrush(Color.Brown);
            g.Clear(Color.White);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    g.FillEllipse(sb, 50, 50, 150, 150);
                    break;
                case 1:
                    g.DrawRectangle(p, 50, 50, 200, 150);
                    break;
                case 2:
                    g.DrawEllipse(p, 50, 80, 150, 170);
                    break;
                case 3:
                    g.DrawRectangle(p, 50, 50, 50, 50);
                    break;
            }
        }
    }
}

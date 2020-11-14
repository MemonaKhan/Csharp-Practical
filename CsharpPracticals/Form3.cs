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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Button[] b = new Button[5];
            for (int i = 1; i <= b.Length - 1; i++)
            {
                b[i] = new Button();
                b[i].Text = "Button" + i;
                b[i].Size = new Size(100, 30);
                b[i].Location = new Point(i + 70, i + 100);
                b[i].Left = 50 * i;
                b[i].Top = i * 70;
                b[i].BackColor = Color.White;
                this.Controls.Add(b[i]);

            }
        }
    }
}

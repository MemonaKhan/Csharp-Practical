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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int imageno;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageno == 8)
                imageno = 1;
            pictureBox1.ImageLocation = string.Format(@"D:\2nd semester\OOPs\Pictures\{0}.jpg", imageno);
            imageno++;
        }
    }
}

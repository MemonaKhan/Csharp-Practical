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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public class Calculator
        {
            protected double num1, num2;
            public Calculator() { }
            public Calculator(double n1, double n2)
            {
                num1 = n1;
                num2 = n2;
            }
            public void setNum1(double n1)
            {
                num1 = n1;
            }
            public void setNum2(double n2)
            {
                num2 = n2;
            }

            public double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public double Subtract(double n, double m)
            {
                return n - m;
            }
            public double Multiply(double n, double m)
            {
                return n * m;
            }
            public double Divide(double n, double m)
            {
                return n / m;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator C1 = new Calculator();
            txtResult.Text = C1.Add(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Calculator C1 = new Calculator();
            txtResult.Text = C1.Subtract(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text)).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Calculator C1 = new Calculator();
            txtResult.Text = C1.Multiply(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Calculator C1 = new Calculator();
            txtResult.Text = C1.Divide(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text)).ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }
    }
}

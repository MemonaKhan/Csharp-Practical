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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class BankAccount
        {
            protected int accountNumber;
            protected string customerName;
            protected double openingBalance;

            public BankAccount(int accNo, string custName, double opBal)
            {
                accountNumber = accNo;
                customerName = custName;
                openingBalance = opBal;
            }
            public double getBalance()
            {
                return openingBalance;
            }
            public void withDraw(double ammount)
            {
                if (ammount < openingBalance)
                {
                    openingBalance = openingBalance - ammount;
                    MessageBox.Show("You have successfully withdraw Rs." + ammount);
                }
                else
                {
                    MessageBox.Show("Sorry, Withdraw Ammount is more than the deposited Ammount");
                }
            }
            public void deposite(double ammount)
            {
                openingBalance = openingBalance + ammount;
                MessageBox.Show("You have successfully deposited Rs." + ammount);
            }

            public void output()
            {
                MessageBox.Show(@"Account Number: " + accountNumber + Environment.NewLine +
                    "Customer Name: " + customerName + Environment.NewLine + "Opening Balance: " + openingBalance);
            }

        };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        BankAccount Acc1;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Acc1 = new BankAccount(Convert.ToInt32(txtAccNumber.Text), txtCustomerName.Text, Convert.ToDouble(txtOpnBalance.Text));
            Acc1.output();
            txtBalance.Text = txtOpnBalance.Text;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Acc1.deposite(Convert.ToDouble(txtTransaction.Text));
            txtBalance.Text = Acc1.getBalance().ToString();
            txtTransaction.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Acc1.withDraw(Convert.ToDouble(txtTransaction.Text));
            txtBalance.Text = Acc1.getBalance().ToString();
            txtTransaction.Clear();
        }

    }
}

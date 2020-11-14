using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CsharpPracticals
{
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form8()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\LABS\school.accdb;
Persist Security Info=False;"; 
           
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Student", con);
            DataSet d = new DataSet("student");
           
            con.Open();
            label1.Text="Connected";
            con.Close();
        }
    }
}

/*DataSet d = new DataSet();
adap.Fill(d, "s_info");*/
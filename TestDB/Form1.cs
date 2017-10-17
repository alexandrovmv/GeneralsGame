using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace TestDB
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
            InitializeComponent();
            database = new DB();
            database.Create_DataBase();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            database.Add_User(login, pass);
            MessageBox.Show("User succesfully add to database");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            if(database.Authorization(login, pass))
                MessageBox.Show("Login Success");
            else
                MessageBox.Show("Login Error");
        }
    }
}

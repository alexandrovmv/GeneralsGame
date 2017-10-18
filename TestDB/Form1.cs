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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DB db = new DB();
            DataTable dt = new DataTable();
            dt = db.Return_Table_Users();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DB db = new DB();
            DataTable dt = new DataTable();
            dt = db.Return_Table_History();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Create_DataBase();
            db.Add_User(textBox1.Text,textBox2.Text);
        }
    }
}

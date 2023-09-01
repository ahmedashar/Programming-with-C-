using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            if (x == "aatika")
            {
                MessageBox.Show("Login");
                Form2 obj1 = new Form2();
                obj1.Show(); 
            }
            var y = label1.Text;
            

            SqlConnection obj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashar\source\repos\WinFormsApp1\WinFormsApp1\Database1.mdf;Integrated Security=True");
            obj.Open();
            SqlCommand cmd = new SqlCommand("insert into users(Name) values('"+x+"')",obj);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

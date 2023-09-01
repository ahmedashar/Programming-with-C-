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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validName = "Haseeb";
            var validPassword = "aptech";

            var name = textBox1.Text;
            var password = textBox2.Text;

            if (validName == name && validPassword == password)
            {

                MessageBox.Show("Login Success");

                Form2 obj2 = new Form2();
                obj2.Show();
            }
            else
            {
                MessageBox.Show("Error");

            }
          

            SqlConnection obj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='Z:\Aptech\2203B2(TTS 9 to 11)\WinForm\WinFormsApp2\WinFormsApp2\Database1.mdf';Integrated Security=True");
            obj.Open();
            SqlCommand cmd = new SqlCommand("insert into users(Name) values('"+name+"')",obj);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value Inserted into DB");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

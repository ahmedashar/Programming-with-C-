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

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = "Hamza";
            var password = "aptech";

            var inputName = textBox1.Text;
            var inputPassword = textBox2.Text;
            if (name == inputName && password == inputPassword)
            { 

                //Form2 obj = new Form2();
                //obj.Show();

                SqlConnection obj1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='Z:\Aptech\2203B2(TTS 9 to 11)\WinForm\WinFormsApp3\WinFormsApp3\Database1.mdf';Integrated Security=True");
                obj1.Open();
                SqlCommand cmd = new SqlCommand("insert into users(Name, Password) " + "values('"+inputName+"' , '"+inputPassword+"')", obj1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted");
            }
            else
            {

                MessageBox.Show("Invalid username or password");
            }
            
        }
    }
}

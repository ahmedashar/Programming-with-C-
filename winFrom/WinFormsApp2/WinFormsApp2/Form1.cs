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
            // getting text of label and assgin new value
            label1.Text = "Ashar";
            var x = textBox1.Text;

            // alert
            MessageBox.Show("hello");

            // switch to new form screen
           // Form2 obj = new Form2();
           //obj.Show();

            SqlConnection obj2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='Z:\Aptech\2203B2(TTS 9 to 11)\C#\winFrom\WinFormsApp2\WinFormsApp2\Database1.mdf';Integrated Security=True");
            obj2.Open();
            SqlCommand cmd  = new SqlCommand("insert into users(Name) values('"+x+"')",obj2);
            cmd.ExecuteNonQuery();

            MessageBox.Show("inserted");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
    }
}

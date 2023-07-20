using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LogIn1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=LAPTOP-H3SEJLE9;Initial Catalog=studentsDB;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText="Select * from studentsTable where isim='"+textBox1.Text + "' and şifre= '" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı İsim veya Şifre!");
            }
            con.Close();
        }
    }
}

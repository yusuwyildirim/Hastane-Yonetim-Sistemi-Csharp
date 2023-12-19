using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneBilgiSistemi
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

        static string conString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;Encrypt=True;TrustServerCertificate=true;";
        SqlConnection connect = new SqlConnection(conString);




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;Encrypt=True;TrustServerCertificate=true;");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM DOKTORLAR WHERE TC='"+textBox1.Text + "'AND Passwdd='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("Tebrikler, giriş başarılı!");


                Form3 gecis = new Form3();
                gecis.Show();
                this.Hide();


            }

            else
            {

                MessageBox.Show("HATA");

            }

            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

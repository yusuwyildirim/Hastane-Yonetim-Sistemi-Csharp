using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneBilgiSistemi
{
    public partial class Form3 : Form
    {
        private string selectedTableName;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string selectedTableName)
        {
            this.selectedTableName = selectedTableName;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            Doktor gecis = new Doktor();
            gecis.Show();
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Hasta gecis = new Hasta();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Hemsire gecis = new Hemsire();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Personel gecis = new Personel();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Oda gecis = new Oda();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Yogunbakim gecis = new Yogunbakim();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Ameliyathane gecis = new Ameliyathane();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            Poliklinik gecis = new Poliklinik();
            gecis.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            Malzeme gecis = new Malzeme();
            gecis.Show();
            this.Hide();

        }
    }
}

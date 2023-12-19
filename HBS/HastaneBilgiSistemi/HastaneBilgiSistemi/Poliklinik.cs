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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneBilgiSistemi
{
    public partial class Poliklinik : Form
    {
        public Poliklinik()
        {
            InitializeComponent();
        }

        private void Poliklinik_Load(object sender, EventArgs e)
        {
           
            this.pOLIKLINIKTableAdapter.Fill(this.oLUYORUM.POLIKLINIK);

        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";


        private void button1_Click(object sender, EventArgs e)
        {





            int arananKat;
            if (int.TryParse(textBox5.Text, out arananKat))
            {
                // SQL sorgusu
                string query = "SELECT Kat FROM POLIKLINIK WHERE Poliklinik_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananKat);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox1.Text = result.ToString();
                            }
                            else
                            {
                                textBox1.Text = "ID bulunamadı";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.");

            }




            int arananKapasite;
            if (int.TryParse(textBox5.Text, out arananKapasite))
            {
                // SQL sorgusu
                string query = "SELECT Yatak_Kapasite FROM POLIKLINIK WHERE Poliklinik_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananKapasite);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox2.Text = result.ToString();
                            }
                            else
                            {
                                textBox2.Text = "ID bulunamadı";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.");
            }




            int arananPolin;
            if (int.TryParse(textBox5.Text, out arananPolin))
            {
                // SQL sorgusu
                string query = "SELECT Ad FROM POLIKLINIK WHERE Poliklinik_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananPolin);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox12.Text = result.ToString();
                            }
                            else
                            {
                                textBox12.Text = "ID bulunamadı";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.");
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 gecis = new Form3();
            gecis.Show();
            this.Hide();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO POLIKLINIK (Ad,Kat,Yatak_Kapasite) VALUES (@Ad,@Kat,@Yatak_Kapasite)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Yatak_Kapasite", textBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.pOLIKLINIKTableAdapter.Fill(this.oLUYORUM.POLIKLINIK);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {


            string query = "DELETE FROM POLIKLINIK WHERE Poliklinik_ID=@Poliklinik_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Poliklinik_ID", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.pOLIKLINIKTableAdapter.Fill(this.oLUYORUM.POLIKLINIK);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE POLIKLINIK SET Ad=@Ad,Kat=@Kat,Yatak_Kapasite=@Yatak_Kapasite WHERE Poliklinik_ID=@Poliklinik_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Poliklinik_ID", textBox5.Text);
                command.Parameters.AddWithValue("@Yatak_Kapasite", textBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.pOLIKLINIKTableAdapter.Fill(this.oLUYORUM.POLIKLINIK);

            }

        }
    }
}

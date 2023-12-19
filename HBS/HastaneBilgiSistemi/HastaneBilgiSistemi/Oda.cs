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
    public partial class Oda : Form
    {
        public Oda()
        {
            InitializeComponent();
        }

        private void Oda_Load(object sender, EventArgs e)
        {
           
            this.oDATableAdapter1.Fill(this.oLUYORUM.ODA);

        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";



        private void button1_Click(object sender, EventArgs e)
        {


            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
                // SQL sorgusu
                string query = "SELECT Oda_Numarası FROM ODA WHERE Oda_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananID);

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



            int arananKapasite;
            if (int.TryParse(textBox5.Text, out arananKapasite))
            {
                // SQL sorgusu
                string query = "SELECT Kapasite FROM ODA WHERE Oda_ID = @ID";

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




            int arananKat;
            if (int.TryParse(textBox5.Text, out arananKat))
            {
                // SQL sorgusu
                string query = "SELECT Kat FROM ODA WHERE Oda_ID = @ID";

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



            int arananDoluluk;
            if (int.TryParse(textBox5.Text, out arananDoluluk))
            {
                // Veritabanına bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    string query = "SELECT Doluluk FROM ODA WHERE Oda_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@ID", arananDoluluk);

                        // Veriyi oku
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Cinsiyet verisini al
                            string dolu = reader["Doluluk"].ToString();

                            // ComboBox'a ekle
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add(dolu);
                            comboBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID'ye sahip kullanıcı bulunamadı.");
                        }

                        reader.Close();
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
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ODA (Oda_Numarası,Kat,Kapasite,Doluluk) VALUES (@Oda_Numarası,@Kat,@Kapasite,@Doluluk)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Oda_Numarası", textBox12.Text);
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Kapasite", textBox1.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.oDATableAdapter1.Fill(this.oLUYORUM.ODA);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM ODA WHERE Oda_ID=@Oda_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Oda_ID", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.oDATableAdapter1.Fill(this.oLUYORUM.ODA);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE ODA SET Oda_Numarası=@Oda_Numarası,Kat=@Kat,Kapasite=@Kapasite,Doluluk=@Doluluk WHERE Oda_ID=@Oda_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Oda_Numarası", textBox12.Text);
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Kapasite", textBox1.Text);
                command.Parameters.AddWithValue("@Oda_ID", textBox5.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.oDATableAdapter1.Fill(this.oLUYORUM.ODA);

            }

        }
    }
}

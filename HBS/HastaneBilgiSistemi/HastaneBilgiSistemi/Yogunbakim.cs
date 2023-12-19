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
    public partial class Yogunbakim : Form
    {
        public Yogunbakim()
        {
            InitializeComponent();
        }



        private void Yogunbakim_Load(object sender, EventArgs e)
        {
            
            this.yOGUN_BAKIMTableAdapter1.Fill(this.oLUYORUM.YOGUN_BAKIM);

        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {




            int arananKat;
            if (int.TryParse(textBox5.Text, out arananKat))
            {
                // SQL sorgusu
                string query = "SELECT Kat FROM YOGUN_BAKIM WHERE YogunBakim_ID = @ID";

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



            int arananDoktor;
            if (int.TryParse(textBox5.Text, out arananDoktor))
            {
                // SQL sorgusu
                string query = "SELECT CASE WHEN YOGUN_BAKIM.Sorumlu_Doktor = '5' THEN 'Yusuf'  WHEN YOGUN_BAKIM.Sorumlu_Doktor = '7' THEN 'Gokcen' WHEN YOGUN_BAKIM.Sorumlu_Doktor = '8' THEN 'Edanur' WHEN YOGUN_BAKIM.Sorumlu_Doktor = '9' THEN 'Melikşah' WHEN YOGUN_BAKIM.Sorumlu_Doktor = '10' THEN 'Ahmet' WHEN YOGUN_BAKIM.Sorumlu_Doktor = '6' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '7' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '8' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '9' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '10' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '11' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '12' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '13' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '14' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '15' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '16' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '17' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = '18' THEN DOKTORLAR.Ad WHEN YOGUN_BAKIM.Sorumlu_Doktor = DOKTORLAR.Ad THEN DOKTORLAR.Ad END AS Sorumlu_Doktor FROM YOGUN_BAKIM INNER JOIN DOKTORLAR ON YOGUN_BAKIM.Sorumlu_Doktor = DOKTORLAR.Doktor_ID";
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananDoktor);

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
                string query = "SELECT Kapasite FROM YOGUN_BAKIM WHERE YogunBakim_ID = @ID";

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



            int arananDoluluk;
            if (int.TryParse(textBox5.Text, out arananDoluluk))
            {
                // Veritabanına bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    string query = "SELECT Doluluk FROM YOGUN_BAKIM WHERE YogunBakim_ID = @ID";
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


            int arananHemsire;
            if (int.TryParse(textBox5.Text, out arananHemsire))
            {
                // SQL sorgusu
                  string query = "SELECT CASE WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '1' THEN 'Yusuf'  WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '2' THEN 'Eda' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '3' THEN 'Alim' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '4' THEN 'Edanur' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '5' THEN 'Kerem' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '6' THEN 'Ahmet' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '7' THEN 'Veli' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '8' THEN 'Mehmet' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '9' THEN 'Can' WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '10' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '11' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '12' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '13' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '14' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '15' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '16' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '17' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = '18' THEN HEMSIRE.Ad WHEN YOGUN_BAKIM.Sorumlu_Hemsire = HEMSIRE.Ad THEN HEMSIRE.Ad END AS Sorumlu_Hemsire FROM YOGUN_BAKIM INNER JOIN HEMSIRE ON YOGUN_BAKIM.Sorumlu_Hemsire = HEMSIRE.Hemsire_ID";

               

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananHemsire);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox3.Text = result.ToString();
                            }
                            else
                            {
                                textBox3.Text = "ID bulunamadı";
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
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO YOGUN_BAKIM (Kat,Kapasite,Sorumlu_Doktor,Sorumlu_Hemsire,Doluluk) VALUES (@Kat,@Kapasite,@Sorumlu_Doktor,@Sorumlu_Hemsire,@Doluluk)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Kat", textBox12.Text);
                command.Parameters.AddWithValue("@Kapasite", textBox2.Text);
                command.Parameters.AddWithValue("@Sorumlu_Doktor", textBox1.Text);
                command.Parameters.AddWithValue("@Sorumlu_Hemsire", textBox3.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.yOGUN_BAKIMTableAdapter1.Fill(this.oLUYORUM.YOGUN_BAKIM);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM YOGUN_BAKIM WHERE YogunBakim_ID=@YogunBakim_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@YogunBakim_ID", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.yOGUN_BAKIMTableAdapter1.Fill(this.oLUYORUM.YOGUN_BAKIM);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE YOGUN_BAKIM SET Kat=@Kat,Kapasite=@Kapasite,Sorumlu_Doktor=@Sorumlu_Doktor,Sorumlu_Hemsire=@Sorumlu_Hemsire WHERE YogunBakim_ID=@YogunBakim_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Kat", textBox12.Text);
                command.Parameters.AddWithValue("@Kapasite", textBox2.Text);
                command.Parameters.AddWithValue("@YogunBakim_ID", textBox5.Text);
                command.Parameters.AddWithValue("@Sorumlu_Doktor", textBox1.Text);
                command.Parameters.AddWithValue("@Sorumlu_Hemsire", textBox3.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.yOGUN_BAKIMTableAdapter1.Fill(this.oLUYORUM.YOGUN_BAKIM);

            }


        }
    }

}

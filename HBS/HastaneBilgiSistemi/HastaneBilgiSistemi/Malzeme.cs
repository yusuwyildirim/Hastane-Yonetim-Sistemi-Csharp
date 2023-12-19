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
    public partial class Malzeme : Form
    {
        public Malzeme()
        {
            InitializeComponent();
        }

        private void Malzeme_Load(object sender, EventArgs e)
        {
            
            this.mALZEMETableAdapter1.Fill(this.oLUYORUM.MALZEME);

        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";



        private void button1_Click(object sender, EventArgs e)
        {



            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
                // SQL sorgusu
                string query = "SELECT Ad FROM MALZEME WHERE Malzeme_ID = @ID";

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



            int arananStok;
            if (int.TryParse(textBox5.Text, out arananStok))
            {
                // SQL sorgusu
                string query = "SELECT Stok FROM MALZEME WHERE Malzeme_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananStok);

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



            int arananTur;
            if (int.TryParse(textBox5.Text, out arananTur))
            {
                // Veritabanına bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    string query = "SELECT Tur FROM MALZEME WHERE Malzeme_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@ID", arananTur);

                        // Veriyi oku
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Cinsiyet verisini al
                            string turu = reader["Tur"].ToString();

                            // ComboBox'a ekle
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add(turu);
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
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MALZEME (Ad,Stok,Tur) VALUES (@Ad,@Stok,@Tur)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Stok", textBox2.Text);
                command.Parameters.AddWithValue("@Tur", comboBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.mALZEMETableAdapter1.Fill(this.oLUYORUM.MALZEME);

            }


            }

        private void button4_Click(object sender, EventArgs e)
        {


            string query = "DELETE FROM MALZEME WHERE Malzeme_ID=@Malzeme_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Malzeme_ID", textBox5.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.mALZEMETableAdapter1.Fill(this.oLUYORUM.MALZEME);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE MALZEME SET AD=@Ad,Stok=@Stok,Tur=@Tur WHERE Malzeme_ID=@Malzeme_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Stok", textBox2.Text);
                command.Parameters.AddWithValue("@Tur", comboBox1.Text);
                command.Parameters.AddWithValue("@Malzeme_ID", textBox5.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.mALZEMETableAdapter1.Fill(this.oLUYORUM.MALZEME);

            }

        }
    }
}

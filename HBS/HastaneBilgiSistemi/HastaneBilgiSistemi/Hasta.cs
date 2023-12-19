using HastaneBilgiSistemi.deniyoruzTableAdapters;
using HastaneBilgiSistemi.OLUYORUMTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneBilgiSistemi
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
           
            this.hASTATableAdapter1.Fill(this.oLUYORUM.HASTA);

        }

        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {



            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
       
                string query = "SELECT Ad FROM HASTA WHERE Hasta_ID = @ID";

           
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
             
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                   
                        command.Parameters.AddWithValue("@ID", arananID);

                        try
                        {
                           
                            connection.Open();

                            
                            object result = command.ExecuteScalar();

                           
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



            int arananSoyad;
            if (int.TryParse(textBox5.Text, out arananSoyad))
            {
                // SQL sorgusu
                string query = "SELECT Soyad FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananSoyad);

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


            int arananTC;
            if (int.TryParse(textBox5.Text, out arananTC))
            {
                // SQL sorgusu
                string query = "SELECT TC FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananTC);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox4.Text = result.ToString();
                            }
                            else
                            {
                                textBox4.Text = "ID bulunamadı";
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






            int arananTEL;
            if (int.TryParse(textBox5.Text, out arananTEL))
            {
                // SQL sorgusu
                string query = "SELECT Telefon FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananTEL);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                textBox8.Text = result.ToString();
                            }
                            else
                            {
                                textBox8.Text = "ID bulunamadı";
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




            int arananMail;
            if (int.TryParse(textBox5.Text, out arananMail))
            {
                // SQL sorgusu
                string query = "SELECT Mail FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananMail);

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


            int arananTarih;
            if (int.TryParse(textBox5.Text, out arananTarih))
            {
                // SQL sorgusu
                string query = "SELECT Dogum_Tarih FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananTarih);

                        try
                        {
                            // Bağlantıyı aç
                            connection.Open();

                            // Komutu çalıştır ve sonucu al
                            object result = command.ExecuteScalar();

                            // Sonucu textBox2'ye yaz
                            if (result != null)
                            {
                                dateTimePicker1.Value = Convert.ToDateTime(result);

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


     


            int arananKan;
            if (int.TryParse(textBox5.Text, out arananKan))
            {
                // Veritabanına bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    string query = "SELECT CASE WHEN HASTA.Kan_Grubu = '1' THEN '0 RH+'  WHEN HASTA.Kan_Grubu = '2' THEN '0 RH-' WHEN HASTA.Kan_Grubu = '3' THEN 'A RH+' WHEN HASTA.Kan_Grubu = '4' THEN 'A RH-' WHEN HASTA.Kan_Grubu = '5' THEN 'B RH+'WHEN HASTA.Kan_Grubu = '6' THEN 'B RH+' WHEN HASTA.Kan_Grubu = '7' THEN 'AB RH+' WHEN HASTA.Kan_Grubu = '8' THEN 'AB RH-'END AS Kan_Grubu FROM HASTA INNER JOIN KAN_GRUBU ON HASTA.Kan_Grubu = KAN_GRUBU.Kan_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@ID", arananKan);

                        // Veriyi oku
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Cinsiyet verisini al
                            string kan = reader["Kan_Grubu"].ToString();

                            // ComboBox'a ekle
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add(kan);
                            comboBox2.SelectedIndex = 0;
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



            int arananCinsiyet;
            if (int.TryParse(textBox5.Text, out arananCinsiyet))
            {
                // Veritabanına bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    string query = "SELECT CASE WHEN HASTA.Cinsiyet = '1' THEN 'Erkek' WHEN HASTA.Cinsiyet = '2' THEN 'Kadın'  END AS Cinsiyet FROM HASTA INNER JOIN CINSIYET ON HASTA.Cinsiyet = CINSIYET.Cinsiyet_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@ID", arananCinsiyet);

                        // Veriyi oku
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Cinsiyet verisini al
                            string cinsiyet = reader["Cinsiyet"].ToString();

                            // ComboBox'a ekle
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add(cinsiyet);
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



            int arananAdres;
            if (int.TryParse(textBox5.Text, out arananAdres))
            {
                // SQL sorgusu
                string query = "SELECT Adres FROM HASTA WHERE Hasta_ID = @ID";

                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekle
                        command.Parameters.AddWithValue("@ID", arananAdres);

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
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            string query = "INSERT INTO HASTA (Ad,Soyad,TC,Mail,Adres,Telefon,Dogum_Tarih,Kan_Grubu,Cinsiyet) VALUES (@Ad,@Soyad,@TC,@Mail,@Adres,@Telefon,@Dogum_Tarih,@Kan_Grubu,@Cinsiyet)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                command.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hASTATableAdapter1.Fill(this.oLUYORUM.HASTA);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            string query = "DELETE FROM HASTA WHERE Hasta_ID=@Hasta_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Hasta_ID", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hASTATableAdapter1.Fill(this.oLUYORUM.HASTA);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE HASTA SET Ad=@Ad,Soyad=Soyad,TC=@TC,Telefon=@Telefon,Mail=@Mail,Adres=@Adres,Dogum_Tarih=@Dogum_Tarih,Kan_Grubu=@Kan_Grubu,Cinsiyet=@Cinsiyet WHERE Hasta_ID=@Hasta_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                command.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                command.Parameters.AddWithValue("@Hasta_ID", textBox5.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hASTATableAdapter1.Fill(this.oLUYORUM.HASTA);

            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            pictureBox2.Image = barcode.Draw(textBox5.Text, 40);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}

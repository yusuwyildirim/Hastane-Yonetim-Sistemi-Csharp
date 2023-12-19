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

namespace HastaneBilgiSistemi
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load_1(object sender, EventArgs e)
        {
           
            this.dOKTORLARTableAdapter3.Fill(this.deniyoruz.DOKTORLAR);


        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {



            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
                
                string query = "SELECT Ad FROM DOKTORLAR WHERE Doktor_ID = @ID";

              
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
                string query = "SELECT Soyad FROM DOKTORLAR WHERE Doktor_ID = @ID";

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@ID", arananSoyad);

                        try
                        {
                           
                            connection.Open();

                          
                            object result = command.ExecuteScalar();

                            
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
              
                string query = "SELECT TC FROM DOKTORLAR WHERE Doktor_ID = @ID";

             
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
               
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    
                        command.Parameters.AddWithValue("@ID", arananTC);

                        try
                        {
                           
                            connection.Open();

                        
                            object result = command.ExecuteScalar();

                           
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
         
                string query = "SELECT Telefon FROM DOKTORLAR WHERE Doktor_ID = @ID";

              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                  
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@ID", arananTEL);

                        try
                        {
                          
                            connection.Open();

                       
                            object result = command.ExecuteScalar();

                           
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
              
                string query = "SELECT Mail FROM DOKTORLAR WHERE Doktor_ID = @ID";

               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                  
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananMail);

                        try
                        {
                       
                            connection.Open();

                        
                            object result = command.ExecuteScalar();

                          
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
              
                string query = "SELECT Dogum_Tarih FROM DOKTORLAR WHERE Doktor_ID = @ID";

              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananTarih);

                        try
                        {
                      
                            connection.Open();

                           
                            object result = command.ExecuteScalar();

                           
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



            int arananUnvan;
            if (int.TryParse(textBox5.Text, out arananUnvan))
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                 
                    string query = "SELECT Unvan FROM UNVAN WHERE Unvan_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananUnvan);

                     
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                        
                            string unvan = reader["Unvan"].ToString();

                           
                            comboBox3.Items.Clear();
                            comboBox3.Items.Add(unvan);
                            comboBox3.SelectedIndex = 0;
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




            int arananUzman;
            if (int.TryParse(textBox5.Text, out arananUzman))
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = "SELECT Uzmanlik FROM UZMANLIK WHERE Uzmanlik_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@ID", arananUzman);

                        
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                        
                            string uzman = reader["Uzmanlik"].ToString();

                         
                            comboBox4.Items.Clear();
                            comboBox4.Items.Add(uzman);
                            comboBox4.SelectedIndex = 0;
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


            int arananPolik;
            if (int.TryParse(textBox5.Text, out arananPolik))
            {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = "SELECT Ad FROM POLIKLINIK WHERE Poliklinik_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananPolik);

                        
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                         
                            string pol = reader["Ad"].ToString();

                          
                            comboBox5.Items.Clear();
                            comboBox5.Items.Add(pol);
                            comboBox5.SelectedIndex = 0;
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




            int arananKan;
            if (int.TryParse(textBox5.Text, out arananKan))
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT Kan_Grubu FROM KAN_GRUBU WHERE Kan_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@ID", arananKan);

                       
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                         
                            string kan = reader["Kan_Grubu"].ToString();

                           
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



            int arananCan;
            if (int.TryParse(textBox5.Text, out arananCan))
            {
        
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

            
                    string query = "SELECT  CASE         WHEN DOKTORLAR.Cinsiyet = '1' THEN 'Erkek'         WHEN DOKTORLAR.Cinsiyet = '2' THEN 'Kadın'    END AS Cinsiyet FROM     DOKTORLAR INNER JOIN     CINSIYET ON DOKTORLAR.Cinsiyet = CINSIYET.Cinsiyet_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@ID", arananCan);

                
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                        
                            string kcan = reader["Cinsiyet"].ToString();

                  
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add(kcan);
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
            
                string query = "SELECT Adres FROM DOKTORLAR WHERE Doktor_ID = @ID";

           
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
             
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    
                        command.Parameters.AddWithValue("@ID", arananAdres);

                        try
                        {
                         
                            connection.Open();

                          
                            object result = command.ExecuteScalar();

                           
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
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            string query = "INSERT INTO DOKTORLAR (Ad,Soyad,TC,Mail,Adres,Telefon,Dogum_Tarih,Uzmanlık,Unvan,Poliklinik,Cinsiyet,Kan_Grubu) VALUES (@Ad,@Soyad,@TC,@Mail,@Adres,@Telefon,@Dogum_Tarih,@Uzmanlık,@Unvan,@Poliklinik,@Cinsiyet,@Kan_Grubu)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Uzmanlık", comboBox3.Text);
                command.Parameters.AddWithValue("@Unvan", comboBox4.Text);
                command.Parameters.AddWithValue("@Poliklinik", comboBox5.Text);
                command.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.dOKTORLARTableAdapter3.Fill(this.deniyoruz.DOKTORLAR);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM DOKTORLAR WHERE Doktor_ID=@Doktor_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Doktor_ID", Convert.ToInt32(textBox5.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.dOKTORLARTableAdapter3.Fill(this.deniyoruz.DOKTORLAR);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            string query = "UPDATE DOKTORLAR SET Ad=@Ad,Soyad=@Soyad,TC=@TC,Mail=@Mail,Adres=@Adres,Telefon=@Telefon,Dogum_Tarih=@Dogum_Tarih,Uzmanlık=@Uzmanlık,Unvan=@Unvan,Poliklinik=@Poliklinik,Cinsiyet=@Cinsiyet,Kan_Grubu=@Kan_Grubu WHERE Doktor_ID=@Doktor_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Uzmanlık",comboBox3.Text);
                command.Parameters.AddWithValue("@Unvan", comboBox4.Text);
                command.Parameters.AddWithValue("@Poliklinik", comboBox5.Text);
                command.Parameters.AddWithValue("@Cinsiyet",comboBox1.Text);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                command.Parameters.AddWithValue("@Doktor_ID",textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.dOKTORLARTableAdapter3.Fill(this.deniyoruz.DOKTORLAR);

            }


        }
    }
}

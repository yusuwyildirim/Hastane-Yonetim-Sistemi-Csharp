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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneBilgiSistemi
{
    public partial class Hemsire : Form
    {
        public Hemsire()
        {
            InitializeComponent();
        }

        private void Hemsire_Load(object sender, EventArgs e)
        {

            this.hEMSIRETableAdapter1.Fill(this.oLUYORUM.HEMSIRE);

        }


        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";



        private void button1_Click(object sender, EventArgs e)
        {





            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
                
                string query = "SELECT Ad FROM HEMSIRE WHERE Hemsire_ID = @ID";

              
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
              
                string query = "SELECT Soyad FROM HEMSIRE WHERE Hemsire_ID = @ID";

              
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
                
                string query = "SELECT TC FROM HEMSIRE WHERE Hemsire_ID = @ID";

               
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
               
                string query = "SELECT Telefon FROM HEMSIRE WHERE Hemsire_ID = @ID";

               
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
               
                string query = "SELECT Mail FROM HEMSIRE WHERE Hemsire_ID = @ID";

               
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
               
                string query = "SELECT Dogum_Tarih FROM HEMSIRE WHERE Hemsire_ID = @ID";

               
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


            int arananPOLIK;
            if (int.TryParse(textBox5.Text, out arananPOLIK))
            {
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                  
                    string query = "SELECT CASE WHEN HEMSIRE.Poliklinik = '1' THEN 'Radyoloji' WHEN HEMSIRE.Poliklinik = '2' THEN 'Cildiye'WHEN HEMSIRE.Poliklinik = '3' THEN 'Dahiliye' WHEN HEMSIRE.Poliklinik = '4' THEN 'KBB' WHEN HEMSIRE.Poliklinik = '5' THEN 'Nöroloji' WHEN HEMSIRE.Poliklinik = '6' THEN 'Kardiyoloji' WHEN HEMSIRE.Poliklinik = '7' THEN 'Acil' END AS Poliklinik FROM HEMSIRE INNER JOIN POLIKLINIK ON HEMSIRE.Poliklinik = POLIKLINIK.Poliklinik_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananPOLIK);

                    
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                          
                            string poli = reader["Poliklinik"].ToString();

                           
                            comboBox5.Items.Clear();
                            comboBox5.Items.Add(poli);
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

               
                    string query = "SELECT CASE  WHEN HEMSIRE.Kan_Grubu = '1' THEN '0 RH+' WHEN HEMSIRE.Kan_Grubu = '2' THEN '0 RH-' WHEN HEMSIRE.Kan_Grubu = '3' THEN 'A RH+' WHEN HEMSIRE.Kan_Grubu = '4' THEN 'A RH-' WHEN HEMSIRE.Kan_Grubu = '5' THEN 'B RH+' WHEN HEMSIRE.Kan_Grubu = '6' THEN 'B RH+' WHEN HEMSIRE.Kan_Grubu = '7' THEN 'AB RH+' WHEN HEMSIRE.Kan_Grubu = '8' THEN 'AB RH-' END AS Kan_Grubu FROM HEMSIRE INNER JOIN    KAN_GRUBU ON HEMSIRE.Kan_Grubu = KAN_GRUBU.Kan_ID";
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



            int arananCinsiyet;
            if (int.TryParse(textBox5.Text, out arananCinsiyet))
            {
           
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = "SELECT CASE WHEN HEMSIRE.Cinsiyet = '1' THEN 'Erkek' WHEN HEMSIRE.Cinsiyet = '2' THEN 'Kadın'  END AS Cinsiyet FROM HEMSIRE INNER JOIN CINSIYET ON HEMSIRE.Cinsiyet = CINSIYET.Cinsiyet_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananCinsiyet);

                        
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                       
                            string cinsiyet = reader["Cinsiyet"].ToString();

                       
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
             
                string query = "SELECT Adres FROM HEMSIRE WHERE Hemsire_ID = @ID";

          
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
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO HEMSIRE (Ad,Soyad,TC,Mail,Telefon,Adres,Kan_Grubu,Cinsiyet,Dogum_Tarih,Poliklinik) VALUES (@Ad,@Soyad,@TC,@Mail,@Telefon,@Adres,@Kan_Grubu,@Cinsiyet,@Dogum_Tarih,@Poliklinik)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                command.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                command.Parameters.AddWithValue("@Poliklinik", comboBox5.Text);
               
                

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hEMSIRETableAdapter1.Fill(this.oLUYORUM.HEMSIRE);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM HEMSIRE WHERE Hemsire_ID=@Hemsire_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Hemsire_ID", textBox5.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hEMSIRETableAdapter1.Fill(this.oLUYORUM.HEMSIRE);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


            string query = "UPDATE HEMSIRE SET Ad=@Ad,Soyad=Soyad,TC=@TC,Mail=@Mail,Telefon=@Telefon,Adres=@Adres,Dogum_Tarih=@Dogum_Tarih,Kan_Grubu=@Kan_Grubu,Cinsiyet=@Cinsiyet,Poliklinik=@Poliklinik WHERE Hemsire_ID=@Hemsire_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox12.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
                command.Parameters.AddWithValue("@TC", textBox4.Text);
                command.Parameters.AddWithValue("@Mail", textBox3.Text);
                command.Parameters.AddWithValue("@Telefon", textBox8.Text);
                command.Parameters.AddWithValue("@Adres", textBox1.Text);
                command.Parameters.AddWithValue("@Dogum_Tarih", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Kan_Grubu", comboBox2.Text);
                command.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                command.Parameters.AddWithValue("@Poliklinik", comboBox5.Text);
                command.Parameters.AddWithValue("@Hemsire_ID", textBox5.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.hEMSIRETableAdapter1.Fill(this.oLUYORUM.HEMSIRE);
            }


        }
    }
}

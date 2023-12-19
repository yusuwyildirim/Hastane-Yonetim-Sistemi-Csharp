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
using System.Windows.Forms.PropertyGridInternal;

namespace HastaneBilgiSistemi
{
    public partial class Ameliyathane : Form
    {
        public Ameliyathane()
        {
            InitializeComponent();
        }

        private void Ameliyathane_Load(object sender, EventArgs e)
        {
  
            this.aMELIYATHANETableAdapter1.Fill(this.oLUYORUM.AMELIYATHANE);

        }

        private const string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True";



        private void button1_Click(object sender, EventArgs e)
        {



            int arananID;
            if (int.TryParse(textBox5.Text, out arananID))
            {
               
                string query = "SELECT Ameliyathane_Numara FROM AMELIYATHANE WHERE Ameliyathane_ID = @ID";

              
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


            int arananKat;
            if (int.TryParse(textBox5.Text, out arananKat))
            {
                
                string query = "SELECT Kat FROM AMELIYATHANE WHERE Ameliyathane_ID = @ID";

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@ID", arananKat);

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



            int arananDoluluk;
            if (int.TryParse(textBox5.Text, out arananDoluluk))
            {
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT Doluluk FROM AMELIYATHANE WHERE Ameliyathane_ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@ID", arananDoluluk);

                       
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                         
                            string dolu = reader["Doluluk"].ToString();

                            
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
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO AMELIYATHANE (Ameliyathane_Numara,Kat,Doluluk) VALUES (@Ameliyathane_Numara,@Kat,@Doluluk)";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ameliyathane_Numara", textBox12.Text);
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.aMELIYATHANETableAdapter1.Fill(this.oLUYORUM.AMELIYATHANE);

            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM AMELIYATHANE WHERE Ameliyathane_ID=@Ameliyathane_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ameliyathane_ID", Convert.ToInt32(textBox5.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.aMELIYATHANETableAdapter1.Fill(this.oLUYORUM.AMELIYATHANE);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE AMELIYATHANE SET Ameliyathane_Numara=@Ameliyathane_Numara,Kat=@Kat,Doluluk=@Doluluk WHERE Ameliyathane_ID=@Ameliyathane_ID";
            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ameliyathane_Numara", textBox12.Text);
                command.Parameters.AddWithValue("@Ameliyathane_ID", Convert.ToInt32(textBox5.Text));
                command.Parameters.AddWithValue("@Kat", textBox2.Text);
                command.Parameters.AddWithValue("@Doluluk", comboBox1.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.aMELIYATHANETableAdapter1.Fill(this.oLUYORUM.AMELIYATHANE);

            }


        }
    }
}

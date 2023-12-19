using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneBilgiSistemi
{
    internal class Class2
    {
        SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True");

        public List<Class1> tablolar {  get; set; } 

        private void GetClass1()
        {

          con.Open();
            SqlCommand cmd = new SqlCommand("INFORMATION_SCHEMA views", con);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read())
            {
                Class1 class1 = new Class1();
                class1.Doktorlar = dr[0].ToString();
                class1.Poliklinik = dr[1].ToString();
                class1.Personel_bolum = dr[2].ToString();
                class1.Personel = dr[3].ToString();
                class1.Ameliyathane = dr[4].ToString();
                class1.Hasta = dr[5].ToString();
                class1.Hemsire = dr[6].ToString();
                class1.Malzeme = dr[7].ToString();
                class1.Oda = dr[8].ToString();
                class1.Yogun_bakim = dr[9].ToString();

                tablolar.Add(class1);

            }
            
            dr.Close();
            con.Close();

        }
    }
}

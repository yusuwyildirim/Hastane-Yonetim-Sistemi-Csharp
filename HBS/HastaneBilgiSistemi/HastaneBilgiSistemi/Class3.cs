using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneBilgiSistemi
{
    class Class3
    {

        static void Maigirin(string[] args) //main
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=HBS;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    Console.WriteLine("Table Name : " + dr[0]);
                }
            }
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            if (con != null)
            {
                con.Close();
            }
            Console.ReadLine();
        }
    }
}


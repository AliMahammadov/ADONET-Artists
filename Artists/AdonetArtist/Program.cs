using System.Data;
using System.Data.SqlClient;

namespace AdonetArtist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ALI\\SQLEXPRESS;Database=Spotify; Trusted_Connection= True";


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{

            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("INSERT INTO Artists VALUES (N'Suret' ,N'Hesenov','11.01.1987','Kisi')", connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //}
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Artists", connection))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine(dr["ArtisName"]);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine(dr["SurName"]);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine(dr["Brithday"]);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine(dr["Gender"]);
                        Console.WriteLine("---------------------------------------------");
                    }
                }

            }
        }
    }
}
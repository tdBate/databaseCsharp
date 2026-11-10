using databaseCsharp;
using MySql.Data.MySqlClient;

namespace databaseCsharp;


public class Database
{
    public List<Diak> adatokBetoltese()
    {
        string connectionString = "server=localhost;database=diakok;uid=root;pwd=;";
        var diakok = new List<Diak>();
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "SELECT * from diakok";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Diak diak = new Diak(
                            reader["nev"].ToString(),
                            int.Parse(reader["eletkor"].ToString()),
                            reader["osztaly"].ToString(),
                            Double.Parse(reader["atlag"].ToString())
                        );

                        diakok.Add(diak);
                    }
                }
            }
        }
        return diakok;
    }
}
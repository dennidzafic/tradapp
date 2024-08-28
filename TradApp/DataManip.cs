using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradApp
{
  internal class DataManip
  {
    internal static int AddWordsToDb(Words words)
    {
      MySqlConnection connect = new MySqlConnection();
      connect.ConnectionString = "Server=localhost;Port=3306;Database=trad_app;Uid=root;Pwd=dbadmin;";

      MySqlCommand command = new MySqlCommand();
      command.Connection = connect;

      command.CommandText = "INSERT IGNORE INTO anglais " +
                            "VALUES (@fr, @en, @no_serie);";

      command.Parameters.AddWithValue("@fr", words.MotFr);
      command.Parameters.AddWithValue("@en", words.MotEn);
      command.Parameters.AddWithValue("@no_serie", words.Numero_serie);

      connect.Open();

      int rows_inserted = command.ExecuteNonQuery();

      connect.Close();

      return rows_inserted;
    }

    internal static Serie CreateSerie(int numero_serie)
    {
      MySqlConnection connect = new MySqlConnection();
      connect.ConnectionString = "Server=localhost;Port=3306;Database=trad_app;Uid=root;Pwd=dbadmin;";

      MySqlCommand command = new MySqlCommand();
      command.Connection = connect;

      command.CommandText = "SELECT mot_francais, mot_anglais FROM anglais " +
                            "WHERE numero_serie = @no_serie";

      command.Parameters.AddWithValue("@no_serie", numero_serie);

      Serie serie = new Serie(numero_serie);

      connect.Open();

      using (MySqlDataReader reader = command.ExecuteReader())
      {
        while(reader.Read())
        {
          Words word = new Words()
          {
            MotFr = reader.GetString("mot_francais"),
            MotEn = reader.GetString("mot_anglais"),
          };

          serie.SerieDeMots.Add(word);
        }
      }

      connect.Close();

      return serie;
    }
  }
}

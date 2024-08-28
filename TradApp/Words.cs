using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradApp
{
  public class Words
  {
    public string MotFr { get; set; } = null!;
    public string MotEn { get; set; } = null!;
    public int Numero_serie { get; set; }
    public int Flag = 0;

    public Words(string fr, string en, int no_serie)
    {
      MotFr = fr;
      MotEn = en;
      Numero_serie = no_serie;
    }

    public Words()
    {
      MotFr = "";
      MotEn = "";
    }
  }
}

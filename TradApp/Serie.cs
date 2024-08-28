using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradApp
{
  public class Serie
  {
    public int NumeroSerie { get; set; }
    public List<Words> SerieDeMots { get; set; }
    public Serie(int numeroSerie)
    {
      NumeroSerie = numeroSerie;
      SerieDeMots = new List<Words>();
    }
  }
}

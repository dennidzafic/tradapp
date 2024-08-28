using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradApp;

namespace TradApp.FORMS
{
  public partial class FormInterrogation : Form
  {
    public FormInterrogation()
    {
      InitializeComponent();
    }
    private void BoutonStart_Click(object sender, EventArgs e)
    {
      int numeroSerie = int.Parse(TxtNumeroSerie.Text);
      Serie serie = DataManip.CreateSerie(numeroSerie);

      if (serie.SerieDeMots.Count == 0)
      {
        MessageBox.Show("Votre liste est vide, entrez un numéro de liste valable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        TxtNumeroSerie.Clear();
      }
      else
      {
        Logique.BoucleDeJeu(serie);
        serie.SerieDeMots.Clear();
        Close();
      }
    }
    private void BoutonRetour_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}

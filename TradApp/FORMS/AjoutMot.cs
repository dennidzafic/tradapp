using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradApp.FORMS
{
  public partial class AjoutMot : Form
  {
    public AjoutMot()
    {
      InitializeComponent();
    }

    private void ExitAddMot_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ClearAll()
    {
      TxtMotFr.Clear();
      TxtMotEn.Clear();
      TxtSerie.Clear();
    }

    private void SubmitMot_Click(object sender, EventArgs e)
    {
      int no_serie = int.Parse(TxtSerie.Text);

      Words words_to_add = new Words(TxtMotFr.Text, TxtMotEn.Text, no_serie);
      if (DataManip.AddWordsToDb(words_to_add) == 0)
      {
        ClearAll();
        MessageBox.Show("Ce couple de mots existe déjà!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      else
      {
        ClearAll();
        ToolTip tooltip = new ToolTip();
        System.Drawing.Point location = new System.Drawing.Point(100, 100);
        tooltip.Show("Mot ajouté avec succès", this, location, 2000);
      }
    }
  }
}

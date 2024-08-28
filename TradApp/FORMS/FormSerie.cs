using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradApp.FORMS
{
  public partial class FormSerie : Form
  {
    private Words wordsToTest;
    public bool Success { get; private set; }
    public FormSerie(Words words, string noSerie)
    {
      InitializeComponent();
      Text = "Série numéro " + noSerie;
      labelATrad.Text = words.MotFr;
      wordsToTest = words;
    }

    private void BoutonValider_Click(object sender, EventArgs e)
    {
      if(TxtTraduction.Text.Equals(wordsToTest.MotEn))
      {
        MessageBox.Show("La traduction est bonne!", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Success = true;
      }
      else
      {
        MessageBox.Show("Mauvaise traduction, la réponse était: " + wordsToTest.MotEn, "Gros nul", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Success = false;
      }
      Close();
    }
  }
}

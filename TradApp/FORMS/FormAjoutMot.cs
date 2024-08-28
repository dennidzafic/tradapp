using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradApp.FORMS;

namespace TradApp
{
  public partial class FormAjoutMot : Form
  {
    public FormAjoutMot()
    {
      InitializeComponent();
    }
    private void ComboBoxLangues_SelectedIndexChanged(object sender, EventArgs e)
    {
      string langueChoisie = comboBoxLangues.SelectedItem.ToString().ToLower();

      if (langueChoisie is not null && langueChoisie.Equals("anglais"))
      {
        AjoutMot ajoutMot = new AjoutMot();
        ajoutMot.ShowDialog();
      }
    }

    private void BoutonRetourMenu_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}

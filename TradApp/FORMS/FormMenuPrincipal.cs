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
  public partial class FormMenuPrincipal : Form
  {
    public FormMenuPrincipal()
    {
      InitializeComponent();
    }

    private void BoutonCommencerSerie_Click(object sender, EventArgs e)
    {
      Hide();
      FormInterrogation formInterrogation = new FormInterrogation();
      formInterrogation.ShowDialog();
      Show();
    }
    private void BoutonAddMot_Click(object sender, EventArgs e)
    {
      Hide();
      FormAjoutMot formAjoutMot = new FormAjoutMot();
      formAjoutMot.ShowDialog();
      Show();
    }
    private void BoutonExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }   
  }
}

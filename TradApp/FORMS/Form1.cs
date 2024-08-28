using MySql.Data.MySqlClient;

namespace TradApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ButtonToMenu_Click(object sender, EventArgs e)
    {
      FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
      menuPrincipal.Show();
      Hide();
    }
  }
}

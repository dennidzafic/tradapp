using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TradApp.FORMS;

namespace TradApp
{
  internal class Logique
  {
    private static void Shuffle<T>(List<T> list)
    {
      Random random = new Random();
      int n = list.Count;
      while (n > 1)
      {
        n--;
        int k = random.Next(n + 1);
        T value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }
    public static void BoucleDeJeu(Serie serie_en_cours)
    {
      int noSerie = serie_en_cours.NumeroSerie;
      List<Words> serieDeMots = serie_en_cours.SerieDeMots;
      List<Words> listeSecondaire = new List<Words>();
      int indexReussi = 0;
      int totalMot = serieDeMots.Count;

      while (indexReussi != totalMot)
      {
        Shuffle(serieDeMots);

        foreach (Words word in serieDeMots)
        {
          if (word.Flag == 0)
            listeSecondaire.Add(word);
        }

        for (int dI = 0; dI < listeSecondaire.Count; dI++)
        {
          FormSerie formSerie = new FormSerie(listeSecondaire[dI], noSerie.ToString());
          formSerie.ShowDialog();

          if (formSerie.Success)
          {
            indexReussi++;
            listeSecondaire[dI].Flag = 1;
            foreach (Words word in serieDeMots)
            {
              if (listeSecondaire[dI].MotFr == word.MotFr && listeSecondaire[dI].Flag == 1)
                word.Flag = 1;
            }
          }
        }

        listeSecondaire.Clear();

        MessageBox.Show("Vous avez fait " + indexReussi + "/" + totalMot, "Score", MessageBoxButtons.OK);
        if (indexReussi != totalMot)
        {
          var result = MessageBox.Show("Voulez-vous rejouer les mots que vous n'avez pas trouvé ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          
          if (result == DialogResult.No)
          {
            indexReussi = totalMot;
          }
        }
        else
        {
          MessageBox.Show("Vous êtes parvenu à terminer la série, bravo!", "Wou-hou");
        }

      }     
    }
  }
}

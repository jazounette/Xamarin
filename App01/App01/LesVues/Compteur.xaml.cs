using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01.LesVues {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class Compteur : ContentPage {
      public int comptage = 0;
      public Compteur() {
         InitializeComponent();
      }
      private void BoutonClique(object sender, EventArgs e) {
         //DisplayAlert("test", "le cliquamarché", "OK");
         comptage++;
         AffCompteur.Text = comptage.ToString();
      }

      private void BoutonClique02(object sender, EventArgs e) {
         comptage--;
         AffCompteur.Text = comptage.ToString();

      }
   }
}
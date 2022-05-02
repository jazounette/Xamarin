using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App03 {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class Résultat : ContentPage {
      public Résultat(int nbrMage, bool gagne) {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, true);
         Title = "Résultat";
         AffNbrMag.Text += nbrMage;
         limage.IsVisible = gagne;
         cestlaloose.IsVisible = !gagne;
         letitre.Text = gagne ? "VICTOIRE" : "PERDOU";
      }

      private async void BoutMaison(object sender, EventArgs e) {
         await Navigation.PopToRootAsync();
      }
   }
}
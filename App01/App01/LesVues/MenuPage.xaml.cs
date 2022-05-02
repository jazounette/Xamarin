using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01.LesVues {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class MenuPage : ContentPage {
      public MenuPage() {
         InitializeComponent();
      }

      private void BouttonLancerCompteur(object sender, EventArgs e) {
         Navigation.PushAsync(new Compteur());
      }
      private void BouttonLancerListe(object sender, EventArgs e) {
         Navigation.PushAsync(new Liste());
      }
   }
}
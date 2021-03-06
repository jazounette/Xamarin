using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App03 {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class JeJoue : ContentPage {
      private Random thierryHazard = new Random();
      private int nbrMage;
      private int score = 20;

      public JeJoue() {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, true);
         Title = "Je Joue";
         nbrMage = thierryHazard.Next(1,100);
         resultat.Text = $"Score : {score}";
      }

      private async void Gérationage() {
         int tartInt;
         if (Int32.TryParse(tartiflette.Text, out tartInt))
            if (tartInt == nbrMage) {
               resultat.Text = $"C'est GAGNÉ - Score: {score}";
               await Navigation.PushAsync(new Résultat(nbrMage, true, score), true);//c'est gagné
            } else if (tartInt > nbrMage) {
               score--;
               resultat.Text = $"C'est trop GRAND - Score: {score}";
            } else if (tartInt < nbrMage) {
               score--;
               resultat.Text = $"C'est trop PETIT - Score: {score}";
            } else resultat.Text = "ratatouille";

         if (score <= 0) await Navigation.PushAsync(new Résultat(nbrMage, false, score), true);//c'est perdu, score = 0

         triche.Text = $"triche {nbrMage}";

      }
      private void BoutValider(object sender, EventArgs e) {
         Gérationage();
         //await Navigation.PushAsync(new Résultat(nbrMage), true);//true pour les animations
      }
      private void TartiCompleted(object sender, EventArgs e) {
         Gérationage();
      }
   }
}
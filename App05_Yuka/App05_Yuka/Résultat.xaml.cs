using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_Yuka {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class Résultat : ContentPage {
      public Résultat(Données D) {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, true);
         Title = "RÉSULTAT";

         ingrédient.Text = $"Ingrédients: {D.product.ingredients_text_debug}";
         //allergies.Text = $"Allergies: {D.product.ingredients_text_with_allergens}";
         nutriscore.Text = $"Nutri-Score: {D.product.nutriscore_grade}";
         produit.Text = $"Produit: {D.product.product_name}";
         codeNRA.Text = $"codeNRA: {D.code}";
         fabriquant.Text = $"Fabriquant: {D.product.brands}";
         quantité.Text = $"quantité: {D.product.quantity}";

         switch (D.product.nutriscore_grade) {
            case "a": scoreA.Padding = 28; break;
            case "b": scoreB.Padding = 28; break;
            case "c": scoreC.Padding = 28; break;
            case "d": scoreD.Padding = 28; break;
            case "e": scoreE.Padding = 28; break;
         }



      }

      private async void GotoMain(object sender, EventArgs e) {
         await Navigation.PopAsync();
      }
   }
}
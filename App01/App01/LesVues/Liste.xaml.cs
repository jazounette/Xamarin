using App01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01.LesVues {
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class Liste : ContentPage {
      List<Article> articles;
      public Liste() {
         InitializeComponent();
         articles = new List<Article>();
         articles.Add(new Article() { Nom="Lait", Prix="9€99", Description="une bouteille de lait" } );
         articles.Add(new Article() { Nom="Pinard", Prix="11€99", Description="un litron de rouge" } );
         articles.Add(new Article() { Nom="CocaCola", Prix="8€99", Description="du cakilack" } );
         articles.Add(new Article() { Nom="Chinay", Prix="1€49", Description="une bonne petite biere" } );

         //maListView.ItemsSource = 
      }
   }
}
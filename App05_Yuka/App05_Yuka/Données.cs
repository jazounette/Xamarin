using System;
using System.Collections.Generic;
using System.Text;

namespace App05_Yuka {
   public class Données {
      public string code { get; set; }//le code NRA
      public int status { get; set; }//0: pas trouvé  //1: trouvé
      public Product product { get; set; }

      public class Product {
         public string brands { get; set; }//la marque qui fabrique
         public string ingredients_text_debug { get; set; }// liste des ingrédients dans une seul chaine
         public string ingredients_text_with_allergens { get; set; }// chaine avec la liste des allergenes
         public string nutriscore_grade { get; set; }//score nutritionel ABCDE
         public string product_name { get; set; }//le nom du produit
         public string quantity { get; set; }//quantité
      }
   }
}

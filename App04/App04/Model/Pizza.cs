using System;
using System.Collections.Generic;
using System.Text;
using App04.Model.Extension;

namespace App04.Model {
   class Pizza {
      public string nom { get; set; }
      public double prix { get; set; }
      public string[] ingrédients { get; set; }
      public string imageURL { get; set; }

      public string PrixEuros { get { return prix + "€"; } }
      public string IngredStr { get { return String.Join(", " , ingrédients); } }

      public string Titre { get { return nom.PremièreLettreMajuscule(); } }
   }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace App04.Model.Extension {
   public static class Extension {
      public static string PremièreLettreMajuscule(this string machaine) {
         if (String.IsNullOrEmpty(machaine)) return machaine;
         string retour = machaine.ToLower();
         retour = retour.Substring(0, 1).ToUpper() + retour.Substring(1, retour.Length - 1);
         return retour;
      }
   }
}

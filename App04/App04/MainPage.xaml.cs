using App04.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App04 {
   public partial class MainPage : ContentPage {
      List<Pizza> pizzaz;
      public MainPage() {
         InitializeComponent();

         pizzaz = new List<Pizza>();

         const string URL = "https://mohamed-bucket-soft.s3.eu-west-3.amazonaws.com/pizzas_app_1.json";

         //string pizzaJSON = "metre ici la longue chaine qui vien du site après convertion du json en chaine";

         //pizzaz.Add (new Pizza { nom = "marguarita", prix = 9.99, ingrédients = new string[] {"saucisson", "pamplemousse", "courgette" }, imageURL= "https://www.simplyrecipes.com/thmb/1KOEQ0SPZNXwU0pUXUDdAm6Z7xo=/2001x2001/smart/filters:no_upscale()/Simply-Recipes-Homemade-Pizza-Dough-Lead-Shot-1c-c2b1885d27d4481c9cfe6f6286a64342.jpg" });
         //pizzaz.Add (new Pizza { nom = "carnivooore", prix = 11.49, ingrédients = new string[] {"poulet", "cheval", "mouton", "chevre", "canard", "grenouille", "autruche" }, imageURL= "" });

         string pizzaJSON = "";
         using (var webclient = new WebClient()) {//using system.net
            try {
               pizzaJSON = webclient.DownloadString(URL);
            } catch (Exception ex) {
               DisplayAlert("Erreur", "erreur réseau: " + ex.Message, "OK");
               return;
            }
         }
         pizzaz = JsonConvert.DeserializeObject<List<Pizza>>(pizzaJSON);

         listView.ItemsSource = pizzaz;
      }
   }
}

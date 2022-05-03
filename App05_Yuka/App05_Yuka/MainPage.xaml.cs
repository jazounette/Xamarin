using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App05_Yuka {
   public partial class MainPage : ContentPage {
      Données Donnééémoi;
      public MainPage() {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, true);
         Title = "SCANNER";


         codeEAN.Text = "3560070936106";/////////////////test avec les biscuits choco
         listcode.Text = "3560070936106 biscuit choco\n";
         listcode.Text += "3168930009450 twinuts nature\n";
         listcode.Text += "3242273050659 pizza sodebo\n";

      }

      private async void GotoRésultat(object sender, EventArgs e) {
         Donnééémoi = new Données();

         var uri = new UriBuilder("https://world.openfoodfacts.org/api/v0/product/" + codeEAN.Text).Uri;
         var client = new WebClient();
         ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback ( delegate { return true; } );
         string content = client.DownloadString(uri);

         //string donnéééJSON = "";
         //using (var webclient = new WebClient()) {//using system.net
         //   try {
         //      donnéééJSON = webclient.DownloadString("https://world.openfoodfacts.org/api/v0/product/3560070936106");
         //   } catch (Exception ex) {
         //      DisplayAlert("Erreur", "erreur réseau: " + ex.Message, "OK");
         //      //return;
         //   }
         //}
         ///////////////////////////////////// WebClient error: trustFailure (authentication failed, see inner exception.)

         Donnééémoi = JsonConvert.DeserializeObject<Données>(content);
         debug.Text = Donnééémoi.status.ToString();

         if (Donnééémoi.status == 1) await Navigation.PushAsync(new Résultat(Donnééémoi), true);
         else await DisplayAlert("Erreur", "Code NRA non trouvé", "OK");

      }
   }
}

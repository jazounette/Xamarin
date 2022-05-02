﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03 {
   public partial class MainPage : ContentPage {
      public MainPage() {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, true);
         Title = "Maison";
      }

      private async void BoutDémarrer(object sender, EventArgs e) {
         await Navigation.PushAsync(new JeJoue(), true);//true pour les animations
      }
   }
}

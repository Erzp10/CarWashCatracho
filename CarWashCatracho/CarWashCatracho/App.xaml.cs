﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWashCatracho
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Facturacion());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

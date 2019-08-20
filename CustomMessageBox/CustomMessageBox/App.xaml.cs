﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMessageBox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Este NavigationPage, es para que pueda navegar entre paginas
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

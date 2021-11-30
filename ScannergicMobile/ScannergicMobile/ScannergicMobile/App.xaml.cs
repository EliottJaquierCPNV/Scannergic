
using ScannergicMobile.Models;
using ScannergicMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannergicMobile
{
    public partial class App : Application
    {
        /// <summary>
        /// Principal Entry point
        /// </summary>
        public App()
        {
            InitializeComponent();
            AppManager.Init();
            MainPage = new AppShell();
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

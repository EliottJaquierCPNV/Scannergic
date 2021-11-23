
using ScannergicMobile.Models;
using ScannergicMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannergicMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            AppManager.Init();
            for (int i = 0; i < 100; i++)
            {
                AppManager.Me.AddAllergen(new Allergen(i,"Allergène "+i));;
            }
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

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScannergicMobile.ViewModels
{ 
    public class AllergicHome : BaseViewModel
    {
        public Command AddAllergen { get; }
        public AllergicHome()
        {
            Title = "Allergies";
            AddAllergen = new Command(ShowAddAllergen);
        }
        void ShowAddAllergen()
        {

        }
    }
}

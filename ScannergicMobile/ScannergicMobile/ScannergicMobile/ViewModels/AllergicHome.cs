using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ScannergicMobile.Models;
using System.Threading.Tasks;

namespace ScannergicMobile.ViewModels
{ 
    public class AllergicHome : BaseViewModel
    {
        public Command ShowAddAllergenPageCommand { get; }
        public ObservableCollection<Item> Allergens { get; }
        public Command LoadAllergensCommand { get; }
        //public Command<Item> ItemTapped { get; }

        public AllergicHome()
        {
            Title = "Allergies";
            ShowAddAllergenPageCommand = new Command(ShowAddAllergen);
            Allergens = new ObservableCollection<Item>();
            Item it = new Item();
            it.Text = "Hee";
            Allergens.Add(it);
            Allergens.Add(it);
            LoadAllergensCommand = new Command(async () => await ExecuteLoadAllergens());
            /*
            ItemTapped = new Command<Item>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);*/
        }
        async Task ExecuteLoadAllergens()
        {

        }
        void ShowAddAllergen()
        {

        }
    }
}

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
        public ObservableCollection<Item> Allergens { get; set; }
        public Command LoadAllergensCommand { get; }
        public Command<Item> ItemTapped { get; }

        public AllergicHome()
        {
            Title = "Allergies";
            ShowAddAllergenPageCommand = new Command(ShowAddAllergen);
            Allergens = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
            {
                Item it = new Item();
                it.Text = "Un item";
                Allergens.Add(it);
            }

            LoadAllergensCommand = new Command(async () => await ExecuteLoadAllergens());
            
            ItemTapped = new Command<Item>(OnItemSelected);

            //AddItemCommand = new Command(OnAddItem);*/
        }

        private void OnItemSelected(Item obj)
        {
            IsBusy = true;
            int index = Allergens.IndexOf(obj);
            obj.Text = "A";
            Allergens[index] = obj;
            //UpdateList();
        }

        async Task ExecuteLoadAllergens()
        {
            IsBusy = true;
        }
        void ShowAddAllergen()
        {
            //await Shell.Current.GoToAsync("//AllergenAddView");
        }
    }
}

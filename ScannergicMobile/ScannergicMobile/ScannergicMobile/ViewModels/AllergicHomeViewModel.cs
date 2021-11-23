using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ScannergicMobile.Models;
using System.Threading.Tasks;

namespace ScannergicMobile.ViewModels
{ 
    public class AllergicHomeViewModel : BaseViewModel
    {
        public Command ShowAddAllergenPageCommand { get; }
        public ObservableCollection<Allergen> Allergens { get; set; }
        public Command LoadAllergensCommand { get; }
        public Command<Allergen> AllergenTapped { get; }

        public AllergicHomeViewModel()
        {
            Title = "Allergies";
            ExecuteLoadAllergens();
            LoadAllergensCommand = new Command(ExecuteLoadAllergens);
            ShowAddAllergenPageCommand = new Command(async () => await ShowAddAllergen());
            AllergenTapped = new Command<Allergen>(OnAllergenSelected);
        }

        private void OnAllergenSelected(Allergen obj)
        {
            //int index = Allergens.IndexOf(obj);
            Allergens.Remove(obj);
            AppManager.Me.Allergens = new List<Allergen>(Allergens);
            //Allergens[index] = obj;
            //UpdateList();
        }
        void ExecuteLoadAllergens()
        {
            IsBusy = true;
            Allergens = new ObservableCollection<Allergen>(AppManager.Me.Allergens);
            IsBusy = false;
        }
        async Task ShowAddAllergen()
        {
            await Shell.Current.GoToAsync("//AllergenAddView");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ScannergicMobile.Models;
using System.Threading.Tasks;

namespace ScannergicMobile.ViewModels
{ 
    /// <summary>
    /// The ViewModel of the Home Page
    /// </summary>
    public class AllergicHomeViewModel : BaseViewModel
    {
        private ObservableCollection<Allergen> allergens;

        /// <summary>
        /// Get current allergens of an allergic
        /// </summary>
        public ObservableCollection<Allergen> Allergens
        {
            get { return allergens; }
            set { SetProperty(ref allergens, value); }
        }

        /// <summary>
        /// Call this to Show the add page
        /// </summary>
        public Command ShowAddAllergenPageCommand { get; }

        /// <summary>
        /// Call this to refresh allergens in the list
        /// </summary>
        public Command LoadAllergensCommand { get; }

        /// <summary>
        /// Call this when allergen has been clicked
        /// </summary>
        public Command<Allergen> AllergenTapped { get; }

        /// <summary>
        /// When the page load the first time, initialize display (and commands)
        /// </summary>
        public AllergicHomeViewModel()
        {
            Title = "Allergies";
            LoadAllergensCommand = new Command(ExecuteLoadAllergens);
            ShowAddAllergenPageCommand = new Command(async () => await ShowAddAllergen());
            AllergenTapped = new Command<Allergen>(OnAllergenSelected);
        }

        /// <summary>
        /// When the page is displayed (used for refreshing)
        /// </summary>
        public void OnAppearing()
        {
            ExecuteLoadAllergens();
        }

        private void OnAllergenSelected(Allergen obj)
        {
            AppManager.Me.RemoveAllergen(obj);
            ExecuteLoadAllergens();
        }
        private void ExecuteLoadAllergens()
        {
            IsBusy = true;
            Allergens = new ObservableCollection<Allergen>(AppManager.Me.Allergens);
            IsBusy = false;
        }
        private async Task ShowAddAllergen()
        {
            await Shell.Current.GoToAsync("//AllergenAddView");
        }
    }
}

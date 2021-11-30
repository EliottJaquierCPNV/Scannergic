using ScannergicMobile.Models;
using ScannergicMobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScannergicMobile.ViewModels
{
    /// <summary>
    /// The ViewModel of the Add Allergen View
    /// </summary>
    public class AllergicAddViewModel : BaseViewModel
    {
        private ObservableCollection<Allergen> allergens;
        /// <summary>
        /// Get all allergens list
        /// </summary>
        public ObservableCollection<Allergen> Allergens
        {
            get { return allergens; }
            set { SetProperty(ref allergens, value); }
        }

        /// <summary>
        /// Call this to refresh the list
        /// </summary>
        public Command LoadAllergensCommand { get; }

        /// <summary>
        /// Call this to return to home page
        /// </summary>
        public Command ShowAllergicHomeViewCommand { get; }

        /// <summary>
        /// Call this when an allergen has been clicked 
        /// </summary>
        public Command<Allergen> AllergenTapped { get; }

        /// <summary>
        /// When the page load the first time, initialize display (and commands)
        /// </summary>
        public AllergicAddViewModel()
        {
            Title = "Ajouter une allergie";
            LoadAllergensCommand = new Command(ExecuteLoadAllergens);
            AllergenTapped = new Command<Allergen>(OnAllergenSelected);
            ShowAllergicHomeViewCommand = new Command(ShowAllergicHomeView);
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
            AppManager.Me.AddAllergen(obj);
            ShowAllergicHomeView();
        }
        private void ExecuteLoadAllergens()
        {
            IsBusy = true;
            ApiRequest api = new ApiRequest();
            List<Allergen> allergens = api.GetAllAllergens();
            Allergens = new ObservableCollection<Allergen>(allergens);
            IsBusy = false;
        }
        private void ShowAllergicHomeView()
        {
            Shell.Current.GoToAsync("//AllergicHomeView");
        }
    }
}

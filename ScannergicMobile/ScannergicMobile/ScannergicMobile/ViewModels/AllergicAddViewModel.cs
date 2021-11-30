using Newtonsoft.Json;
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
            LoadAllergensCommand = new Command(StartLoadAllergensAsync);
            AllergenTapped = new Command<Allergen>(OnAllergenSelected);
            ShowAllergicHomeViewCommand = new Command(ShowAllergicHomeView);
        }

        /// <summary>
        /// When the page is displayed (used for refreshing)
        /// </summary>
        public void OnAppearing()
        {
            StartLoadAllergensAsync();
        }

        private void StartLoadAllergensAsync()
        {
            Task t = ExecuteLoadAllergensAsync();
        }

        private void OnAllergenSelected(Allergen obj)
        {
            AppManager.Me.AddAllergen(obj);
            ShowAllergicHomeView();
        }
        private async Task ExecuteLoadAllergensAsync()
        {
            IsBusy = true;
            ApiRequest api = new ApiRequest();
            try
            {
                List<Allergen> allergens = await api.GetAllAllergensAsync();
                Allergens = new ObservableCollection<Allergen>(allergens);
            }
            catch (ApiRequestException exception){
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Le serveur n'a pas autorisé la connexion!", "Ok");
            }
            catch(JsonException exception)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Le résultat que le serveur a renvoyé n'était pas attendu!", "Ok");
            }catch(Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Une erreur s'est produite :"+e.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private void ShowAllergicHomeView()
        {
            Shell.Current.GoToAsync("//AllergicHomeView");
        }
    }
}

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
    /// The ViewModel of the ScanResult page
    /// </summary>
    public class ScanResultViewModel : BaseViewModel
    {
        /// <summary>
        /// Call this to return to home page
        /// </summary>
        public Command ShowAllergicHomeViewCommand { get; }

        private ObservableCollection<Allergen> allergensInProduct;
        /// <summary>
        /// Get all allergens list
        /// </summary>
        public ObservableCollection<Allergen> AllergensInProduct
        {
            get { return allergensInProduct; }
            set { SetProperty(ref allergensInProduct, value); }
        }

        private string barcode;
        /// <summary>
        /// The string barcode of the previous scan
        /// </summary>
        public string Barcode
        {
            get { return barcode; }
            set { SetProperty(ref barcode, value);}
        }

        private bool isWaiting;
        /// <summary>
        /// Is the page waiting to get the product infos
        /// </summary>
        public bool IsWaiting
        {
            get { return isWaiting; }
            set { SetProperty(ref isWaiting, value); }
        }

        private bool hasProductInfos;
        /// <summary>
        /// Is the product found in the API and has correct infos ?
        /// </summary>
        public bool HasProductInfos
        {
            get { return hasProductInfos; }
            set { SetProperty(ref hasProductInfos, value); }
        }

        private bool isProductNotFound;
        /// <summary>
        /// Is the product failed to get in the backend ?
        /// </summary>
        public bool IsProductNotFound
        {
            get { return isProductNotFound; }
            set { SetProperty(ref isProductNotFound, value); }
        }

        private bool isProductOK;
        /// <summary>
        /// Is the product OK for the current allergic ?
        /// </summary>
        public bool IsProductOK
        {
            get { return isProductOK; }
            set { SetProperty(ref isProductOK, value); }
        }

        public ScanResultViewModel()
        {
            IsWaiting = true;
            hasProductInfos = false;
            IsProductNotFound = false;
            Title = "Résultat du scan";
            ShowAllergicHomeViewCommand = new Command(ShowAllergicHomeView);
        }
        /// <summary>
        /// Update the page with a new scan of a barcode
        /// </summary>
        /// <param name="barcode">The new EAN13 barcode in string</param>
        public void UpdateScan(string barcode)
        {
            IsWaiting = true;
            Barcode = barcode;
            _ = ExecuteLoadAllergensAsync();
        }
        private async Task ExecuteLoadAllergensAsync()
        {
            IsWaiting = true;
            ApiRequest api = new ApiRequest();
            try
            {
                //TODO : API
                //List<Allergen> allAllergens = await api.GetAllergensInProduct(barcode);
                List<Allergen> allAllergens = new List<Allergen>();
                allAllergens.Add(new Allergen(1, "AA"));
                allAllergens.Add(new Allergen(3, "CC"));

                HasProductInfos = true;
                IsProductNotFound = false;
                List<Allergen> problematicAllergens = AppManager.Me.FindProblematicAllergens(allAllergens);
                IsProductOK = problematicAllergens.Count == 0;
                AllergensInProduct = new ObservableCollection<Allergen>(allAllergens);
            }
            catch (ServerException)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Le serveur n'a pas autorisé la connexion!", "Ok");
            }
            catch (ResourceNotFoundException)
            {
                HasProductInfos = false;
                IsProductNotFound = true;
                AllergensInProduct = new ObservableCollection<Allergen>();
            }
            catch (JsonException)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Le résultat que le serveur a renvoyé n'était pas attendu!", "Ok");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur!", "Une erreur s'est produite :" + e.Message, "Ok");
            }
            finally
            {
                IsWaiting = false;
            }
        }
        private void ShowAllergicHomeView()
        {
            Shell.Current.GoToAsync("//AllergicHomeView");
        }
    }
}

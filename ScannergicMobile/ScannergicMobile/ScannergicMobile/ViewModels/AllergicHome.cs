using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ScannergicMobile.Models;

namespace ScannergicMobile.ViewModels
{ 
    public class AllergicHome : BaseViewModel
    {
        public Command AddAllergen { get; }

        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command<Item> ItemTapped { get; }

        public AllergicHome()
        {
            Title = "Allergies";
            AddAllergen = new Command(ShowAddAllergen);

            /*Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Item>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);*/
        }
        void ShowAddAllergen()
        {

        }
    }
}

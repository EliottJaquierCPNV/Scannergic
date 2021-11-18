using ScannergicMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScannergicMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
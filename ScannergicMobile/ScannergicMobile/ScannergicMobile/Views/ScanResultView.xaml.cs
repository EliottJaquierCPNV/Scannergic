using ScannergicMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannergicMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(BarcodeProp), "barcode")]
    public partial class ScanResultView : ContentPage
    {
        public string BarcodeProp
        {
            set { ((ScanResultViewModel)BindingContext).UpdateScan(value); }
        }

        public ScanResultView()
        {
            InitializeComponent();
            BindingContext = new ScanResultViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
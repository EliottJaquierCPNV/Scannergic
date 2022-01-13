﻿using ScannergicMobile.ViewModels;
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
    public partial class ProductScan : ContentPage
    {
        
        public ProductScan()
        {
            InitializeComponent();
            BindingContext = new ProductScanViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((ProductScanViewModel)BindingContext).OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((ProductScanViewModel)BindingContext).OnDisappearing();
        }

        void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() => {
                if(result.BarcodeFormat == ZXing.BarcodeFormat.EAN_13)
                {
                //DisplayAlert("Scanné!", result.Text+" type:"+result.BarcodeFormat.ToString());
                Shell.Current.GoToAsync("//ScanResultView?barcode="+ result.Text);
                //Navigation.PushAsync(new ScanResultView());
                }
            });
        }

        private void DisplayAlert(string v1, string v2)
        {
            base.DisplayAlert(v1,v2,"OK");
        }
    }
}
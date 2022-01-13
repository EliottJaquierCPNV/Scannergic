using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScannergicMobile.ViewModels
{
    /// <summary>
    /// The ViewModel of ProductScan page
    /// </summary>
    public class ProductScanViewModel : BaseViewModel
    {
        private bool isScanning;
        /// <summary>
        /// Is the phone actually analysing the image (high CPU cost)
        /// </summary>
        public bool IsScanning
        {
            get { return isScanning; }
            set { SetProperty(ref isScanning, value); }
        }
        /// <summary>
        /// Init the page created
        /// </summary>
        public ProductScanViewModel()
        {
            Title = "Scanner le produit";
        }
        /// <summary>
        /// Activate properties when the page is on screen
        /// </summary>
        public void OnAppearing()
        {
            IsScanning = true;
        }
        /// <summary>
        /// Disable properties when the page is not on screen
        /// </summary>
        public void OnDisappearing()
        {
            IsScanning = false;
        }
    }
}

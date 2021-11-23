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
    public partial class AllergenAddView : ContentPage
    {
        public AllergenAddView()
        {
            InitializeComponent();
            BindingContext = new AllergicAddViewModel();
        }
    }
}
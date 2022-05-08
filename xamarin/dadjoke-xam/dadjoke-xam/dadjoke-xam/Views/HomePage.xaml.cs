using System.ComponentModel;
using Xamarin.Forms;
using dadjoke_xam.ViewModels;
using System;

namespace dadjoke_xam.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            // connect to ViewModel
            BindingContext = new HomeViewModel();

        }
    }
}

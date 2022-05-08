using System;
using System.Collections.Generic;
using dadjoke_xam.ViewModels;
using dadjoke_xam.Views;
using Xamarin.Forms;

namespace dadjoke_xam
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}


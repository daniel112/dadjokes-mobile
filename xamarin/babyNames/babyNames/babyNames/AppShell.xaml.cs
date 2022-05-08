using System;
using System.Collections.Generic;
using babyNames.ViewModels;
using babyNames.Views;
using Xamarin.Forms;

namespace babyNames
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}


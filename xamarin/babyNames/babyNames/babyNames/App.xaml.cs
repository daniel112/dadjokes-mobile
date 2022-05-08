using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using babyNames.Services;
using babyNames.Views;

namespace babyNames
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}


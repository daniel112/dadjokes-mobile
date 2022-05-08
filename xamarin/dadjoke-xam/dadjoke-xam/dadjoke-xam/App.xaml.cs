using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using dadjoke_xam.Services;
using dadjoke_xam.Views;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Material")]
namespace dadjoke_xam
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
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


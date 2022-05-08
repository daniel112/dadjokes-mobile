using System.ComponentModel;
using Xamarin.Forms;
using babyNames.ViewModels;

namespace babyNames.Views
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

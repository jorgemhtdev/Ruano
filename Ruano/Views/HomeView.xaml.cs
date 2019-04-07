
using Xamarin.Forms;
using System;namespace Ruano.Views
{
    using Ruano.ViewModels;
    using Xamarin.Forms;

    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SearchBar.Focus();
        }
    }
}

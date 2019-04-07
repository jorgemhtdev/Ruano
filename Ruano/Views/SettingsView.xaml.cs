namespace Ruano.Views
{
    using System;
    using Xamarin.Forms;

    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        public async void Handle_Tapped(object sender, EventArgs e)
        {
            var result = await Application.Current.MainPage.
                DisplayAlert("Cerra cuenta",
                "¿Quieres cerrar sesión?", "Sí", "No");

            if (result)
            {
                AppSettings.RemoveUserData();
                Application.Current.MainPage = new NavigationPage(new LoginView());
            }
        }
    }
}

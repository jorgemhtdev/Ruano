namespace Ruano.Views
{
    using Ruano.ViewModels;
    using Xamarin.Forms;

    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}

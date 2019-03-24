namespace Ruano.View
{
    using Ruano.ViewModel;
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

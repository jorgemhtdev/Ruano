namespace Ruano.ViewModels
{
    using System.Windows.Input;
    using Ruano.Views;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public ICommand DisplayCommand => new Command(Display);
        public ICommand DisplayActionCommand => new Command(DisplayAction);
        public ICommand DisplayActionSheetCommand => new Command(DisplayActionSheet);

        public async void Display()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
        }

        public async void DisplayAction()
        {

        }

        public async void DisplayActionSheet()
        {

        }
    }
}

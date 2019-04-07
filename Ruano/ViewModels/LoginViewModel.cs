namespace Ruano.ViewModels
{
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Ruano.Models;
    using Ruano.Utils;
    using Ruano.ViewModels.Base;
    using Ruano.Views;
    using Xamarin.Forms;

    public class LoginViewModel : ViewModelBase
    {
        private string _image;
        private string _email;
        private string _password;

        public string Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand TabpageCommand => new AsyncCommand(Tabpage);
        public ICommand MasterDetailPageCommand => new AsyncCommand(MasterDetailPage);

        private async Task Tabpage() => await LoginAsync(new TabpageView());

        private async Task MasterDetailPage() => await LoginAsync(new MasterDetailView());

        private async Task LoginAsync(Page page)
        {
            Login login = new Login
            {
                Email = Email,
                Password = Password
            };

            AppSettings.Login = true;

            Application.Current.MainPage = page;

            await Task.FromResult(true);
        }
    }
}

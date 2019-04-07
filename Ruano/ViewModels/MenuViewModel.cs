
namespace Ruano.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using MvvmHelpers;
    using Plugin.Media;
    using Ruano.Models;
    using Ruano.Utils;
    using Ruano.Views;
    using Xamarin.Forms;

    public class MenuViewModel : BaseViewModel
    {
        public string PhotoUser { get; set; }
        public ObservableCollection<Models.Menu> Menu { get; set; }

        public MenuViewModel()
        {
            Menu = new ObservableCollection<Models.Menu>();

            Models.Menu menu = new Models.Menu()
            {
                Name = "Displaying PopUps View",
                Icon = string.Empty
            };

            Menu.Add(menu);

            menu = new Models.Menu()
            {
                Name = "Example Binding View",
                Icon = string.Empty
            };

            Menu.Add(menu);

            PhotoUser = "ic_profileUser";
        }

        public ICommand CameraItemCommand => new AsyncCommand(CameraItem);
        public ICommand SettingsCommand => new Command(Settings);

        private async Task CameraItem()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                //DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            //await DisplayAlert("File Location", file.Path, "OK");

            /*image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });*/
        }

        private void Settings()
        {
            ((Application.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new SettingsView());

            (Application.Current.MainPage as MasterDetailPage).IsPresented = false;
        }

    }
}

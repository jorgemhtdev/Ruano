namespace Ruano.ViewModels
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public class DisplayingPopUpsViewModel
    {
        public ICommand DisplayCommand => new Command(Display);
        public ICommand DisplayActionCommand => new Command(DisplayAction);
        public ICommand DisplayActionSheetCommand => new Command(DisplayActionSheet);

        public async void Display() => await Application.Current.MainPage.DisplayAlert("Example", "Ruano formación is busy", "OK");

        public async void DisplayAction() => await Application.Current.MainPage.DisplayAlert("Ruano formación", "¿Quieres recibir información?", "Aceptar", "Cancelar");

        public async void DisplayActionSheet() => await Application.Current.MainPage.DisplayActionSheet("Ruano formación", "Cancel", null, "Xamarin", "Curso Experto en Protección de Datos", "Curso Coaching y Motivación");
    }
}

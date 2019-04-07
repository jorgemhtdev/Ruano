namespace Ruano.Views
{
    using Ruano.ViewModels;
    using Xamarin.Forms;

    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            BindingContext = new MenuViewModel();
        }
    }
}

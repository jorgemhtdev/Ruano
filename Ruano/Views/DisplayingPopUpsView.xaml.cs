namespace Ruano.Views
{
    using Ruano.ViewModels;
    using Xamarin.Forms;

    public partial class DisplayingPopUpsView : ContentPage
    {
        public DisplayingPopUpsView()
        {
            InitializeComponent();
            BindingContext = new DisplayingPopUpsViewModel();
        }
    }
}

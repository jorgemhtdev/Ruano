namespace Ruano
{
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

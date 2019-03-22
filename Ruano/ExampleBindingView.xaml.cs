namespace Ruano
{
    using Xamarin.Forms;

    public partial class ExampleBindingView : ContentPage
    {
        public ExampleBindingView()
        {
            InitializeComponent();
            BindingContext = new ExampleBindingViewModel();
        }
    }
}

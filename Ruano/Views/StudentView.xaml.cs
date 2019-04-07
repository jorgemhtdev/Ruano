namespace Ruano.Views
{
    using Ruano.ViewModels;
    using Xamarin.Forms;

    public partial class StudentView : ContentPage
    {
        public StudentView()
        {
            InitializeComponent();

            BindingContext = new StudentViewModels();
        }
    }
}

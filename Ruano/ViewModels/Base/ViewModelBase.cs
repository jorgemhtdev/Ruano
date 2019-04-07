namespace Ruano.ViewModels.Base
{
    using MvvmHelpers;

    public class ViewModelBase : BaseViewModel
    {
        private bool _isVisible;
        private bool _isEnabled;

        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }


    }
}

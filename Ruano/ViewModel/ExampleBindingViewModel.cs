namespace Ruano
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class ExampleBindingViewModel : INotifyPropertyChanged
    {
        private string _name { get; set; }

        public string Name 
        {
            get => _name;
            set
            {
                 _name = value;
                 OnPropertyChanged();
            }
        }

        public ExampleBindingViewModel()
        {
            Name = "Ruano";
        }

        public ICommand SaveCommand => new Command(Save);

        public void Save()
        {
            var value = Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

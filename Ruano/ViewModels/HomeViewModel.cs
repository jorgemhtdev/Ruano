namespace Ruano.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Ruano.ViewModels.Base;
    using Xamarin.Forms;

    public class HomeViewModel : ViewModelBase
    {
        private string _searchBar { get; set; }
        private List<Superhero> _superherosList { get; set; }
        private ObservableCollection<Superhero> _superheros { get; set; }

        public string SearchBar
        {
            get => _searchBar;
            set
            {
                _searchBar = value;
                OnPropertyChanged();

                FilterSuperhero();
            }
        }

        public ObservableCollection<Superhero> Superheros
        {
            get => _superheros;
            set
            {
                _superheros = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            IsVisible = false;

            _superherosList = new List<Superhero>();

            var superhero = new Superhero()
            {
                Name = "Wonder Woman",
                Photo = "",
                Power = "Strength and durability"
            };

            _superherosList.Add(superhero);

            superhero = new Superhero()
            {
                Name = "Aquaman",
                Photo = "",
                Power = "Superhuman strength, enhanced senses, and nearly impenetrable skin"
            };

            _superherosList.Add(superhero);

            Superheros = new ObservableCollection<Superhero>(_superherosList);
        }

        public ICommand SearchToolbarItemCommand => new Command(SearchToolbarItem);

        private void SearchToolbarItem()
        {
            IsVisible = !IsVisible;
        }

        private void FilterSuperhero() => Superheros = SearchBar?.Count() > 0
                ? new ObservableCollection<Superhero>(_superherosList.Where(sw => sw.Name.ToLower().Contains(SearchBar.ToLower())).ToList())
                : new ObservableCollection<Superhero>(_superherosList.ToList());

        /*
        private void FilterSuperhero()
        {
            if (SearchBar == null) return;


            Superheros.Clear();

            if (SearchBar?.Count() > 0)
            {
                foreach (var item in _superherosList.Where(sw => sw.Name.ToLower().Contains(SearchBar.ToLower())).ToList())
                {
                    Superheros.Add(item);
                }
            }
            else
            {
                foreach (var item in _superherosList)
                {
                    Superheros.Add(item);
                }
            }
            if (SearchBar?.Count() > 0)
                Superheros = new ObservableCollection<Superhero>(_superherosList.Where(sw => sw.Name.ToLower().Contains(SearchBar.ToLower())).ToList());
            else
                Superheros = new ObservableCollection<Superhero>(_superherosList.ToList());
        }*/
    }
}

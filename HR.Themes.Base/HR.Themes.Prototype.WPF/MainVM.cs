using HR.Themes.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HR.Themes.Prototype.WPF
{
    public class MainVM
    {
        private readonly IShell shell;
        private readonly IEnumerable<Country> countries;
        private readonly DelegateCommand exitCommand;
        private readonly DelegateCommand okCommand;
        private readonly DelegateCommand aboutCommand;
        private readonly DelegateCommand themeCommand;
        private readonly DesignQuotes quotes = new DesignQuotes();
        private IWindow currentThemeWindow;
        private ThemeSwitcherVM switcherVM;

        public MainVM(IShell shell)
        {
            this.shell = shell;
            exitCommand = new DelegateCommand(obj => shell.ExitApplication());
            okCommand = new DelegateCommand(OkClicked);
            aboutCommand = new DelegateCommand(AboutClicked);
            themeCommand = new DelegateCommand(ChangeThemeClicked);

            switcherVM = new ThemeSwitcherVM(shell);
            countries = InitCountries();
      }


        public ICommand OkCommand { get { return okCommand; } }

        public ICommand ExitCommand { get { return exitCommand; } }

        public ICommand AboutCommand { get { return aboutCommand; } }

        public ICommand ThemeCommand { get { return themeCommand; } }

        public IEnumerable<Country> Countries { get { return countries; } }

        private IEnumerable<Country> InitCountries()
        {
            var result = new List<Country>();
            result.Add(new Country("USA", new List<City> { new City("Boston"), 
                                                           new City("New York"), 
                                                           new City("San Francisco") }));

            result.Add(new Country("United Kingdom", new List<City> { new City("London"), 
                                                           new City("Bristol"), 
                                                           new City("Manchester") }));

            result.Add(new Country("Deutschland", new List<City> { new City("Berlin"), 
                                                               new City("München"),
                                                               new City("Hamburg"),
                                                               new City("Essen"),
                                                               new City("Stuttgart"),
                                                               new City("Frankfurt am Main") }));

            result.Add(new Country("République française", new List<City> { new City("Paris"), 
                                                               new City("Lyon"),
                                                               new City("Marseille") }));

            return result;
        }

        private void OkClicked(object obj)
        {
            var quote = quotes.NextQuote();
            shell.ShowMessage(quote.Quote, quote.Author);
        }
    
        private void AboutClicked(object obj)
        {
            shell.ShowMessage("This is an application for test different styles.", "About");
        }

        private void ChangeThemeClicked(object obj)
        {
            if(currentThemeWindow != null)
            {
                currentThemeWindow.Show();
                return;
            }

            var themePopup = new ThemeSwitcher_UC() { DataContext = switcherVM };
            IWindow window = shell.CreateWindow(themePopup, "Switch theme");
            

            currentThemeWindow = window;
            switcherVM.CloseClicked += (s, e) => window.Close();

            window.Closed += (s,e)=> currentThemeWindow = null;
            window.Show();
        }

    }

    public class Country
    {
        private readonly ReadOnlyCollection<City> cities;
        private readonly string name;

        public Country(string name, IList<City> cities)
        {
            this.name = name;
            this.cities = new ReadOnlyCollection<City>(cities);
        }

        public string Name { get { return name; } }

        public IEnumerable<City> Cities { get { return cities; } }
    }

    public class City
    {
        private readonly string name;

        public City(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
    }
}

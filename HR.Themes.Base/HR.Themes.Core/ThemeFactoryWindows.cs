
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HR.Themes.Core
{
    public class ThemeFactoryWindows
    {
        private readonly IEnumerable<ThemeWindows> themes;
        public ThemeFactoryWindows()
        {
            themes = InitThemes();
        }
       
        public IEnumerable<ThemeWindows> Themes
        {
            get { return themes; }
        }

        private IEnumerable<ThemeWindows> InitThemes()
        {
            var themeFactory = new ThemeFactory();

            var result = themeFactory.Themes.Select(th => new ThemeWindows(th)).ToArray();
            return result;
        }
    }
}

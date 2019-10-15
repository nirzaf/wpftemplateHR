
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR.Themes.Core
{
    public class ThemeFactory
    {
        private readonly IEnumerable<Theme> themes;
        public ThemeFactory()
        {
            themes = InitThemes();
        }
       
        public IEnumerable<Theme> Themes
        {
            get { return themes; }
        }

        private IEnumerable<Theme> InitThemes()
        {
            var result = new List<Theme>();
            result.Add(new Theme("Fischer", 
                                 "Bobby Fischer (March 9, 1943 – January 17, 2008) was an American chess grandmaster and the eleventh World Chess Champion. He is considered by many to be the greatest chess player who ever lived.",
                                 new[]{ new ColorStyle("Blue", "#00A2FF", "pack://application:,,,/HR.Themes.Fischer.WPF;component/Colors/Colors_Blue.xaml"),
                                        new ColorStyle("Violet", "#EC00FF", "pack://application:,,,/HR.Themes.Fischer.WPF;component/Colors/Colors_Violet.xaml"),
                                        new ColorStyle("Neutral", "#5B605F", "pack://application:,,,/HR.Themes.Fischer.WPF;component/Colors/Colors_Neutral.xaml"),
                                        new ColorStyle("Ocean", "#00FFEA", "pack://application:,,,/HR.Themes.Fischer.WPF;component/Colors/Colors_Ocean.xaml"),
                                          },
                                 "pack://application:,,,/HR.Themes.Fischer.WPF;component/Style.xaml")
            );

            result.Add(new Theme("Microsoft default",
                                 "Microsoft default theme",
                                 new[]{ new ColorStyle("Default", "#DDD", null)},
                                 null)
            );

            return result;
        }
    }
}

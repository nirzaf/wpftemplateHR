using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HR.Themes.Core
{
    public class ThemeWindows
    {
        private readonly IEnumerable<ColorStyleWindows> colors;
        private readonly string name;
        private readonly string description;
        private readonly Lazy<ResourceDictionary> resDic;

        public ThemeWindows(Theme theme)
        {
            this.name = theme.Name;
            this.description = theme.Description;
            this.colors = theme.Colors.Select(c => new ColorStyleWindows(c)).ToArray();
            resDic = new Lazy<ResourceDictionary>(() => Helper.ConvertStringToResourceDictionary(theme.ResoureAddress));
        }

        public IEnumerable<ColorStyleWindows> Colors { get { return colors; } }

        public string Name { get { return name; } }

        public string Description { get { return description; } }

        public ResourceDictionary Resource { get { return resDic.Value; } }
    }
}

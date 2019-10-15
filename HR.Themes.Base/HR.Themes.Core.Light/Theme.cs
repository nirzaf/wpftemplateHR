using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR.Themes.Core
{
    public class Theme
    {
        private readonly IEnumerable<ColorStyle> colors;
        private readonly string name;
        private readonly string description;
        private readonly string resoureAddress;

        public Theme(string name, string description, IEnumerable<ColorStyle> colors, string resoureAddress)
        {
            this.name = name;
            this.description = description;
            this.colors = colors;
            this.resoureAddress = resoureAddress;
        }

        public IEnumerable<ColorStyle> Colors { get { return colors; } }

        public string Name { get { return name; } }

        public string Description { get { return description; } }

        public string ResoureAddress { get { return resoureAddress; } }
    }
}

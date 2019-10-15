using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace HR.Themes.Core
{
    public class ColorStyleWindows
    {
        private readonly string name;
        private readonly Brush color;
        private readonly Lazy<ResourceDictionary> resDic;

        public ColorStyleWindows(ColorStyle colorStyle)
        {
            this.name = colorStyle.Name;
            this.color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorStyle.HexColor));
            this.resDic = new Lazy<ResourceDictionary>(() => Helper.ConvertStringToResourceDictionary(colorStyle.ResourceAddress));
        }

        public string Name { get { return name; } }

        public ResourceDictionary Resource { get { return resDic.Value; } }

        public Brush Color { get { return color; } }

    }
}

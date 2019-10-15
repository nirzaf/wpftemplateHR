using System;


namespace HR.Themes.Core
{
    public class ColorStyle
    {
        private readonly string name;
        private readonly string hexColor;
        private readonly string resoureAddress;

        public ColorStyle(string name, string hexColor, string resoureAddress)
        {
            this.name = name;
            this.hexColor = hexColor;
            this.resoureAddress = resoureAddress;
        }

        public string Name { get { return name; } }
        public string HexColor { get { return hexColor; } }
        public string ResourceAddress { get { return resoureAddress; } }

    }
}

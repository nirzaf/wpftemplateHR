using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HR.Themes.Core
{
    internal class Helper
    {

        public static ResourceDictionary ConvertStringToResourceDictionary(string uri)
        {
            var resource = new ResourceDictionary();
            if (!String.IsNullOrWhiteSpace(uri))
            {
                resource.Source = new Uri(uri);
            }

            return resource;
        }
    }
}

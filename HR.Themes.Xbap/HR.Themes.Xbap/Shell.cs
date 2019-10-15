using HR.Themes.Core;
using HR.Themes.Prototype.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace HR.Themes.Xbap
{
    public class Shell: IShell
    {
        public bool IsLightVersion { get { return true; } }

        public void ExitApplication()
        {
            //App.Current.Shutdown();
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }


        public IWindow CreateWindow(object userControl, string title)
        {
            var popup = new Popup_UC((UserControl)userControl, title);

            return popup;
        }
    }
}

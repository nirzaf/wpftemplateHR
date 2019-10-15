using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR.Themes.Core
{
    public interface IWindow
    {
        void Show();

        void Close();

        event EventHandler Closed;
    }
}

using HR.Themes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HR.Themes.Xbap
{
    /// <summary>
    /// Interaction logic for Popup_UC.xaml
    /// </summary>
    public partial class Popup_UC : UserControl, IWindow
    {
        Panel lastParentPanel;
        Canvas canvasHolder;
        bool isShown;
        Point startPoint;

        public Popup_UC()
        {
            InitializeComponent();
        }

        public Popup_UC(UIElement child, string title)
        {
            InitializeComponent();

            childContent.Children.Add(child);
            tbltitle.Text = title;
            canvasHolder = new Canvas();
            canvasHolder.Children.Add(this);
            
            Margin = new Thickness(30);
        }

        public event EventHandler Closed;


        public void Close()
        {
            if(lastParentPanel != null && canvasHolder != null)
            {
                lastParentPanel.Children.Remove(canvasHolder);
            }
            isShown = false;

            if(Closed != null)
            {
                Closed(this, EventArgs.Empty);
            }
        }

        public void Show()
        {
            if (!isShown)
            {
                lastParentPanel = ((Page)App.Current.MainWindow.Content).Content as Panel;
                lastParentPanel.Children.Add(canvasHolder);
                isShown = true;
            }
        }

        private void CloseBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }


    }
}

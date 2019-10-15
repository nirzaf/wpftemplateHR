using HR.Themes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace HR.Themes.Prototype.WPF
{
    public class ThemeSwitcherVM : NotifyObject
    {
        private readonly IShell shell;
        private readonly ThemeFactoryWindows themeFactory;
        private readonly DelegateCommand okCommand;
        private ThemeWindows selectedTheme;
        private ColorStyleWindows selectedColor;

        public ThemeSwitcherVM(IShell shell)
        {
            this.shell = shell;
            themeFactory = new ThemeFactoryWindows();
            SelectedTheme = themeFactory.Themes.FirstOrDefault();

            okCommand = new DelegateCommand(OnOkClicked);
        }

        public event EventHandler CloseClicked;

        public IEnumerable<ThemeWindows> Themes { get { return themeFactory.Themes; } }

        public ICommand OkCommand { get { return okCommand; } }

        public ThemeWindows SelectedTheme
        {
            get { return selectedTheme; }
            set
            {
                if (selectedTheme != value)
                {
                    selectedTheme = value;
                    NotifyView("SelectedTheme");
                    OnSelectedThemeChanged(value);
                }
            }
        }

        public ColorStyleWindows SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    NotifyView("SelectedColor");
                    OnSelectedColorChanged(value);
                }
            }
        }

        private void OnSelectedThemeChanged(ThemeWindows selectedTheme)
        {
            if (selectedTheme != null)
            {
                SelectedColor = selectedTheme.Colors.FirstOrDefault();
            }
        }

        private void OnSelectedColorChanged(ColorStyleWindows newValue)
        {            
             SwitchStyle();            
        }
        private void OnOkClicked(object obj)
        {
            ClosePopup();
        }

        private void SwitchStyle()
        {
            var res = new ResourceDictionary();

            if (SelectedColor != null && SelectedColor.Resource != null)
            {
                res.MergedDictionaries.Add(SelectedColor.Resource);
            }
            if (SelectedTheme != null && SelectedTheme.Resource != null)
            {
                res.MergedDictionaries.Add(SelectedTheme.Resource);
            }

            System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(res);
        }

        private void ClosePopup()
        {
            if (CloseClicked != null)
            {
                CloseClicked(this, EventArgs.Empty);
            }
        }
    }
}

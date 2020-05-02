using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms.Gallery.Styles;

namespace Xamarin.Forms.Gallery.ViewModels
{
    public class SettingsViewModel : BindableObject
    {
        bool _isDarkMode;

        public SettingsViewModel()
        {
            LoadThemesSettings();
        }

        public bool IsDarkMode
        {
            get { return _isDarkMode; }
            set
            {
                _isDarkMode = value;
                OnPropertyChanged();
            }
        }

        public ICommand ThemeLigthCommand => new Command(ThemeLigth);

        public ICommand ThemeDarkCommand => new Command(ThemeDark);

        public ICommand ViewCodeCommand => new Command(ViewCode);

        void ThemeLigth()
        {
            IsDarkMode = false;
            Application.Current.Resources = new LightTheme();
            App.AppTheme = "light";
        }

        void ThemeDark()
        {
            IsDarkMode = true;
            Application.Current.Resources = new DarkTheme();
            App.AppTheme = "dark";
        }

        void LoadThemesSettings()
        {
            IsDarkMode = App.AppTheme == "dark";
        }

        void ViewCode()
        {
            string url = "https://github.com/xamarin/xamarin.forms";
            Browser.OpenAsync(new Uri(url));
        }
    }
}
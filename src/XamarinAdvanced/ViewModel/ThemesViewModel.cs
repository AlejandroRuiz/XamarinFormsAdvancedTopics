using System;
using MvvmHelpers;
using Xamarin.Forms;

namespace XamarinAdvanced.ViewModel
{
    public class ThemesViewModel : BaseViewModel
    {
        bool _isDarkThemeSelected;

        public ThemesViewModel()
        {
            SetTheme(true);
        }

        public bool IsDarkThemeSelected
        {
            get => _isDarkThemeSelected;
            set
            {
                if (SetProperty(ref _isDarkThemeSelected, value))
                {
                    SetTheme(!_isDarkThemeSelected);
                }
            }
        }

        void SetTheme(bool isLight)
        {
            object textColor;
            object backgroundColor;
            object backgroundButtonColor;
            if(isLight)
            {
                textColor = Application.Current.Resources["LightTextColor"];
                backgroundColor = Application.Current.Resources["LightBackgroundColor"];
                backgroundButtonColor = Application.Current.Resources["LightBackgroundButtonColor"];
                Title = "Light Theme";
            }
            else
            {
                textColor = Application.Current.Resources["DarkTextColor"];
                backgroundColor = Application.Current.Resources["DarkBackgroundColor"];
                backgroundButtonColor = Application.Current.Resources["DarkBackgroundButtonColor"];
                Title = "Dark Theme";
            }
            Application.Current.Resources["TextColor"] = textColor;
            Application.Current.Resources["BackgroundColor"] = backgroundColor;
            Application.Current.Resources["BackgroundButtonColor"] = backgroundButtonColor;
        }
    }
}

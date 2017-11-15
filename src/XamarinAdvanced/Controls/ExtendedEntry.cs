using System;
using Xamarin.Forms;

namespace XamarinAdvanced.Controls
{
    public class ExtendedEntry : Entry
    {
        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth), typeof(double), typeof(ExtendedEntry), -1.0);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(ExtendedEntry), Color.Default);
        public static readonly BindableProperty BorderRadiusProperty = BindableProperty.Create(nameof(BorderRadius), typeof(int), typeof(ExtendedEntry), 5);

        public ExtendedEntry()
        {
        }

        public double BorderWidth
        {
            get => (double)base.GetValue(BorderWidthProperty);
            set => base.SetValue(BorderWidthProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)base.GetValue(BorderColorProperty);
            set => base.SetValue(BorderColorProperty, value);
        }

        public int BorderRadius
        {
            get => (int)base.GetValue(BorderRadiusProperty);
            set => base.SetValue(BorderRadiusProperty, value);
        }
    }
}

using System;
using Android.Graphics.Drawables;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinAdvanced.Controls;
using XamarinAdvanced.Droid.Dependency;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace XamarinAdvanced.Droid.Dependency
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        GradientDrawable _backgroundGradient = new GradientDrawable();

        public new ExtendedEntry Element => base.Element as ExtendedEntry;

        public ExtendedEntryRenderer()
        {
            var background = new GradientDrawable();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
                {
                    Control.Background = _backgroundGradient;
                }
                else
                {
                    Control.SetBackgroundDrawable(_backgroundGradient);
                }
                BuildBorder();
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ExtendedEntry.BorderColorProperty.PropertyName)
            {
                SetBorderColor();
            }
            else if (e.PropertyName == ExtendedEntry.BorderWidthProperty.PropertyName)
            {
                SetBorderWidth();
            }
            else if (e.PropertyName == ExtendedEntry.BorderRadiusProperty.PropertyName)
            {
                SetBorderRadius();
            }
        }

        void BuildBorder()
        {
            SetBackgroundColor();
            SetBorderWidth();
            SetBorderColor();
            SetBorderRadius();
        }

        void SetBackgroundColor()
        {
            _backgroundGradient.SetColor(Element.BackgroundColor.ToAndroid());
        }

        void SetBorderWidth()
        {
            _backgroundGradient.SetStroke((int)Element.BorderWidth, Element.BorderColor.ToAndroid());
        }

        void SetBorderColor()
        {
            _backgroundGradient.SetStroke((int)Element.BorderWidth, Element.BorderColor.ToAndroid());
        }

        void SetBorderRadius()
        {
            _backgroundGradient.SetCornerRadius(Element.BorderRadius);
        }
    }
}

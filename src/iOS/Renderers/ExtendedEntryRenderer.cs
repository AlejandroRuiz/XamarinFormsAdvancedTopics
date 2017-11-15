using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinAdvanced.Controls;
using XamarinAdvanced.iOS.Renderers;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace XamarinAdvanced.iOS.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public new ExtendedEntry Element => base.Element as ExtendedEntry;

        public ExtendedEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                BuildBorder();
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if(e.PropertyName == ExtendedEntry.BorderColorProperty.PropertyName)
            {
                SetBorderColor();
            }
            else if(e.PropertyName == ExtendedEntry.BorderWidthProperty.PropertyName)
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
            SetBorderWidth();
            SetBorderColor();
            SetBorderRadius();
        }

        void SetBorderWidth()
        {
            Control.Layer.BorderWidth = (nfloat)Element.BorderWidth;
        }

        void SetBorderColor()
        {
            Control.Layer.BorderColor = Element.BorderColor.ToCGColor();
        }

        void SetBorderRadius()
        {
            Control.Layer.CornerRadius = Element.BorderRadius;
        }
    }
}

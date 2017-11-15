using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinAdvanced.iOS.Effects;

[assembly: ResolutionGroupName("GroupName")]
[assembly: ExportEffect(typeof(ShadowEffect), "ShadowEffect")]
namespace XamarinAdvanced.iOS.Effects
{
    public class ShadowEffect : PlatformEffect
    {
        public ShadowEffect()
        {
        }

        protected override void OnAttached()
        {
            Control.Layer.CornerRadius = 5;
            Control.Layer.ShadowColor = UIColor.Black.CGColor;
            Control.Layer.ShadowOffset = new CGSize(5, 5);
            Control.Layer.ShadowOpacity = 1.0f;
        }

        protected override void OnDetached()
        {
        }
    }
}

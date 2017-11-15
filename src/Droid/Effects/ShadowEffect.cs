using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinAdvanced.Droid.Effects;

[assembly: ResolutionGroupName("GroupName")]
[assembly: ExportEffect(typeof(ShadowEffect), "ShadowEffect")]
namespace XamarinAdvanced.Droid.Effects
{
    public class ShadowEffect : PlatformEffect
    {
        public ShadowEffect()
        {
        }

        protected override void OnAttached()
        {
            float radius = 5;
            float distanceX = 5;
            float distanceY = 5;
            Android.Graphics.Color color = Android.Graphics.Color.Black;
            (Control as Android.Widget.TextView).SetShadowLayer(radius, distanceX, distanceY, color);
        }

        protected override void OnDetached()
        {
        }
    }
}

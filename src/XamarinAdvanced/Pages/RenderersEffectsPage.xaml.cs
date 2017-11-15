using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinAdvanced.Pages
{
    public partial class RenderersEffectsPage : ContentPage
    {
        public RenderersEffectsPage()
        {
            InitializeComponent();
            _effectLabel.Effects.Add(Effect.Resolve("GroupName.ShadowEffect"));
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinAdvanced.ViewModel;

namespace XamarinAdvanced.Pages
{
    public partial class TemplateSelectorPage : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
            (e.Item as CardItemViewModel).SendItemTapped();
        }

        public TemplateSelectorPage()
        {
            InitializeComponent();
        }
    }
}

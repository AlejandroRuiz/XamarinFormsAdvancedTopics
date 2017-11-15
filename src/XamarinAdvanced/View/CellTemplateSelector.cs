using System;
using Xamarin.Forms;
using XamarinAdvanced.Model;
using XamarinAdvanced.ViewModel;

namespace XamarinAdvanced.View
{
    public class CellTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ImageTemplate { get; set; }

        public DataTemplate AdTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((CardItemViewModel)item).CardType == CardType.Image ? ImageTemplate : AdTemplate;
        }
    }
}

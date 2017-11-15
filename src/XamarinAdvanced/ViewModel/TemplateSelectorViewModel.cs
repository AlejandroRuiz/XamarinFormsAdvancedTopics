using System;
using System.Collections.ObjectModel;
using MvvmHelpers;
using XamarinAdvanced.Model;

namespace XamarinAdvanced.ViewModel
{
    public class TemplateSelectorViewModel : BaseViewModel
    {
        readonly ObservableCollection<CardItemViewModel> _cards = new ObservableCollection<CardItemViewModel>
        {
            new CardItemViewModel(new ImageCardItem{ Details = "#instacool #mexico #gdl #chivas #tequila what a good day to be here at Guadalajara", SourceUrl = "https://assets.vogue.com/photos/58dedea1c83a5e7c386dc9bc/master/pass/00-square-scarlett-johansson-5-things.jpg", Text = "Scarlett Johansson"}),
            new CardItemViewModel(new ImageCardItem{ Details = "See you next Saturday folks #tour #latinamerica #mexicocity #cc2017", SourceUrl = "http://p.transformyourimages.co.uk/csi/622592/i/pliz/foofightersdavegrohlsqu_full.jpg?_t=1431915437", Text = "Foo Fighters"}),
            new CardItemViewModel(new AdCardItem{ Details = "2x1 Lunes a Viernes", SourceUrl = "http://www.dulcestipicos.com.mx/images/DulcesBanner.png", Text = "Dulces"}),
            new CardItemViewModel(new ImageCardItem{ Details = "#instacool #mexico #gdl #chivas #tequila what a good day to be here at Guadalajara", SourceUrl = "https://assets.vogue.com/photos/58dedea1c83a5e7c386dc9bc/master/pass/00-square-scarlett-johansson-5-things.jpg", Text = "Scarlett Johansson"}),
            new CardItemViewModel(new ImageCardItem{ Details = "See you next Saturday folks #tour #latinamerica #mexicocity #cc2017", SourceUrl = "http://p.transformyourimages.co.uk/csi/622592/i/pliz/foofightersdavegrohlsqu_full.jpg?_t=1431915437", Text = "Foo Fighters"}),
            new CardItemViewModel(new AdCardItem{ Details = "2x1 Lunes a Viernes", SourceUrl = "http://www.dulcestipicos.com.mx/images/DulcesBanner.png", Text = "Dulces"}),
            new CardItemViewModel(new ImageCardItem{ Details = "#instacool #mexico #gdl #chivas #tequila what a good day to be here at Guadalajara", SourceUrl = "https://assets.vogue.com/photos/58dedea1c83a5e7c386dc9bc/master/pass/00-square-scarlett-johansson-5-things.jpg", Text = "Scarlett Johansson"}),
            new CardItemViewModel(new ImageCardItem{ Details = "See you next Saturday folks #tour #latinamerica #mexicocity #cc2017", SourceUrl = "http://p.transformyourimages.co.uk/csi/622592/i/pliz/foofightersdavegrohlsqu_full.jpg?_t=1431915437", Text = "Foo Fighters"}),
        };

        public TemplateSelectorViewModel()
        {
            Title = "InstaPhotos";
        }

        public ObservableCollection<CardItemViewModel> Cards => _cards;
    }
}

using System;
using MvvmHelpers;
using Xamarin.Forms;
using XamarinAdvanced.Model;

namespace XamarinAdvanced.ViewModel
{
    public class CardItemViewModel : BaseViewModel
    {
        public ICardItem CardItem { get; }

        public CardItemViewModel(ICardItem cardItem)
        {
            CardItem = cardItem;
        }

        public string Text => CardItem.Text;

        public string Details => CardItem.Details;

        public string SourceUrl => CardItem.SourceUrl;

        public CardType CardType => CardItem.CardType;

        public async void SendItemTapped()
        {
            if(CardType == CardType.Ad)
            {
                await Application.Current.MainPage.DisplayAlert(Text, Details, "Ok");
            }
            else
            {
                Device.OpenUri(new Uri(SourceUrl));
            }
        }
    }
}

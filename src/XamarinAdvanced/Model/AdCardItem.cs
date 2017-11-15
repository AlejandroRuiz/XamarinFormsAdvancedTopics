using System;
namespace XamarinAdvanced.Model
{
    public class AdCardItem : ICardItem
    {
        public AdCardItem()
        {
        }

        public string Text { get; set; }
        public string Details { get; set; }
        public string SourceUrl { get; set; }
        public CardType CardType => CardType.Ad;
    }
}

using System;
namespace XamarinAdvanced.Model
{
    public interface ICardItem
    {
        string Text { get; set; }
        string Details { get; set; }
        string SourceUrl { get; set; }
        CardType CardType { get; }
    }
}

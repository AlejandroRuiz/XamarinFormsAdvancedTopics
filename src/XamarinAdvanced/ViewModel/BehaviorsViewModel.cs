using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace XamarinAdvanced.ViewModel
{
    public class BehaviorsViewModel : BaseViewModel
    {
        public BehaviorsViewModel()
        {
            Title = "Behaviors";
            ItemTappedCommand = new Command<string>(InvokeItemTappedCommand);
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6" };

        public ICommand ItemTappedCommand { get; }

        async void InvokeItemTappedCommand(string val)
        {
            await Application.Current.MainPage.DisplayAlert("Item Tapped", $"val. {val}", "Ok");
        }
    }
}

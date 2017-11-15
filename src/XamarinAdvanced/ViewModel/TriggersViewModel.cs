using System;
using MvvmHelpers;

namespace XamarinAdvanced.ViewModel
{
    public class TriggersViewModel : BaseViewModel
    {
        string _name;
        string _userName;
        string _password;

        public TriggersViewModel()
        {
            Title = "Triggers";
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, onChanged: () => { OnPropertyChanged(nameof(NameLength)); });
        }

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public int NameLength => string.IsNullOrWhiteSpace(Name) ? 0 : Name.Length;
    }
}

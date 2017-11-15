using System;
using MvvmHelpers;
using Xamarin.Forms;
using XamarinAdvanced.Dependency;

namespace XamarinAdvanced.ViewModel
{
    public class DependencyServiceViewModel : BaseViewModel
    {
        public DependencyServiceViewModel()
        {
            Title = "Dependency Service";
            OnClickedCommand = new Command(InvokeOnClickedCommand);
        }

        public Command OnClickedCommand { get; }

        void InvokeOnClickedCommand()
        {
            var manager = DependencyService.Get<IAudioManager>();
            manager.PlayAudio("audio.mp3");
        }
    }
}

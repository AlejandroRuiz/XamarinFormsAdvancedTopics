using System;
using MvvmHelpers;
using Xamarin.Forms;
using XamarinAdvanced.Pages;

namespace XamarinAdvanced.ViewModel
{
    public class XamarinAdvancedViewModel : BaseViewModel
    {
        public XamarinAdvancedViewModel()
        {
            GoToDataTemplateCommand = new Command(InvokeGoToDataTemplateCommand);
            GoToThemesCommand = new Command(InvokeGoToThemesCommand);
            GoToBehaviorsCommand = new Command(InvokeGoToBehaviorsCommand);
            GoToTriggersCommand = new Command(InvokeGoToTriggersCommand);
            GoToRenderersEffectsCommand = new Command(InvokeGoToRenderersEffectsCommand);
            GoToDependencyServiceCommand = new Command(InvokeGoToDependencyServiceCommand);
        }

        public Command GoToDataTemplateCommand { get; }

        public Command GoToThemesCommand { get; }

        public Command GoToBehaviorsCommand { get; }

        public Command GoToTriggersCommand { get; }

        public Command GoToRenderersEffectsCommand { get; }

        public Command GoToDependencyServiceCommand { get; }

        async void InvokeGoToDataTemplateCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TemplateSelectorPage());
        }

        async void InvokeGoToThemesCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ThemesPage());
        }

        async void InvokeGoToBehaviorsCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BehaviorsPage());
        }

        async void InvokeGoToTriggersCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TriggersPage());
        }

        async void InvokeGoToRenderersEffectsCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RenderersEffectsPage());
        }

        async void InvokeGoToDependencyServiceCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DependencyServicePage());
        }
    }
}

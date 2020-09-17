using DevReach2020.Forms.Portable.ViewModels;
using DevReach2020.Forms.Portable.Views;
using Prism.Ioc;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable
{
    public partial class App
    {
        public App()
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var result = await NavigationService.NavigateAsync("NavigationPage/MainPage");

            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
            containerRegistry.RegisterForNavigation<LiveStreamPage, LiveStreamViewModel>();
        }
    }
}

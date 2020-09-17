using System;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class LiveStreamViewModel : BindableBase, IInitialize, IConfirmNavigation, INavigationAware
    {
        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogs;
        private bool isNavigating;
        private UrlWebViewSource webSource;

        public LiveStreamViewModel(INavigationService navigationService, IPageDialogService dialogs)
        {
            this.navigationService = navigationService;
            this.dialogs = dialogs;
        }

        public bool IsNavigating
        {
            get => isNavigating;
            set => SetProperty(ref isNavigating, value);
        }

        public UrlWebViewSource WebSource
        {
            get => webSource;
            set => SetProperty(ref webSource, value);
        }

        public void Initialize(INavigationParameters parameters)
        {
            var link = parameters.GetValue<string>("url");
            WebSource = new UrlWebViewSource{ Url = link };
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            if (isNavigating)
            {
                var result = dialogs.DisplayAlertAsync("Leave?", "Things are still loading, do you want to leave?", "yes", "no").Result;
                return result;
            }
            IsNavigating = true;
            return true;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}

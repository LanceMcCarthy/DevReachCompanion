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
        private UrlWebViewSource webSource; 
        private bool isBusy;
        private string busyMessage;

        public LiveStreamViewModel(INavigationService navigationService, IPageDialogService dialogs)
        {
            this.navigationService = navigationService;
            this.dialogs = dialogs;

            WebViewNavigatingCommand = new Command(OnWebViewNavigating);
            WebViewNavigatedCommand = new Command(OnWebViewNavigated);
        }

        public UrlWebViewSource WebSource
        {
            get => webSource;
            set => SetProperty(ref webSource, value);
        }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }
        public string BusyMessage
        {
            get => busyMessage;
            set => SetProperty(ref busyMessage, value);
        }

        public Command WebViewNavigatingCommand { get; set; }

        public Command WebViewNavigatedCommand { get; set; }

        private void OnWebViewNavigating()
        {
            IsBusy = false;
            BusyMessage = "";
        }

        private void OnWebViewNavigated()
        {
            IsBusy = false;
            BusyMessage = $"loading {WebSource?.Url}...";
        }

        public void Initialize(INavigationParameters parameters)
        {
            var endpoint = parameters.GetValue<string>("endpoint");

            if (string.IsNullOrEmpty(endpoint))
            {
                WebSource = new UrlWebViewSource { Url = "https://www.twitch.tv/codeitlive/" };
            }
            else
            {
                WebSource = new UrlWebViewSource
                {
                    Url = "https://www.twitch.tv/codeitlive/" + endpoint
                };
            }
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            if (isBusy)
            {
                var result = dialogs.DisplayAlertAsync("Leave?", "Things are still loading, do you want to leave?", "yes", "no").Result;
                return result;
            }

            IsBusy = false;
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

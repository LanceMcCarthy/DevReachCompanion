using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.Models
{
    public class LiveTabContext : TabContextBase
    {
        private UrlWebViewSource webSource;

        public LiveTabContext()
        {
            Title = "Live";
            IconFontCharacter = IconHelpers.LiveTabIcon;
            ToggleIsLoadingCommand = new Command(ToggleLoading);
            WebViewNavigatingCommand = new Command(OnWebViewNavigating);
            WebViewNavigatedCommand = new Command(OnWebViewNavigated);

            //WebSource = new UrlWebViewSource { Url = "https://www.twitch.tv/codeitlive/" };
        }

        public UrlWebViewSource WebSource
        {
            get => webSource ?? (webSource = new UrlWebViewSource { Url = "https://www.twitch.tv/codeitlive/" });
            set => SetProperty(ref webSource, value);
        }

        public Command WebViewNavigatingCommand { get; set; }

        public Command WebViewNavigatedCommand { get; set; }

        private void ToggleLoading()
        {
            IsBusy = !IsBusy;
        }

        private void OnWebViewNavigating()
        {
            IsBusy = true;
            IsBusyMessage = $"loading {WebSource?.Url}...";
        }

        private void OnWebViewNavigated()
        {
            IsBusy = false;
            IsBusyMessage = "";
        }
    }
}
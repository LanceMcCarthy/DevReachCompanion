using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class MainViewModel : BindableBase, IInitialize, INavigationAware
    {
        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogs;
        private bool isBusy;
        private string busyMessage;
        private ImageSource headerImgSource;

        public MainViewModel(INavigationService navigationService, IPageDialogService dialogs)
        {
            this.navigationService = navigationService;
            this.dialogs = dialogs;

            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        public ImageSource HeaderImgSource
        {
            get => headerImgSource;
            set => SetProperty(ref headerImgSource, value);
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

        public DelegateCommand<string> NavigateCommand { get; }

        public void Initialize(INavigationParameters parameters)
        {
            IsBusy = true;
            BusyMessage = "Initializing...";

            HeaderImgSource = new StreamImageSource()
            {
                Stream = ImageHelpers.GetBannerImage
            };

            IsBusy = false;
            BusyMessage = "";
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            IsBusy = false;
            BusyMessage = "";
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        private async void OnNavigateCommandExecuted(string param)
        {
            var result = await navigationService.NavigateAsync($"NavigationPage/LiveStreamPage?endpoint={param}");

            if (!result.Success)
            {
                await dialogs.DisplayAlertAsync("Error", result.Exception.Message, "Ok");

                // due to error, OnNavFrom will never be hit, reset things here instead.
                IsBusy = false;
                BusyMessage = "";
            }
        }
    }
}

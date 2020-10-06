using CommonHelpers.Mvvm;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class HomeTabViewModel : TabViewModelBase
    {
        private ImageSource headerImgSource;

        public HomeTabViewModel()
        {
            Title = AppConstants.HomeTabName;

            HeaderImgSource = new StreamImageSource
            {
                Stream = token => EmbeddedImageHelpers.GetImage("DevReachBanner.png", token)
            };

            ToggleIsLoadingCommand = new Command(ToggleLoading);
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        public ImageSource HeaderImgSource
        {
            get => headerImgSource;
            set => SetProperty(ref headerImgSource, value);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        private void OnNavigateCommandExecuted(string param)
        {
            this.TabNavigator.InvokeTabSelection(param);
        }

        private void ToggleLoading()
        {
            IsBusy = !IsBusy;
        }
    }
}
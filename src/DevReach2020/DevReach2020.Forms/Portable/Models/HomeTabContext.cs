using CommonHelpers.Mvvm;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.Models
{
    public class HomeTabContext : TabContextBase
    {
        private ImageSource headerImgSource;

        public HomeTabContext()
        {
            Title = "Home";

            IconFontCharacter = IconHelpers.HomeTabIcon;

            HeaderImgSource = new StreamImageSource
            {
                Stream = ImageHelpers.GetBannerImage
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
            this.TabNavigator.SelectTab(param);
        }

        private void ToggleLoading()
        {
            IsBusy = !IsBusy;
        }
    }
}
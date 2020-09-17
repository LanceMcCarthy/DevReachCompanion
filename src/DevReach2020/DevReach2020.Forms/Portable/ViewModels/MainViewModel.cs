using DevReach2020.Forms.Portable.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class MainViewModel : BindableBase, IInitialize, IConfirmNavigation, INavigationAware
    {
        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogs;
        private bool isNavigating;
        private string busyMessage;

        public MainViewModel(INavigationService navigationService, IPageDialogService dialogs)
        {
            this.navigationService = navigationService;
            this.dialogs = dialogs;

            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
            Students = new ObservableCollection<Student>();
        }

        public ObservableCollection<Student> Students { get; set; }

        public bool IsNavigating
        {
            get => isNavigating;
            set => SetProperty(ref isNavigating, value);
        }

        public string BusyMessage
        {
            get => busyMessage;
            set => SetProperty(ref busyMessage, value);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        public async void Initialize(INavigationParameters parameters)
        {
            BusyMessage = "...";

            await Task.Delay(TimeSpan.FromSeconds(3));
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            IsNavigating = true;
            return true;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            IsNavigating = false;
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        private async void OnNavigateCommandExecuted(string path)
        {
            var result = await navigationService.NavigateAsync(path);

            if (!result.Success)
            {
                await dialogs.DisplayAlertAsync("Error", result.Exception.Message, "Ok");

                // OnNavigatedFrom will never be reached
                IsNavigating = false;
            }
        }
    }
}

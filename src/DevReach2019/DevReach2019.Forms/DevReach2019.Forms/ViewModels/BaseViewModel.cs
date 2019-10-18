using DevReach2019.Forms.Common;

namespace DevReach2019.Forms.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        private bool isBusy = false;
        private string title = string.Empty;
        private string isBusyMessage = string.Empty;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public string IsBusyMessage
        {
            get => isBusyMessage;
            set => SetProperty(ref isBusyMessage, value);
        }
    }
}

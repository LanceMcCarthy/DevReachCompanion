using CommonHelpers.Common;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class TabViewModelBase : ViewModelBase
    {
        public Command ToggleIsLoadingCommand { get; set; }

        public ITabAwareViewModel TabNavigator { get; set; }
    }
}

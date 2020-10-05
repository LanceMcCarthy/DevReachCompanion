using CommonHelpers.Common;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.Models
{
    public class TabContextBase : ViewModelBase
    {
        private string iconFontCharacter;

        public string IconFontCharacter
        {
            get => iconFontCharacter;
            set => SetProperty(ref iconFontCharacter, value);
        }
        
        public Command ToggleIsLoadingCommand { get; set; }

        public ITabNavigator TabNavigator { get; set; }

    }
}

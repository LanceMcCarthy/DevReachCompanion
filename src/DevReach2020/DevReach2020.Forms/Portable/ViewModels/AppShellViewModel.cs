using CommonHelpers.Common;
using DevReach2020.Forms.Portable.Helpers;
using DevReach2020.Forms.Portable.Models;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class AppShellViewModel : ViewModelBase, ITabNavigator
    {
        public AppShellViewModel()
        {
            HomeTabContext = new HomeTabContext { TabNavigator = this };
            LiveTabContext = new LiveTabContext { TabNavigator = this };
            AboutTabContext = new AboutTabContext { TabNavigator = this };
        }

        public TabContextBase HomeTabContext { get; set; }

        public TabContextBase LiveTabContext { get; set; }

        public TabContextBase AboutTabContext { get; set; }

        public ITabNavigator TabNavigator { get; set; }

        public void SelectTab(string title)
        {
            this.TabNavigator.SelectTab(title);
        }
    }
}

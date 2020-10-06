using System;
using System.Collections.Generic;
using CommonHelpers.Common;
using DevReach2020.Forms.Portable.Helpers;
using Microsoft.AppCenter.Crashes;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class MainViewModel : ViewModelBase, ITabAwareViewModel
    {
        public MainViewModel()
        {
            HomeTabViewModel = new HomeTabViewModel { TabNavigator = this };
            LiveTabViewModel = new LiveTabViewModel { TabNavigator = this };
            AboutTabViewModel = new AboutTabViewModel { TabNavigator = this };
        }

        public TabViewModelBase HomeTabViewModel { get; set; }

        public TabViewModelBase LiveTabViewModel { get; set; }

        public TabViewModelBase AboutTabViewModel { get; set; }


        public ITabAwarePage TabAwarePage { get; set; }

        public void InvokeTabSelection(string title)
        {
            try
            {
                this.TabAwarePage.SelectTab(title);
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "MainViewModel" },
                    { "Method", "InvokeTabSelection" },
                    { "TabName", title }
                });
            }
        }
    }
}

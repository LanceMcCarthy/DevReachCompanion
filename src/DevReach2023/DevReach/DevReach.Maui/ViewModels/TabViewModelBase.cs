using CommonHelpers.Common;
using DevReach.Maui.Interfaces;

namespace DevReach.Maui.ViewModels;

public class TabViewModelBase : ViewModelBase
{
    public Command ToggleIsLoadingCommand { get; set; }

    public ITabAwareViewModel TabNavigator { get; set; }
}
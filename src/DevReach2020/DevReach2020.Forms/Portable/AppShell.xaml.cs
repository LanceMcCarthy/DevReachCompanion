using DevReach2020.Forms.Portable.Helpers;
using DevReach2020.Forms.Portable.ViewModels;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevReach2020.Forms.Portable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : ContentPage, ITabNavigator
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = new AppShellViewModel();
            (BindingContext as AppShellViewModel).TabNavigator = this;
        }

        public void SelectTab(string title)
        {
            var tabToSelect = tabView.Items.FirstOrDefault(t => t.HeaderText.ToLower().Equals(title));

            if (tabToSelect != null)
            {
                tabView.SelectedItem = tabToSelect;
            }
        }
    }
}
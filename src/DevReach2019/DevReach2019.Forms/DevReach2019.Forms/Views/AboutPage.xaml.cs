using System.ComponentModel;
using DevReach2019.Forms.ViewModels;
using Xamarin.Forms;

namespace DevReach2019.Forms.Views
{
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}
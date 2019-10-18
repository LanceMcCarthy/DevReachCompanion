using System;
using DevReach2019.Forms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevReach2019.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendaPage : ContentPage
    {
        public AgendaPage(AgendaViewModel context)
        {
            InitializeComponent();
            BindingContext = context;
        }

        private void CloseButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync(true);
        }
    }
}
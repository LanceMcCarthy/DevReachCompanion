using System;
using System.Collections.Generic;
using DevReach2019.Forms.ViewModels.Sessions;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevReach2019.Forms.Views.Session
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionsPage : ContentPage
    {
        public SessionsPage()
        {
            InitializeComponent();
            BindingContext = new SessionsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if ((BindingContext as SessionsViewModel)?.Sessions.Count == 0)
            {
                (BindingContext as SessionsViewModel)?.LoadSessionsCommand.Execute(null);
            }
        }

        private async void RadListView_OnItemTapped(object sender, ItemTapEventArgs e)
        {
            try
            {
                if (e.Item is Models.Session session)
                {
                    await Navigation.PushAsync(new SessionDetailPage(new SessionDetailViewModel(session)));
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SessionsPage" },
                    { "Method", "RadListView_OnItemTapped" }
                });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DevReach2019.Forms.ViewModels.Sessions;
using DevReach2019.Forms.ViewModels.Speakers;
using DevReach2019.Forms.Views.Speaker;
using Microsoft.AppCenter.Crashes;

namespace DevReach2019.Forms.Views.Session
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionDetailPage : ContentPage
    {
        public SessionDetailPage(SessionDetailViewModel context)
        {
            InitializeComponent();
            BindingContext = context;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if ((BindingContext as SessionDetailViewModel)?.Speakers.Count == 0)
            {
                (BindingContext as SessionDetailViewModel)?.RefreshSpeakersCommand.Execute(null);
            }
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                if (e.SelectedItem is Models.Speaker speaker)
                {
                    await this.Navigation.PushModalAsync(new SpeakerDetailPage(new SpeakerDetailViewModel(speaker, true)));

                    (sender as ListView).SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SessionDetailPage" },
                    { "Method", "OnItemSelected" }
                });
            }
        }

        private void CloseButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync(true);
        }
    }
}
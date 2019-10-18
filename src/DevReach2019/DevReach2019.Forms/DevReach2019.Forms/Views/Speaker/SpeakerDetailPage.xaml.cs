using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevReach2019.Forms.ViewModels.Sessions;
using Xamarin.Forms;
using DevReach2019.Forms.ViewModels.Speakers;
using DevReach2019.Forms.Views.Session;
using Microsoft.AppCenter.Crashes;
using DevReach2019.Forms.Common;

namespace DevReach2019.Forms.Views.Speaker
{
    [DesignTimeVisible(false)]
    public partial class SpeakerDetailPage : ContentPage
    {
        public SpeakerDetailPage(SpeakerDetailViewModel context)
        {
            InitializeComponent();
            BindingContext = context;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if ((BindingContext as SpeakerDetailViewModel)?.SelectedSpeaker.Sessions.Count == 0)
            {
                (BindingContext as SpeakerDetailViewModel)?.RefreshSessionsCommand.Execute(null);
            }

            switch (Device.Idiom)
            {
                case TargetIdiom.Tablet:
                case TargetIdiom.Desktop:
                case TargetIdiom.TV:
                    HeaderTintBorder.BackgroundColor = await Helpers.CalculateBackgroundColorAsync((BindingContext as SpeakerDetailViewModel)?.SelectedSpeaker);
                    break;
            }
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                if (e.SelectedItem is Models.Session session)
                {
                    await this.Navigation.PushModalAsync(new SessionDetailPage(new SessionDetailViewModel(session, true)));

                    (sender as ListView).SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SpeakerDetailPage" },
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevReach2019.Forms.ViewModels.Speakers;
using FFImageLoading.Forms;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace DevReach2019.Forms.Views.Speaker
{
    [DesignTimeVisible(false)]
    public partial class SpeakersPage : ContentPage
    {
        public SpeakersPage()
        {
            InitializeComponent();
            BindingContext = new SpeakersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if ((BindingContext as SpeakersViewModel)?.Speakers.Count == 0)
            {
                (BindingContext as SpeakersViewModel)?.LoadSpeakersCommand.Execute(null);
            }
        }

        private async void RadListView_OnItemTapped(object sender, ItemTapEventArgs e)
        {
            try
            {
                if (e.Item is Models.Speaker speaker)
                {
                    await Navigation.PushAsync(new SpeakerDetailPage(new SpeakerDetailViewModel(speaker)));
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SpeakersPage" },
                    { "Method", "RadListView_OnItemTapped" }
                });
            }
        }

        private void BindableObject_OnBindingContextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is ListViewTemplateCell cell && cell.FindByName<CachedImage>("ProfileImage") is CachedImage image)
                {
                    image.Source = null;

                    if (cell.BindingContext is Models.Speaker speaker)
                    {
                        image.Source = new UriImageSource { Uri = new Uri(speaker.ImageUrl) };
                    }
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SpeakersPage" },
                    { "Method", "FFImageSourceClear" }
                });
            }
        }
    }
}
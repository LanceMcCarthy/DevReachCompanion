using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using DevReach2019.Forms.Services;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace DevReach2019.Forms.ViewModels.Speakers
{
    public class SpeakerDetailViewModel : BaseViewModel
    {
        private Speaker selectedSpeaker;
        private bool isModalButtonVisible;

        public SpeakerDetailViewModel() { }

        public SpeakerDetailViewModel(Speaker item, bool isModal = false)
        {
            RefreshSessionsCommand = new Command(async () => await RefreshSessionsAsync());

            Title = item?.Name;
            SelectedSpeaker = item;

            IsModalButtonVisible = isModal;
        }

        public Speaker SelectedSpeaker
        {
            get => selectedSpeaker;
            set => SetProperty(ref selectedSpeaker, value);
        }

        public bool IsModalButtonVisible
        {
            get => isModalButtonVisible;
            set => SetProperty(ref isModalButtonVisible, value);
        }

        public Command RefreshSessionsCommand { get; set; }

        public async Task RefreshSessionsAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            IsBusyMessage = "Finding speaker's sessions...";

            try
            {
                var sessions = await DependencyService.Get<IDataStore<Session>>().GetItemsAsync();

                foreach (var session in sessions)
                {
                    if (session.SpeakerIds.Contains(SelectedSpeaker.Id))
                    {
                        SelectedSpeaker.Sessions.Add(session);
                    }
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SpeakerDetailViewModel" },
                    { "Method", "RefreshSessionsAsync" },
                    { "SpeakerId", SelectedSpeaker?.Id },
                });
            }
            finally
            {
                IsBusy = false;
                IsBusyMessage = string.Empty;
            }
        }
    }
}

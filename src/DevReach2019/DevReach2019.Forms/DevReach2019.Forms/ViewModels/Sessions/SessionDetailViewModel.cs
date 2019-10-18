using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using DevReach2019.Forms.Services;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace DevReach2019.Forms.ViewModels.Sessions
{
    public class SessionDetailViewModel : BaseViewModel
    {
        private Session selectedSession;
        private bool isModalButtonVisible;

        public SessionDetailViewModel() { }

        public SessionDetailViewModel(Session item, bool isModal = false)
        {
            RefreshSpeakersCommand = new Command(async () => await RefreshSpeakersAsync());

            Title = item?.Title;
            SelectedSession = item;

            IsModalButtonVisible = isModal;
        }

        public Session SelectedSession
        {
            get => selectedSession;
            set => SetProperty(ref selectedSession, value);
        }

        public bool IsModalButtonVisible
        {
            get => isModalButtonVisible;
            set => SetProperty(ref isModalButtonVisible, value);
        }

        public ObservableCollection<Speaker> Speakers { get; } = new ObservableCollection<Speaker>();

        public Command RefreshSpeakersCommand { get; set; }

        public async Task RefreshSpeakersAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            IsBusyMessage = "Finding session's speakers...";

            try
            {
                var speakers = await DependencyService.Get<IDataStore<Speaker>>().GetItemsAsync();

                Speakers.Clear();

                foreach (var speaker in speakers)
                {
                    if (SelectedSession.SpeakerIds.Contains(speaker.Id))
                    {
                        Speakers.Add(speaker);
                    }
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SessionDetailViewModel" },
                    { "Method", "RefreshSpeakersAsync" },
                    { "SessionId", SelectedSession?.Id },
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

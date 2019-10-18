using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using DevReach2019.Forms.Models;
using DevReach2019.Forms.Services;
using DevReach2019.Forms.Views;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.DataControls;

namespace DevReach2019.Forms.ViewModels.Sessions
{
    public class SessionsViewModel : BaseViewModel
    {
        public SessionsViewModel()
        {
            Title = "Sessions";
            LoadSessionsCommand = new Command<RadListView>(async (c) => await LoadSessionsAsync(c));
            ShowCalendarCommand = new Command(async () => await ShowCalendarAsync());
        }

        public ObservableCollection<Session> Sessions { get; } = new ObservableCollection<Session>();

        public Command<RadListView> LoadSessionsCommand { get; set; }

        public Command ShowCalendarCommand { get; set; }

        public async Task LoadSessionsAsync(RadListView lv)
        {
            if(lv == null)
            {
                IsBusy = true;
            }

            try
            {
                Sessions.Clear();

                var items = await DependencyService.Get<IDataStore<Session>>().GetItemsAsync(true);

                foreach (var item in items)
                {
                    Sessions.Add(item);
                }
            }
            catch (Exception ex)
            {
                bool wasManualRefresh = lv != null;

                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SessionsViewModel" },
                    { "Method", "LoadSessionsAsync" },
                    { "WasManualRefresh", wasManualRefresh.ToString() },
                });
            }
            finally
            {
                lv?.EndRefresh(true);
                IsBusy = false;
            }
        }

        private async Task ShowCalendarAsync()
        {
            var agendaVm = new AgendaViewModel();
            var agendaPage = new AgendaPage(agendaVm);

            IsBusy = true;
            IsBusyMessage = "Creating agenda...";

            agendaVm.LoadAgenda(this.Sessions);

            IsBusyMessage = "";
            IsBusy = false;

            await (Application.Current.MainPage as MainPage).Navigation.PushModalAsync(agendaPage, true);
        }
    }
}
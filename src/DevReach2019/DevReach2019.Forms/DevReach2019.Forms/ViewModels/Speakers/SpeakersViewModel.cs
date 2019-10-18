using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using DevReach2019.Forms.Services;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.DataControls;
using Xamarin.Forms;

namespace DevReach2019.Forms.ViewModels.Speakers
{
    public class SpeakersViewModel : BaseViewModel
    {
        public SpeakersViewModel()
        {
            Title = "Speakers";
            LoadSpeakersCommand = new Command<RadListView>(async (c) => await LoadSpeakersAsync(c));
        }

        public ObservableCollection<Speaker> Speakers { get; } = new ObservableCollection<Speaker>();

        public Command<RadListView> LoadSpeakersCommand { get; set; }

        public async Task LoadSpeakersAsync(RadListView lv)
        {
            if (lv == null)
            {
                IsBusy = true;
            }

            try
            {
                Speakers.Clear();
                
                var items = await DependencyService.Get<IDataStore<Speaker>>().GetItemsAsync(true);

                foreach (var item in items)
                {
                    Speakers.Add(item);
                }
            }
            catch (Exception ex)
            {
                bool wasManualRefresh = lv != null;

                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "SpeakersViewModel" },
                    { "Method", "LoadSpeakersAsync" },
                    { "WasManualRefresh", wasManualRefresh.ToString() },
                });
            }
            finally
            {
                lv?.EndRefresh(true);
                IsBusy = false;
            }
        }
    }
}
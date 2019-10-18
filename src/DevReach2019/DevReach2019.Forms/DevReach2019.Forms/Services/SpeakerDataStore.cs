using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace DevReach2019.Forms.Services
{
    public class SpeakerDataStore : IDataStore<Speaker>
    {
        private readonly HttpClient client;
        private IEnumerable<Speaker> speakers;

        public SpeakerDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");

            speakers = new List<Speaker>();
        }

        internal bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public async Task<IEnumerable<Speaker>> GetItemsAsync(bool forceRefresh = false)
        {
            if (!IsConnected)
                return speakers;

            if (!IsLoaded || forceRefresh)
            {
                var json = await client.GetStringAsync($"api/speaker");
                speakers = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Speaker>>(json).ToList());

                IsLoaded = true;
            }

            return speakers;
        }

        public async Task<Speaker> GetItemAsync(string id)
        {
            if (id != null && IsConnected)
            {
                var json = await client.GetStringAsync($"api/speaker/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<Speaker>(json));
            }

            return null;
        }

        public bool IsLoaded { get; set; }
    }
}

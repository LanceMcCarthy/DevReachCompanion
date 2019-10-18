using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace DevReach2019.Forms.Services
{
    public class SessionDataStore : IDataStore<Session>
    {
        private readonly HttpClient client;
        private IEnumerable<Session> sessions;

        public SessionDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");

            sessions = new List<Session>();
        }

        internal bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public async Task<IEnumerable<Session>> GetItemsAsync(bool forceRefresh = false)
        {
            if (!IsConnected)
                return sessions;

            if (!IsLoaded || forceRefresh)
            {
                var json = await client.GetStringAsync($"api/session");
                sessions = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Session>>(json));

                IsLoaded = true;
            }

            return sessions;
        }

        public async Task<Session> GetItemAsync(string id)
        {
            if (id != null && IsConnected)
            {
                var json = await client.GetStringAsync($"api/session/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<Session>(json));
            }

            return null;
        }

        public bool IsLoaded { get; set; }
    }
}

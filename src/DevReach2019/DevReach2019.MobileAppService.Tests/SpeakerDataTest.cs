using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DevReach2019.MobileAppService.Models;
using DevReach2019.MobileAppService.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DevReach2019.MobileAppService.Tests
{
    [TestClass]
    public class SpeakerDataTest
    {
        private readonly IRepository<Speaker> repository;
        private readonly HttpClient client;
        private readonly Random rand;

        public SpeakerDataTest()
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
                handler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            client = new HttpClient(handler);
            repository = new MockSpeakersRepository();
            rand = new Random();
        }

        [TestMethod]
        public async Task GetSpeakers()
        {
            List<Speaker> repositorySpeakers = null;
            List<Speaker> apiSpeakers = null;

            repositorySpeakers = repository.GetAll().ToList();
            var json = await client.GetStringAsync("https://devreach2019.azurewebsites.net/api/speaker");
            apiSpeakers = JsonConvert.DeserializeObject<IEnumerable<Speaker>>(json).ToList();

            Assert.IsNotNull(repositorySpeakers);
            Assert.IsNotNull(apiSpeakers);
            Assert.IsTrue(repositorySpeakers.Any());
            Assert.IsTrue(apiSpeakers.Any());
        }

        [TestMethod]
        public async Task GetSpeaker()
        {
            Speaker randomSpeaker = null;
            Speaker apiSpeaker = null;

            var speakers = repository.GetAll().ToList();
            randomSpeaker = speakers.ElementAt(rand.Next(0, speakers.Count));

            var json = await client.GetStringAsync($"https://devreach2019.azurewebsites.net/api/speaker/{randomSpeaker.Id}");
            apiSpeaker = JsonConvert.DeserializeObject<Speaker>(json);

            Assert.IsNotNull(randomSpeaker);
            Assert.IsNotNull(apiSpeaker);
            Assert.AreEqual(apiSpeaker.Name, randomSpeaker.Name);
        }

        [TestMethod]
        public void CheckForDuplicateIds()
        {
            bool duplicateDiscovered = false;
            var speakers1 = new List<Speaker>(repository.GetAll());
            var speakers2 = new List<Speaker>(repository.GetAll());

            foreach (var speaker1 in speakers1)
            {
                var matchingSpeakers = speakers2.Where(s => s.Id == speaker1.Id).ToList();

                if (matchingSpeakers.Count > 1)
                {
                    duplicateDiscovered = true;

                    Trace.WriteLine($"Duplicate ID used for the following speakers");

                    foreach (var matchingSpeaker in matchingSpeakers)
                    {
                        Trace.WriteLine($"{matchingSpeaker.Name} (ID: {matchingSpeaker.Id})");
                    }
                    
                    break;
                }
            }

            // Confirm that a GUID has not been reused
            Assert.IsFalse(duplicateDiscovered);
        }
    }
}

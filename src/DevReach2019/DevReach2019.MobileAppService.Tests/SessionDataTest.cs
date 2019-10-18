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
    public class SessionDataTest
    {
        private readonly IRepository<Session> repository;
        private readonly HttpClient client;
        private readonly Random rand;

        public SessionDataTest()
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            }

            client = new HttpClient(handler);
            repository = new MockSessionsRepository();
            rand = new Random();
        }

        [TestMethod]
        public async Task GetSessions()
        {
            List<Session> repositorySessions = null;
            List<Session> apiSessions = null;

            repositorySessions = repository.GetAll().ToList();
            var json = await client.GetStringAsync("https://devreach2019.azurewebsites.net/api/session");
            apiSessions = JsonConvert.DeserializeObject<IEnumerable<Session>>(json).ToList();

            Assert.IsNotNull(repositorySessions);
            Trace.WriteLine($"Repository Session Count: {repositorySessions.Count}");

            Assert.IsNotNull(apiSessions);
            Trace.WriteLine($"API Session Count: {apiSessions.Count}");

            Assert.IsTrue(repositorySessions.Any());
            Assert.IsTrue(apiSessions.Any());
        }

        [TestMethod]
        public async Task GetSession()
        {
            Session randomSession = null;
            Session apiSession = null;

            var sessions = repository.GetAll().ToList();
            randomSession = sessions.ElementAt(rand.Next(0, sessions.Count));

            var json = await client.GetStringAsync($"https://devreach2019.azurewebsites.net/api/session/{randomSession.Id}");
            apiSession = JsonConvert.DeserializeObject<Session>(json);

            Assert.IsNotNull(randomSession);
            Assert.IsNotNull(apiSession);
            Assert.AreEqual(apiSession.Title, randomSession.Title);
        }

        [TestMethod]
        public void CheckForDuplicateIds()
        {
            bool duplicateDiscovered = false;
            var sessions1 = new List<Session>(repository.GetAll());
            var sessions2 = new List<Session>(repository.GetAll());

            foreach (var session1 in sessions1)
            {
                var matchingSessions = sessions2.Where(s => s.Id == session1.Id).ToList();

                if (matchingSessions.Count > 1)
                {
                    duplicateDiscovered = true;

                    Trace.WriteLine($"Duplicate ID used for the following speakers");

                    foreach (var session in matchingSessions)
                    {
                        Trace.WriteLine($"{session.Title} (ID: {session.Id})");
                    }

                    break;
                }
            }

            // Confirm that a GUID has not been reused
            Assert.IsFalse(duplicateDiscovered);
        }

        [TestMethod]
        public void CheckForNoSpeakers()
        {
            bool allSessionsHaveSpeakers = true;

            var sessions = repository.GetAll();

            foreach (var session in sessions)
            {
                if (session.SessionType == "Session" || session.SessionType == "Workshop")
                {
                    if (!session.SpeakerIds.Any())
                    {
                        allSessionsHaveSpeakers = false;

                        Trace.WriteLine($"{session.Title} has no speakers!");
                        break;
                    }
                }
            }

            // Check there are no sessions with zero speakers
            Assert.IsTrue(allSessionsHaveSpeakers);
        }

        [TestMethod]
        public void CheckSpeakerIdValid()
        {
            bool containsNullSpeakerId = false;

            var sessions = repository.GetAll();

            foreach (var session in sessions)
            {
                if (session.SessionType == "Session" || session.SessionType == "Workshop")
                {
                    if (session.SpeakerIds.Any(string.IsNullOrEmpty))
                    {
                        containsNullSpeakerId = true;

                        Trace.WriteLine($"{session.Title} has an empty or null speaker ID!");
                        break;
                    }
                }
            }

            // We want to make sure that all speaker IDs are valid strings.
            Assert.IsFalse(containsNullSpeakerId);
        }

        [TestMethod]
        public void CheckSessionOrder()
        {
            bool inOrder = true;

            var sessions = repository.GetAll().ToList();

            for (int i = 0; i < sessions.Count - 1; i++)
            {
                var currentItem = sessions[i];
                var nextItem = sessions[i + 1];

                if (nextItem.StartTime < currentItem.StartTime)
                {
                    Trace.WriteLine($"Sessions not in correct order. '{nextItem.Title}' start time should not be earlier than '{currentItem.Title}'.");
                    inOrder = false;
                    break;
                }
            }

            Assert.IsTrue(inOrder);
        }
    }
}

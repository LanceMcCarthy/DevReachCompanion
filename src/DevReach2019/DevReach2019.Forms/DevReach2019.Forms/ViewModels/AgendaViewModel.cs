using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace DevReach2019.Forms.ViewModels
{
    public class AgendaViewModel : BaseViewModel
    {
        public AgendaViewModel()
        {
        }

        public ObservableCollection<AgendaItem> AgendaItems { get; } = new ObservableCollection<AgendaItem>();

        public void LoadAgenda(IEnumerable<Session> appointmentsSource)
        {
            try
            {
                IsBusy = true;

                foreach (var session in appointmentsSource)
                {
                    AgendaItems.Add(new AgendaItem
                    {
                        Session = session,
                        SessionType = session.SessionType,
                        Title = session.Title,
                        Detail = session.Description,
                        StartDate = session.StartTime,
                        EndDate = session.EndTime,
                        IsAllDay = false
                    });
                }

                AddNonSessionItems();

                AssignColors();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("");
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "AgendaViewModel" },
                    { "Method", "LoadAgendaAsync" }
                });
            }
        }

        private void AddNonSessionItems()
        {
            // Sun

            AgendaItems.Add(new AgendaItem
            {
                Title = "Registration & Coffee",
                SessionType = "Registration",
                StartDate = new DateTime(2019, 10, 20, 8, 30, 0),
                EndDate = new DateTime(2019, 10, 20, 9, 0, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Combined Lunch for both Workshops",
                SessionType = "LunchBreak",
                StartDate = new DateTime(2019, 10, 20, 12, 0, 0),
                EndDate = new DateTime(2019, 10, 20, 13, 0, 0)
            });

            // Mon

            AgendaItems.Add(new AgendaItem
            {
                Title = "Registration & Coffee",
                SessionType = "Registration",
                StartDate = new DateTime(2019, 10, 21, 8, 30, 0),
                EndDate = new DateTime(2019, 10, 21, 9, 0, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Networking & Social Time!",
                SessionType = "Social",
                StartDate = new DateTime(2019, 10, 21, 16, 0, 0),
                EndDate = new DateTime(2019, 10, 21, 18, 0, 0)
            });

            // Tues

            AgendaItems.Add(new AgendaItem
            {
                Title = "Registration & Coffee",
                SessionType = "Registration",
                StartDate = new DateTime(2019, 10, 22, 8, 0, 0),
                EndDate = new DateTime(2019, 10, 22, 8, 45, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Morning Coffee Break",
                SessionType = "CoffeeBreak",
                StartDate = new DateTime(2019, 10, 22, 9, 45, 0),
                EndDate = new DateTime(2019, 10, 22, 10, 30, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Lunch",
                SessionType = "LunchBreak",
                StartDate = new DateTime(2019, 10, 22, 12, 30, 0),
                EndDate = new DateTime(2019, 10, 22, 13, 30, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Afternoon Coffee Break",
                SessionType = "CoffeeBreak",
                StartDate = new DateTime(2019, 10, 22, 15, 20, 0),
                EndDate = new DateTime(2019, 10, 22, 15, 40, 0)
            });

            // Wed

            AgendaItems.Add(new AgendaItem
            {
                Title = "Registration & Coffee",
                SessionType = "Registration",
                StartDate = new DateTime(2019, 10, 23, 8, 0, 0),
                EndDate = new DateTime(2019, 10, 23, 8, 45, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Morning Coffee Break",
                SessionType = "CoffeeBreak",
                StartDate = new DateTime(2019, 10, 23, 9, 45, 0),
                EndDate = new DateTime(2019, 10, 23, 10, 30, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Lunch",
                SessionType = "LunchBreak",
                StartDate = new DateTime(2019, 10, 23, 12, 30, 0),
                EndDate = new DateTime(2019, 10, 23, 13, 30, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Afternoon Coffee Break",
                SessionType = "CoffeeBreak",
                StartDate = new DateTime(2019, 10, 23, 15, 20, 0),
                EndDate = new DateTime(2019, 10, 23, 15, 40, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Sponsor Exhibit",
                SessionType = "Social",
                StartDate = new DateTime(2019, 10, 23, 16, 30, 0),
                EndDate = new DateTime(2019, 10, 23, 17, 30, 0)
            });

            AgendaItems.Add(new AgendaItem
            {
                Title = "Attendee Party!",
                SessionType = "Social",
                StartDate = new DateTime(2019, 10, 23, 19, 0, 0),
                EndDate = new DateTime(2019, 10, 23, 20, 30, 0)
            });

            // Thurs

            AgendaItems.Add(new AgendaItem
            {
                Title = "Registration & Coffee",
                SessionType = "Registration",
                StartDate = new DateTime(2019, 10, 24, 8, 30, 0),
                EndDate = new DateTime(2019, 10, 24, 9, 0, 0)
            });
        }

        private void AssignColors()
        {
            try
            {
                foreach (var item in AgendaItems)
                {
                    // TitleColor and DetailColor defaults are set in the model CTOR

                    switch (item.SessionType)
                    {
                        case "Session":
                            item.Color = (Color)Application.Current.Resources["DevReachDarkBlue"];
                            break;
                        case "Workshop":
                            item.Color = (Color)Application.Current.Resources["DevReachAgendaSelectedBlue"];
                            break;
                        case "Registration":
                            item.Color = Color.SeaGreen;
                            break;
                        case "Social":
                            item.Color = Color.DarkRed;
                            break;
                        case "LunchBreak":
                        case "CoffeeBreak":
                            item.Color = Color.Tan;
                            break;
                        default: //opening statements and prize slots
                            item.Color = Color.Goldenrod;
                            break;
                    }

                    if (item.Session?.Technology?.FirstOrDefault() == ".NET")
                    {
                        item.SessionTechColor = (Color)Application.Current.Resources["DevReachLightBlue"];
                    }

                    if (item.Session?.Technology?.FirstOrDefault() == "JavaScript")
                    {
                        item.SessionTechColor = (Color)Application.Current.Resources["DevReachGreen"];
                    }
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "AgendaViewModel" },
                    { "Method", "AssignColors" }
                });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using DevReach2019.Forms.Models;
using DevReach2019.Forms.Services;
using DevReach2019.Forms.ViewModels.Sessions;
using DevReach2019.Forms.Views;
using DevReach2019.Forms.Views.Session;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.Common;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DevReach2019.Forms.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command<string>(async (d) => await OpenWebsiteAsync(d));
            GoToSessionCommand = new Command(async ()=> await ShowPowerhouseSessionAsync());
        }

        public string TelerikVersion
        {
            get
            {
                var versionNumber = typeof(RadGeometry).GetTypeInfo().Assembly.FullName.Split(',')[1]?.Split('=')[1];
                return $"v {versionNumber}";
            }
        }

        public string AppName => "DevReach Companion";

        public string AppVersion => DependencyService.Get<IVersionService>().Version;

        public string AppDescription => "DevReach Companion is a Xamarin.Forms application with real data supplied by an ASP.NET Web API hosted in Azure.";

        public Command GoToSessionCommand { get; }

        public Command<string> OpenWebCommand { get; }

        private static async Task OpenWebsiteAsync(string destination)
        {
            try
            {
                Uri uri;

                switch (destination)
                {
                    case "xamarin":
                        uri = new Uri("https://dotnet.microsoft.com/apps/xamarin");
                        break;
                    case "web_api":
                        uri = new Uri("https://devreach2019.azurewebsites.net/swagger");
                        break;
                    case "github":
                        uri = new Uri("https://github.com/LanceMcCarthy/DevReach2019");
                        break;
                    case "devops_builds":
                        uri = new Uri("https://dev.azure.com/lance/DevReach%20Companion/_build");
                        break;
                    case "devops_releases":
                        uri = new Uri("https://dev.azure.com/lance/DevReach%20Companion/_release");
                        break;
                    case "telerik":
                    default:
                        uri = new Uri("https://www.telerik.com/xamarin-ui");
                        break;
                }

                await Launcher.OpenAsync(uri);
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "AboutViewModel" },
                    { "Method", "OpenWebsiteAsync" },
                    { "Url", destination },
                });
            }
        }

        private static async Task ShowPowerhouseSessionAsync()
        {
            try
            {
                var session = await DependencyService.Get<IDataStore<Session>>().GetItemAsync("687ed31a-68b5-489d-a25f-8e58bc2ed7ac");
                var page = new SessionDetailPage(new SessionDetailViewModel(session, true));

                await (Application.Current.MainPage as MainPage).Navigation.PushModalAsync(page);
            }
            catch(Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "AboutViewModel" },
                    { "Method", "ShowPowerhouseSession" },
                });
            }
        }
    }
}
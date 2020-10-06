using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using DevReach2020.Forms.Portable.Helpers;
using Microsoft.AppCenter.Crashes;
using Telerik.XamarinForms.Common;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.ViewModels
{
    public class AboutTabViewModel : TabViewModelBase
    {
        private ImageSource headerImgSource;

        public AboutTabViewModel()
        {
            Title = AppConstants.AboutTabName;

            HeaderImgSource = new StreamImageSource
            {
                Stream = token => EmbeddedImageHelpers.GetImage("DevReachBanner.png", token)
            };

            ToggleIsLoadingCommand = new Command(ToggleLoading);

            OpenWebCommand = new Command<string>(async (d) => await OpenWebsiteAsync(d));
        }

        public ImageSource HeaderImgSource
        {
            get => headerImgSource;
            set => SetProperty(ref headerImgSource, value);
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

        public string AppDescription => "DevReach 2020 Companion is a Xamarin.Forms application demonstrating the use of GitHub Actions for CI/CD.";

        public Command<string> OpenWebCommand { get; }

        private static async Task OpenWebsiteAsync(string destination)
        {
            try
            {
                Uri uri;

                switch (destination)
                {
                    case "telerik":
                        uri = new Uri("https://www.telerik.com/xamarin-ui");
                        break;
                    case "xamarin":
                        uri = new Uri("https://dotnet.microsoft.com/apps/xamarin");
                        break;
                    case "github":
                        uri = new Uri("https://github.com/LanceMcCarthy/DevReachCompanion");
                        break;
                    case "github_actions":
                        uri = new Uri("https://github.com/LanceMcCarthy/DevReachCompanion/tree/main/.github/workflows");
                        break;
                    case "wednesday_sessions":
                        uri = new Uri("https://www.telerik.com/devreach/online/agenda-wednesday#sessions");
                        break;
                    default:
                        uri = new Uri("https://www.telerik.com/xamarin-ui");
                        break;
                }

                await Launcher.OpenAsync(uri);
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"OpenWebsiteError: {ex.Message}");

                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "AboutViewModel" },
                    { "Method", "OpenWebsiteAsync" },
                    { "Url", destination },
                });
            }
        }

        private void ToggleLoading()
        {
            IsBusy = !IsBusy;
        }
    }
}
using System;
using System.Reflection;
using System.Threading.Tasks;
using DevReach2020.Forms.Portable.Helpers;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DevReach2020.Forms.Portable.Models
{
    public class AboutTabContext : TabContextBase
    {
        public AboutTabContext()
        {
            Title = "About";
            IconFontCharacter = IconHelpers.AboutTabIcon;
            ToggleIsLoadingCommand = new Command(ToggleLoading);
            OpenWebCommand = new Command<string>(async (d) => await OpenWebsiteAsync(d));
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
                
            }
        }

        private void ToggleLoading()
        {
            IsBusy = !IsBusy;
        }
    }
}
using DevReach2019.Forms.Common;
using DevReach2019.Forms.Models;
using Xamarin.Forms;
using DevReach2019.Forms.Services;
using DevReach2019.Forms.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DevReach2019.Forms
{
    public partial class App : Application
    {
        // Tip - If you enable Swagger, you can see endpoints in readable UI https://devreach2019.azurewebsites.net/swagger/index.html
        public static string AzureBackendUrl = ServiceKeys.AzureAppServiceBaseUrl;

        public IDataStore<Speaker> SpeakerDataStore => DependencyService.Get<IDataStore<Speaker>>();

        public IDataStore<Session> SessionDataStore => DependencyService.Get<IDataStore<Session>>();

        public App()
        {
            InitializeComponent();

            DependencyService.Register<SpeakerDataStore>();
            DependencyService.Register<SessionDataStore>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start($"ios={ServiceKeys.AppCenterAnalytics_iOS};" +
                            $"uwp={ServiceKeys.AppCenterAnalytics_Uwp};" +
                            $"android={ServiceKeys.AppCenterAnalytics_Android}",
                typeof(Analytics), 
                typeof(Crashes));
        }
    }
}

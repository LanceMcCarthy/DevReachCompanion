using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DevReach2020.Forms.Portable
{
    public partial class App
    {
        public App()
        {
            this.MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Note: Use your app's GUID, these will not work for you
            // Visit https://docs.microsoft.com/en-us/appcenter/diagnostics/ for more info
            AppCenter.Start($"ios=6a98417d-b6b9-4916-a00e-8b8b3e8a9faa;" +
                            $"uwp=9478b032-7eea-4d9e-b838-c780b5f23290;" +
                            $"android=f94c9134-845e-4415-93f8-2b89b0d05488",
                typeof(Analytics),
                typeof(Crashes));
        }
    }
}

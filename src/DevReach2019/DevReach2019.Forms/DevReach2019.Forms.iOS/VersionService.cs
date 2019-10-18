using DevReach2019.Forms.Services;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(DevReach2019.Forms.iOS.VersionService))]
namespace DevReach2019.Forms.iOS
{
    public class VersionService : IVersionService
    {
        private string version;
        public string Version
        {
            get
            {
                if (string.IsNullOrEmpty(version))
                {
                    version = $"v{NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"]}";
                }

                return version;
            }
        }
    }
}
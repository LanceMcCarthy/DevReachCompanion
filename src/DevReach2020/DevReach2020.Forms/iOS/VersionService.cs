using DevReach2020.Forms.Portable.Helpers;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(DevReach2020.Forms.iOS.VersionService))]
namespace DevReach2020.Forms.iOS
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
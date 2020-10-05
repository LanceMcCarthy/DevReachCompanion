using DevReach2020.Forms.Portable.Helpers;
using Windows.ApplicationModel;
using Xamarin.Forms;

[assembly: Dependency(typeof(DevReach2020.Forms.UWP.VersionService))]
namespace DevReach2020.Forms.UWP
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
                    var ver = Package.Current.Id.Version;
                    version = $"v{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";
                }

                return version;
            }
        }
    }
}

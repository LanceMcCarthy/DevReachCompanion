using DevReach2019.Forms.Services;
using Xamarin.Forms;
using Application = Android.App.Application;

[assembly: Dependency(typeof(DevReach2019.Forms.Droid.VersionService))]
namespace DevReach2019.Forms.Droid
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
                    version = $"v{Application.Context.ApplicationContext.PackageManager.GetPackageInfo(Application.Context.ApplicationContext.PackageName, 0).VersionName}";
                }

                return version;
            }
        }
    }
}
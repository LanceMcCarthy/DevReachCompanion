using System;
using DevReach2020.Forms.Portable.Helpers;
using Xamarin.Forms;
using Application = Android.App.Application;

[assembly: Dependency(typeof(DevReach2020.Forms.Android.VersionService))]
namespace DevReach2020.Forms.Android
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
                    try
                    {
                        version = $"v{Application.Context.ApplicationContext.PackageManager.GetPackageInfo(Application.Context.ApplicationContext.PackageName, 0).VersionName}";

                    }
                    catch(Exception ex)
                    {
                        version = $"Error: {ex.Message}";
                    }
                }

                return version;
            }
        }
    }
}
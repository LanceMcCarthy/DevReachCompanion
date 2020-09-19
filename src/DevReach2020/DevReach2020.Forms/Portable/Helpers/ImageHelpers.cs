using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DevReach2020.Forms.Portable.Helpers
{
    public static class ImageHelpers
    {
        public static Task<Stream> GetImage(string fileName, CancellationToken token) => 
            Task.Run(() => typeof(ImageHelpers).GetTypeInfo().Assembly.GetManifestResourceStream($"DevReach2020.Forms.Portable.Images.{fileName}"), token);

        public static Task<Stream> GetBannerImage(CancellationToken token) => 
            Task.Run(() => typeof(ImageHelpers).GetTypeInfo().Assembly.GetManifestResourceStream("DevReach2020.Forms.Portable.Images.DevReachBanner.png"), token);

        public static Task<Stream> GetWarriorsImage(CancellationToken token) => 
            Task.Run(() => typeof(ImageHelpers).GetTypeInfo().Assembly.GetManifestResourceStream("DevReach2020.Forms.Portable.Images.TelerikWarriors.png"), token);
    }
}

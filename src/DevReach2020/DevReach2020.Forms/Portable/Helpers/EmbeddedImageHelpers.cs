using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DevReach2020.Forms.Portable.Helpers
{
    public static class EmbeddedImageHelpers
    {
        public static Task<Stream> GetImage(string fileName, CancellationToken token) => 
            Task.Run(() => typeof(EmbeddedImageHelpers).GetTypeInfo().Assembly.GetManifestResourceStream($"DevReach2020.Forms.Portable.Images.{fileName}"), token);
    }
}

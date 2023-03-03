using System.Reflection;

namespace DevReach.Maui.Helpers;

public static class EmbeddedImageHelpers
{
    public static Task<Stream> GetImage(string fileName, CancellationToken token) => 
        Task.Run(() => typeof(EmbeddedImageHelpers).GetTypeInfo().Assembly.GetManifestResourceStream($"DevReach.Maui.Images.{fileName}"), token);
}
using Foundation;
using UIKit;

namespace DevReach2019.Forms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

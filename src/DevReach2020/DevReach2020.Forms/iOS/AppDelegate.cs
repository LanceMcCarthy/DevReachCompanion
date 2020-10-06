using System;
using System.Threading.Tasks;
using Foundation;
using Microsoft.AppCenter.Crashes;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace DevReach2020.Forms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //GlobalExceptionHelper.RegisterForGlobalExceptionHandling();

            if (UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) is UIView statusBar 
                && statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = Color.FromHex("#404894").ToUIColor();
            }

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new Portable.App());

            return base.FinishedLaunching(app, options);
        }
    }

    public static class GlobalExceptionHelper
    {
        public static void RegisterForGlobalExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Crashes.TrackError(new System.Exception("CurrentDomainOnUnhandledException",
                    args.ExceptionObject as System.Exception));
            };

            TaskScheduler.UnobservedTaskException += (sender, args) =>
            {
                Crashes.TrackError(new ApplicationException(
                    "TaskSchedulerOnUnobservedTaskException",
                    args.Exception));
            };
        }
    }
}

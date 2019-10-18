using System;
using System.Collections.Generic;
using System.Reflection;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DevReach2019.Forms.UWP
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += OnNavigationFailed;

                FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

                var config = new FFImageLoading.Config.Configuration
                {
                    VerboseLogging = false,
                    VerbosePerformanceLogging = false,
                    VerboseMemoryCacheLogging = false,
                    VerboseLoadingCancelledLogging = false,
                };

                FFImageLoading.ImageService.Instance.Initialize(config);

                var assembliesToInclude = new List<Assembly>
                {
                    typeof(FFImageLoading.Forms.CachedImage).GetTypeInfo().Assembly,
                    typeof(FFImageLoading.Forms.Platform.CachedImageRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.ConversationalUI.RadChat).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.ConversationalUIRenderer.UWP.ChatListViewRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.ConversationalUIRenderer.UWP.CardActionViewRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Input.RadButton).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.InputRenderer.UWP.ButtonRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.RadBorder).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.PrimitivesRenderer.UWP.BorderRenderer).GetTypeInfo().Assembly,
                    typeof(DevReach2019.Forms.Styles.BlueTheme).GetTypeInfo().Assembly,
                };

                Xamarin.Forms.Forms.Init(e, assembliesToInclude);

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }

            Window.Current.Activate();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
    }
}

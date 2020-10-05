using System;
using System.Collections.Generic;
using System.Reflection;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DevReach2020.Forms.UWP
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                var assembliesToInclude = new List<Assembly>
                {
                    typeof(DevReach2020.Forms.Portable.Styles.BlueThemeStyles).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Input.RadButton).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.InputRenderer.UWP.ButtonRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.RadBorder).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.PrimitivesRenderer.UWP.BorderRenderer).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.RadTabView).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.TabViewHeader).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.TabViewHeaderItem).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.Primitives.TabViewItem).GetTypeInfo().Assembly,
                    typeof(Telerik.XamarinForms.PrimitivesRenderer.UWP.TabViewHeaderItemRenderer).GetTypeInfo().Assembly,
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

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}

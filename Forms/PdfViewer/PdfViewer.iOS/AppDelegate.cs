#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace SampleBrowser.SfPdfViewer.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Syncfusion.ListView.XForms.iOS.SfListViewRenderer.Init();
            Syncfusion.SfPdfViewer.XForms.iOS.SfPdfDocumentViewRenderer.Init();
            Syncfusion.SfRangeSlider.XForms.iOS.SfRangeSliderRenderer.Init();
            Syncfusion.XForms.iOS.PopupLayout.SfPopupLayoutRenderer.Init();
            Syncfusion.XForms.iOS.TabView.SfTabViewRenderer.Init();
            LoadApplication(new App());
            SampleBrowser.Core.iOS.CoreSampleBrowser.Init(UIScreen.MainScreen.Bounds, app.StatusBarFrame.Size.Height);
            return base.FinishedLaunching(app, options);
        }
    }
}

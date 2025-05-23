#region Copyright Syncfusion Inc. 2001-2017.
// ------------------------------------------------------------------------------------
// <copyright file = "AppDelegate.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
// </copyright>
// ------------------------------------------------------------------------------------
#endregion
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Reviewed.")]

namespace SampleBrowser.SfPopupLayout.iOS
{
    using System.Diagnostics.CodeAnalysis;

    using Core.iOS;
    using Foundation;
    using Syncfusion.ListView.XForms.iOS;
    using Syncfusion.SfDataGrid.XForms.iOS;
    using Syncfusion.SfRotator.XForms.iOS;
    using Syncfusion.XForms.iOS.Buttons;
    using Syncfusion.XForms.iOS.PopupLayout;
    using Syncfusion.XForms.iOS.TextInputLayout;
    using UIKit;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.iOS;

    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]

    /// <summary>
    /// The UIApplicationDelegate for the application. This class is responsible for launching the User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    /// </summary>
    public partial class AppDelegate : FormsApplicationDelegate
    {
        /// <summary>
        /// This method is invoked when the application has loaded and is ready to run. In this  method you should instantiate the window, load the UI into it and then make the window visible. You have 17 seconds to return from this method, or iOS will terminate your application.
        /// </summary>
        /// <param name="app">Encapsulates the main processing loop for a mono Touch application type parameter app</param>
        /// <param name="options">Dictionary that provides mapping from keys to values parameter options</param>
        /// <returns>returns base.FinishedLaunching</returns>
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            CoreSampleBrowser.Init(UIScreen.MainScreen.Bounds, app.StatusBarFrame.Size.Height);
            SfPopupLayoutRenderer.Init();
            SfDataGridRenderer.Init();
            SfListViewRenderer.Init();
            SfTextInputLayoutRenderer.Init();
            SfButtonRenderer.Init();
            new SfRotatorRenderer();
            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.Calculate
{
    [Preserve(AllMembers = true)]
    public partial class FunctionsLibrary : SampleView
    {
        public FunctionsLibrary()
        {
            InitializeComponent();
            this.viewModel.InitializePicker(this.picker);
        }

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    this.viewModel.Dispose();
        //}
    }
}
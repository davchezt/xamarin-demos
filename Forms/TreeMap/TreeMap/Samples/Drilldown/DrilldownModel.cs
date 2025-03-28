#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfTreeMap
{
    [Preserve(AllMembers = true)]
    public class DrilldownModel
    {
        public string Continent { get; set; }
        public string States { get; set; }
        public string Region { get; set; }
        public double Population { get; set; }
    }
}

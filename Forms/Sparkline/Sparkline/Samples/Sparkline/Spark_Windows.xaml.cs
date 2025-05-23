#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfSparkline
{
    [Preserve(AllMembers = true)]
    public partial class Spark_Windows : SampleBrowser.Core.SampleView
    {
		public Spark_Windows()
		{
			InitializeComponent();
		}

		public View getContent()
		{
			return this.Content;
		}

		public View getPropertyView()
		{
			return this.PropertyView;
		}
	}
}

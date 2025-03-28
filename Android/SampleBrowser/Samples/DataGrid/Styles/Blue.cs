#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.SfDataGrid;
using Android.Graphics;

namespace SampleBrowser
{
	public class Blue : DataGridStyle
	{
		public Blue ()
		{
		}

        public override Color GetHeaderBackgroundColor()
        {
            return Color.ParseColor("#598CB5");
        }

        public override Color GetHeaderForegroundColor()
        {
            return Color.ParseColor("#FFFFFF");
        }

        public override Color GetRecordForegroundColor()
        {
            return Color.ParseColor("#000000");
        }

        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.ParseColor("#E3F2FD");
        }

        public override Color GetSelectionBackgroundColor()
        {
            return Color.ParseColor("#64B5F6");
        }

        public override Color GetSelectionForegroundColor()
        {
            return Color.ParseColor("#FFFFFF");
        }
        public override Color GetCaptionSummaryRowBackgroundColor ()
		{
			return Color.Rgb (224, 224, 224);
		}

		public override Color GetCaptionSummaryRowForegroundColor ()
		{
			return Color.Rgb (51, 51, 51);
		}

		public override Color GetBorderColor ()
		{
			return Color.Rgb (180, 180, 180);
		}

		public override int GetHeaderSortIndicatorDown ()
		{
			return Resource.Drawable.SortingDown;
		}

		public override int GetHeaderSortIndicatorUp ()
		{
			return Resource.Drawable.SortingUp;
		}

        public override GridLinesVisibility GetGridLinesVisibility()
        {
            return GridLinesVisibility.Horizontal;
        }
    }
}


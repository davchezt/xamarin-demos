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
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Syncfusion.Charts;
using Android.Graphics;
using Com.Syncfusion.Charts.Enums;
using Android.Content.Res;

namespace SampleBrowser
{
    public class SemiDoughnut : SamplePage
    {
        public override View GetSampleContent(Context context)
        {
            var chart = new SfChart(context);
            chart.SetBackgroundColor(Color.White);
            chart.Title.Text = "Products Growth - 2015";
            chart.Title.TextSize = 15;
            chart.Legend.Visibility = Visibility.Visible;
            chart.Legend.DockPosition = ChartDock.Bottom;
			chart.Legend.IconHeight = 14;
			chart.Legend.IconWidth = 14;
            chart.Legend.ToggleSeriesVisibility = true;
          
            var datas = new List<DataPoint>();
            datas.Add(new DataPoint("Product A", 14));
            datas.Add(new DataPoint("Product B", 54));
            datas.Add(new DataPoint("Product C", 23));
            datas.Add(new DataPoint("Product D", 53));

            var doughnutSeries = new DoughnutSeries
            {
				ItemsSource = datas,
				XBindingPath = "XValue",
				YBindingPath = "YValue",
                StartAngle = 180,
                EndAngle = 360
            };
            doughnutSeries.ColorModel.ColorPalette = ChartColorPalette.Natural;
            doughnutSeries.DataMarker.ShowLabel = true;
            doughnutSeries.DataMarker.LabelContent = LabelContent.Percentage;
            doughnutSeries.DataMarkerPosition = CircularSeriesDataMarkerPosition.Outside;
			
            doughnutSeries.EnableAnimation = true;
            chart.Series.Add(doughnutSeries);
            return chart;
        }
    }
}
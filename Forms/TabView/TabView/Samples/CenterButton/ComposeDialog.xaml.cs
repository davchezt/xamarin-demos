#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfTabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComposeDialog : ContentView
    {

        public CenterButton CenterButtonObject { get; set; }
		public ComposeDialog()
		{
			InitializeComponent();
		}

        private void SendButton_Clicked(object sender, EventArgs e)
        {
			this.CenterButtonObject.CloseDialog();
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
          
        }
    }
	public class CustomizedEntry : Entry
    {

    }
}
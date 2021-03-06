﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PathControl.FeaturesCategory.MultiPathExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiPath : ContentView
    {
        public MultiPath()
        {
            this.InitializeComponent();

            this.root.SizeChanged += Root_SizeChanged;
        }

        private void Root_SizeChanged(object sender, System.EventArgs e)
        {
            double size = Math.Min(this.root.Width, this.root.Height / 2);
            this.multiPath.WidthRequest = size;
            this.multiPath.HeightRequest = size;
            this.path2.WidthRequest = size;
            this.path2.HeightRequest = size;
        }
    }
}
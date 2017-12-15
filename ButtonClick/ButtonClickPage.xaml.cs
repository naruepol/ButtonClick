﻿using System;
using Xamarin.Forms;

namespace ButtonClick
{
    public partial class ButtonClickPage : ContentPage
    {

        Label label;
        int clickTotal = 0;

        public ButtonClickPage()
        {
            InitializeComponent();
            Label header = new Label
            {
                Text = "Button",
                //Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            button.Clicked += OnButtonClicked;

            label = new Label
            {
                Text = "0 button clicks",
                //Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, 20, 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    button,
                    label
                }
            };

        }



        void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} button click{1}",clickTotal, clickTotal == 1 ? "" : "s");
        }
    }
}

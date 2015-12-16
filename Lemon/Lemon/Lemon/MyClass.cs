using Android.App;
using System;
using Xamarin.Forms;

namespace Lemon
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                }
            };
        }
    }
}


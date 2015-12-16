using System;
using Xamarin.Forms;

namespace Lemon
{
    public class MyClass : Application
    {
        public MyClass()
        {
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "hello, Form !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                }
            };
        }
    }
}


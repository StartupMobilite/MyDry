using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Lemon.Droid
{
	[Activity (Label = "Lemon.Droid", 
        MainLauncher = true, 
        ConfigurationChanges =ConfigChange.ScreenSize | Configes.Orientation)]

        //Icon = "@drawable/icon")]
	public class MainActivity : FormsApplicationActivity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            //	SetContentView (Resource.Layout.Main);
            Xamarin.Forms.Forms.Init(this, bundle);
            // Get our button from the layout resource,
            // and attach an event to it
            //	Button button = FindViewById<Button> (Resource.Id.myButton);
            LoadApplication(new App());
		//	button.Click += delegate {
		//		button.Text = string.Format ("{0} clicks!", count++);
		//	};
		}
	}
}



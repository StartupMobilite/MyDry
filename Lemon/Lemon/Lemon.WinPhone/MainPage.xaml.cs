using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Lemon.WinPhone
{
    

    public sealed partial class MainPage 
 //   public partial class MainPage : Xamarin.Forms.Platform.WinPhone.FormsApplicationPage // superclass new in 1.3

    {
        public MainPage()
        {
            this.InitializeComponent();
          //  SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            //global::Xamarin.Forms.Forms.Init();
            LoadApplication(new Lemon.App()); // new in 1.3

        }
    }

}


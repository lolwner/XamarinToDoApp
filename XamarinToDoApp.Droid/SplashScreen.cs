using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Views.Attributes;

namespace XamarinToDoApp.Droid
{
    [MvxActivityPresentation]
    [Activity(
        Label = "XamarinToDoApp.Droid"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}

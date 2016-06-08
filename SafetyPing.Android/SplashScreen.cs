using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using MvvmCross.Platform.IoC;

namespace SafetyPing.Android
{
    [Activity(
        Label = "SafetyPing.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
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

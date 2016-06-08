using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using SafetyPing.App.ViewModels;

namespace SafetyPing.Android.Views {
	[Activity(Label = "View for FirstViewModel")]
	public class FirstView : MvxAppCompatActivity<FirstViewModel> {
		int count = 1;
		Toolbar _supporttoolbar;
		DrawerLayout _drawer;
		NavigationView _navigationview;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			_supporttoolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			_supporttoolbar.SetTitle(Resource.String.ApplicationName);
			SetSupportActionBar(_supporttoolbar);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			_drawer = FindViewById<DrawerLayout>(Resource.Id.DrawerLayout);
			_navigationview = FindViewById<NavigationView>(Resource.Id.nav_view);
			_navigationview.NavigationItemSelected += (sender, e) => {
				switch (e.MenuItem.ItemId) {
					case Resource.Id.nav_haveRead:
						Console.WriteLine("Have Read");
						break;

					case Resource.Id.nav_readingNow:
						Console.WriteLine("Reading Now");
						break;

				}
			};
		}
	}
}
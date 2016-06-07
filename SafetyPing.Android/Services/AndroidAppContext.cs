using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Practices.Unity;
using SafetyPing.App.Services;

namespace SafetyPing.Android.Services {
	public class AndroidAppContext : IAppContext {

		public AndroidAppContext(Context androidContext)
		{
			AndroidContext = androidContext;
		}

		public Context AndroidContext { get; set; }

		public void RegisterServices(UnityContainer container)
		{
			container
				.RegisterType<ITelephonyService, TelephonyService>()
			;
		}
	}
}
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
using SafetyPing.App.Services.Location;

namespace SafetyPing.Android.Services {
	public class AndroidLocationService : ILocationService {
		public Location GetLocation()
		{
			return new Location() {
				City = "Poopquette",
				State = "Pichgigan",
				Country = "USA",
				Latitude = 22,
				Longitude = 95
			};
		}
	}
}
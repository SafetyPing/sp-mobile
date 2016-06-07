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
using SafetyPing.App.Services;
using Android.Telephony;

namespace SafetyPing.Android.Services {
	public class TelephonyService : PhoneStateListener, ITelephonyService {
		public event EventHandler<Call> EmergencyCallStarted;

		public void Start(IAppContext genericContext)
		{
			var context = ((AndroidAppContext)genericContext).AndroidContext;
			var manager = (TelephonyManager)context.GetSystemService(Context.TelephonyService);
			manager.Listen(this, PhoneStateListenerFlags.CallState);
		}

		public override void OnCallStateChanged([GeneratedEnum] CallState state, string incomingNumber)
		{
			if (incomingNumber != "911")
				return;

			if (EmergencyCallStarted == null)
				return;

			EmergencyCallStarted(this, new Call() { PhoneNumber = incomingNumber });
		}
	}
}
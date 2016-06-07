using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyPing.App.Services {
	public interface ITelephonyService {
		event EventHandler<Call> EmergencyCallStarted;
		void Start(IAppContext context);
	}

	public class Call {
		public string PhoneNumber;
	}
}

using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyPing.App.Services.Location {
	[ImplementPropertyChanged]
	public class Location {
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
	}
}

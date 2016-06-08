using MvvmCross.Core.ViewModels;
using PropertyChanged;
using SafetyPing.App.Services.Location;

namespace SafetyPing.App.ViewModels 
{
	[ImplementPropertyChanged]
	public class FirstViewModel : MvxViewModel
    {
		public FirstViewModel(ILocationService locationService)
		{
			this.locationService = locationService;

			Location = this.locationService.GetLocation();
			//Location = null;

			if (Location != null) {
				Hello = "Location is good (" + Location.City + ", " + Location.State + ")";
			} else {
				Hello = "There is no location.";
			}
		}

		private ILocationService locationService;

		public Location Location { get; set; }
		public string Hello { get; set; }
    }
}

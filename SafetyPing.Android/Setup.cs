using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform.IoC;

namespace SafetyPing.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

		protected override void InitializeFirstChance()
		{
			// Register the classes in this assembly as services by convention (ends in Service)
			GetType().Assembly
				.CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsDynamic()
			;

			base.InitializeFirstChance();
		}

		protected override IMvxApplication CreateApp()
        {
			return new SafetyPing.App.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}

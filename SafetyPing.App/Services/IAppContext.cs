using Microsoft.Practices.Unity;

namespace SafetyPing.App.Services {
	public interface IAppContext {
		void RegisterServices(UnityContainer container);
	}
}
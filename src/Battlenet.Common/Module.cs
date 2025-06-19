using Battlenet.Common.Components;

namespace Battlenet.Common
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider containerProvider)
        {
        }

        public void Register(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterComponent<Favorite> ();
        }

        public void ViewModelMapper(IViewModelMapper modelMapper)
        {
        }
    }
}

using Battlenet.Common.Components;
using Microsoft.Extensions.DependencyInjection;
using Slate.Navigation;

namespace Battlenet.Common
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider containerProvider)
        {
        }

        public void Register(IServiceCollection services)
        {
        }

        public void RegisterComponent(IComponentRegistry componentRegistry)
        {
            componentRegistry.RegisterComponent<Favorite> ();
        }

        public void ViewModelMapper(IViewModelMapper modelMapper)
        {
        }
    }
}

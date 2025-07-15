using Microsoft.Extensions.DependencyInjection;
using Slate;
using Slate.Navigation;

namespace Battlenet.Game
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
            componentRegistry.RegisterComponent<WarCraft.Content> ();
            componentRegistry.RegisterComponent<OverWatch.Content> ();
            componentRegistry.RegisterComponent<StarCraft.Content> ();
        }

        public void ViewModelMapper(IViewModelMapper modelMapper)
        {
        }
    }
}

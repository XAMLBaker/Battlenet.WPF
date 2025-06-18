using Slate;

namespace Battlenet.Game
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider containerProvider)
        {

        }

        public void Register(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterComponent<WarCraft.Content> ();
            containerRegistry.RegisterComponent<OverWatch.Content> ();
            containerRegistry.RegisterComponent<StarCraft.Content> ();
        }

        public void ViewModelMapper(IViewModelMapper modelMapper)
        {
        }
    }
}

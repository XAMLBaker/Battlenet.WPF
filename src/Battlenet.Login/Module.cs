using FlexMVVM;
namespace Battlenet.Login
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider containerProvider)
        {
        }

        public void Register(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterComponent<Content> ();
        }

        public void ViewModelMapper(IViewModelMapper modelMapper)
        {

        }
    }
}

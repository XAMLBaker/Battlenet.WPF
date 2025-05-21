using FlexMVVM;
using FlexMVVM.Modularity;

namespace SliceFolder.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider containerProvider)
    {

    }

    public void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterLayout<Content> ();
    }
}
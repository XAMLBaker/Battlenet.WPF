using FlexMVVM;
using FlexMVVM.Modularity;
using SliceFolder.Main.Components;

namespace SliceFolder.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider containerProvider)
    {

    }

    public void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterLayout<Layout> ();

        containerRegistry.RegisterLayout<Header> ();
        containerRegistry.RegisterLayout<RightSideBar> ();
        containerRegistry.RegisterLayout<Favorite> ();

        containerRegistry.RegisterLayout<Home.Layout> ();
        containerRegistry.RegisterLayout<Home.Content> ();
    }
}
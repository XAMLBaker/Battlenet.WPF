using FlexMVVM;
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

        containerRegistry.RegisterComponent<Header> ();
        containerRegistry.RegisterComponent<Favorite> ();
        containerRegistry.RegisterComponent<RightSideBar> ();


        containerRegistry.RegisterLayout<Home.Content> ();
        containerRegistry.RegisterLayout<Home.Layout> ();

        containerRegistry.RegisterLayout<Game.Content> ();
        containerRegistry.RegisterLayout<Game.Layout> ();
        containerRegistry.RegisterLayout<Game.Components.LeftSideBar> ();
    }
}
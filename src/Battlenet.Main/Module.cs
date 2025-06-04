using FlexMVVM;
using Battlenet.Main.Components;

namespace Battlenet.Main;

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

        containerRegistry.RegisterLayout<Game.Layout> ();
        containerRegistry.RegisterLayout<Game.Components.LeftSideBar> ();

        containerRegistry.RegisterLayout<Game.MyGames.Content> ();
        containerRegistry.RegisterLayout<Game.Installed.Content> ();
    }
}
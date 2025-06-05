using FlexMVVM;
using Battlenet.Main.Components;
using Microsoft.Extensions.DependencyInjection;
using Battlenet.Service;

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


        containerRegistry.RegisterComponent<Home.Content> ();

        containerRegistry.RegisterLayout<Game.Layout> ();
        containerRegistry.RegisterComponent<Game.Components.LeftSideBar> ();

        containerRegistry.RegisterComponent<Game.MyGames.Content> ();
        containerRegistry.RegisterComponent<Game.Installed.Content> ();
        containerRegistry.RegisterComponent<Game.AllGames.Content> ();


        containerRegistry.Services.AddTransient<BattlenetGameLoad> ();
    }
}
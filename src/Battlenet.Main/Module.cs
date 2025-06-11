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
        containerRegistry.RegisterComponent<Layout> ();

        containerRegistry.RegisterComponent<Header> ();
        containerRegistry.RegisterComponent<Favorite> ();
        containerRegistry.RegisterComponent<RightSideBar> ();

        containerRegistry.RegisterComponent<Home.Content> ();

        containerRegistry.RegisterComponent<Game.Layout> ();
        containerRegistry.RegisterComponent<Game.MyGames.Content> ();
        containerRegistry.RegisterComponent<Game.Installed.Content> ();
        containerRegistry.RegisterComponent<Game.Favorites.Content> ();
        containerRegistry.RegisterComponent<Game.AllGames.Content> ();
        containerRegistry.RegisterComponent<Game.Mobile.Content> ();
        containerRegistry.RegisterComponent<Game.MacOS.Content> ();

        containerRegistry.Services.AddTransient<BattlenetGameLoad> ();
    }

    public void ViewModelMapper(IViewModelMapper modelMapper)
    {

    }
}
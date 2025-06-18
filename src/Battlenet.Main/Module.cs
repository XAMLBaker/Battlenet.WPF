using Battlenet.Main._Shared.Components;
using Battlenet.Service;
using Slate;
using Microsoft.Extensions.DependencyInjection;

namespace Battlenet.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider containerProvider)
    {

    }

    public void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterComponent<Layout> ();
        containerRegistry.RegisterComponent<RightSideBar> ();

        containerRegistry.RegisterComponent<Home.Content> ();

        containerRegistry.RegisterComponent<Games.Layout> ();
        containerRegistry.RegisterComponent<Games.MyGames.Content> ();
        containerRegistry.RegisterComponent<Games.Installed.Content> ();
        containerRegistry.RegisterComponent<Games.Favorites.Content> ();
        containerRegistry.RegisterComponent<Games.AllGames.Content> ();
        containerRegistry.RegisterComponent<Games.Mobile.Content> ();
        containerRegistry.RegisterComponent<Games.MacOS.Content> ();

        containerRegistry.Services.AddTransient<BattlenetGameLoad> ();
    }

    public void ViewModelMapper(IViewModelMapper modelMapper)
    {

    }
}
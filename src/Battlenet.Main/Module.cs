using Battlenet.Main._Shared.Components;
using Battlenet.Service;
using Microsoft.Extensions.DependencyInjection;
using Slate.Navigation;

namespace Battlenet.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider containerProvider)
    {

    }

    public void Register(IServiceCollection services)
    {
        services.AddTransient<BattlenetGameLoad> ();
        services.AddSingleton<Home.ContentModel> ();
    }

    public void RegisterComponent(IComponentRegistry componentRegistry)
    {
        componentRegistry.RegisterComponent<Content> ();
        componentRegistry.RegisterComponent<RightSideBar> ();

        componentRegistry.RegisterComponent<Home.Content> ();

        componentRegistry.RegisterComponent<Games.Content> ();
        componentRegistry.RegisterComponent<Games.MyGames.Content> ();
        componentRegistry.RegisterComponent<Games.Installed.Content> ();
        componentRegistry.RegisterComponent<Games.Favorites.Content> ();
        componentRegistry.RegisterComponent<Games.AllGames.Content> ();
        componentRegistry.RegisterComponent<Games.Mobile.Content> ();
        componentRegistry.RegisterComponent<Games.MacOS.Content> ();
    }

    public void ViewModelMapper(IViewModelMapper modelMapper)
    {
        modelMapper.Register<Home.Content, Home.ContentModel> (reuse: ReuseOption.Singleton);
    }
}
using FlexMVVM;
using FlexMVVM.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SliceFolder.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider containerProvider)
    {

    }

    public void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterLayout<Layout> ();
        containerRegistry.RegisterLayout<Region> ();
        containerRegistry.Services.AddSingleton<LayoutViewModel> ();
    }
}
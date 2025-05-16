using FlexMVVM;
using FlexMVVM.WPF;
using Microsoft.Extensions.DependencyInjection;

namespace SliceFolder.Main;

public class Module : IModule
{
    public void Initialize(IServiceProvider serviceProvider)
    {

    }

    public void Register(IServiceCollection services)
    {
        services.RegisterLayout<Layout> ();
        services.RegisterLayout<Region> ();
        services.AddSingleton<LayoutViewModel> ();
    }
}
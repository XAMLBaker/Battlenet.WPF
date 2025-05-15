using FlexMVVM;
using FlexMVVM.WPF;
using Microsoft.Extensions.DependencyInjection;

namespace SliceFolder.Main;

public class MainModule : IModule
{
    public void Initialize(IServiceProvider serviceProvider)
    {

    }

    public void Register(IServiceCollection services)
    {
        services.RegisterLayout<Layout> ("Main");
    }
}
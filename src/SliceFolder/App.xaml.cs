using FlexMVVM.Modularity;
using FlexMVVM.WPF;
using Microsoft.Extensions.DependencyInjection;

namespace SliceFolder;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : FlexApplication
{
    protected override void Render() => flex.StartWithLayout<Main.Layout> ();

    protected override void ModuleContext(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<Main.Module> ();
        moduleCatalog.AddModule<Sub.Module> ();
    }

    protected override void RegisterService(IServiceCollection services)
    {

    }
}
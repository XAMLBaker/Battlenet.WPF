using FlexMVVM;
using FlexMVVM.WPF;
using Microsoft.Extensions.DependencyInjection;

namespace SliceFolder;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : FlexApplication
{
    protected override void Render() => flex.MainLayout<Main.Layout> ();

    protected override void ModuleContext(FlexAppBuilder builder)
    {
        builder.AddModule<Main.Module> ();
        builder.AddModule<Sub.Module> ();
    }

    protected override void RegisterService(IServiceCollection services)
    {

    }
}
using FlexMVVM;
using FlexMVVM.Modularity;
using FlexMVVM.WPF;
using System.Windows;

namespace SliceFolder;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : FlexApplication
{
    protected override void Render() => flex
                                            .Window (() => new WindowStyle ())
                                            .DefineNestedLayout<Layout> ()
                                            .StartWithLayout<Main.Region>();

    protected override void ModuleContext(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<Main.Module> ();
    }

    protected override void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterLayout<Layout> ();
    }
}
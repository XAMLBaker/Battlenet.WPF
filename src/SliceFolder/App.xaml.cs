using FlexMVVM;
using FlexMVVM.Modularity;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;

namespace SliceFolder;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : FlexApplication
{
    protected override void Render() => flex.DefineNestedLayout<Layout> ()
                                            .StartWithLayout<Main.Content> ();

    protected override void ModuleContext(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<Main.Module> ();
    }

    protected override void Register(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterLayout<Layout> ();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized ();
#if DEBUG
        HotReloadManager.Init (this);
#endif
    }
}
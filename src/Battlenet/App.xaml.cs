namespace Battlenet;

public class BattlenetBootStrapper : Bootstrapper
{
    protected override void ModuleContext(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<Common.Module> ();

        moduleCatalog.AddModule<Login.Module> ();
        moduleCatalog.AddModule<Main.Module> ();
        moduleCatalog.AddModule<Game.Module> ();
    }
}
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup (e);

        new BattlenetBootStrapper ()
               .UseMarkupHotReload (this)
               .StartLayout<Login.Content> ()
               .Run ();
    }
}
namespace Battlenet;

public class BattlenetBootStrapper : AppBootstrapper
{
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
               .AddModule<Common.Module> ()
               .AddModule<Login.Module> ()
               .AddModule<Main.Module> ()
               .AddModule<Game.Module> ()
               .Run ();
    }
}
using Battlenet.Main.Games._Shared.Components;
using Battlenet.Main.Games._Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Battlenet.Main.Games.MacOS;

public partial class Content : Slate.WPF.Markup.Component
{
    [ObservableProperty] ObservableCollection<GameDataModel> gameDatas = new ();
    public override void RegionAttached(object argu)
    {
        base.RegionAttached (argu);

        RegionManager.Attach ("GamesContent", this);

        Application.Current.Dispatcher.Invoke (() =>
        {
            GameDatas = new ObservableCollection<GameDataModel> ((ObservableCollection<GameDataModel>)argu);
        });
    }

    protected override UIElement Build()
        => new GameCard ()
                .Link (ItemsControl.ItemsSourceProperty, nameof (GameDatas));
}

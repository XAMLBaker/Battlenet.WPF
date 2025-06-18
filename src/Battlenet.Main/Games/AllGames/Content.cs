using Battlenet.Main.Games._Shared.Components;
using Battlenet.Main.Games._Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Slate.WPF;
using Slate.WPF.Markup;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Games.AllGames;

public partial class Content : Slate.WPF.Markup.Component
{
    [ObservableProperty] ObservableCollection<GameDataModel> gameDatas = new ();
    public override void RegionAttached(object argu)
    {
        base.RegionAttached (argu);

        RegionManager.Attach ("GameContent", this);

        Application.Current.Dispatcher.Invoke (() =>
        {
            GameDatas = new ObservableCollection<GameDataModel>((ObservableCollection<GameDataModel>)argu);
        });
    }

    protected override Visual Build()
        => new GameCard ()
                .Link (ItemsControl.ItemsSourceProperty, nameof(GameDatas));
}

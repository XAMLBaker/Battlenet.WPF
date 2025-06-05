using Battlenet.Main.Game.Components;
using Battlenet.Main.Game.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game.AllGames;

public partial class Content : Component
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

using Battlenet.Main.Game.Components;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Battlenet.Main.Game.AllGames;

public partial class Content : Component
{
    public override void RegionAttached()
    {
        base.RegionAttached ();

        RegionManager.Attach ("GameContent", this);
    }

    protected override Visual Build()
        => new UniformGrid ()
                .Columns (5)
                .Children (
                    new WebImageComponent (),
                    new WebImageComponent ()
                )
               .Background (Colors.Transparent);
}

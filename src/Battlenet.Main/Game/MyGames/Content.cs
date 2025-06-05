using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Battlenet.Main.Game.MyGames;

public partial class Content : Component
{
    public override void RegionAttached(object argu)
    {
        base.RegionAttached (argu);

        RegionManager.Attach ("GameContent", this);
    }
    protected override Visual Build()
        => new UniformGrid ()
                .Columns (5)
                .Children (
                    
                )
               .Background (Colors.Transparent);
}

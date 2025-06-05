using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game.Installed;

public partial class Content : Component
{
    public override void RegionAttached(object argu)
    {
        base.RegionAttached (argu);

        RegionManager.Attach ("GameContent", this);
    }
    protected override Visual Build()
        => new Grid ().Background(Colors.Red);
}

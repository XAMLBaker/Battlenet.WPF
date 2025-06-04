using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game.Installed;

public partial class Content : Component
{
    protected override Visual Build()
        => new Grid ().Background(Colors.Red);
}

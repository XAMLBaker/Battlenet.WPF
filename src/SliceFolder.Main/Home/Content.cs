using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Home
{
    public partial class Content : Component
    {
        protected override Visual Build()
            => new Grid ()
                    .Background (Colors.Red);
    }
}

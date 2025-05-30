using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Home.Components
{
    public partial class Header : Component
    {
        protected override Visual Build()
            => new Grid ()
                .Background (Colors.Green)
                .Height(100);
    }
}

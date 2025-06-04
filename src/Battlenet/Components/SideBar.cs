using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Components
{
    public partial class SideBar : Component
    {
        protected override Visual Build()
            => new Grid()
                    .Background(Colors.Red);
    }
}

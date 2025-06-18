using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main._Shared.Components
{
    public partial class RightSideBar : Component
    {
        protected override Visual Build()
            => new Grid ();
    }
}

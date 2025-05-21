using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Components
{
    public partial class SideBar : Component
    {
        protected override Visual Build()
            => new ListBox ();
    }
}

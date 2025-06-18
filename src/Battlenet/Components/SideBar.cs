using Slate.WPF;
using Slate.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Components
{
    public partial class SideBar : Slate.WPF.Markup.Component
    {
        protected override Visual Build()
            => new Grid()
                    .Background(Colors.Red);
    }
}

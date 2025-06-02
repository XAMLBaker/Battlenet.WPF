using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Media;

namespace SliceFolder.Main.Game.Components
{
    public partial class LeftSideBar : Component
    {
        protected override Visual Build()
            => new VStack ()
                    .Children (
                         new GameSearchBox()
                    );
    }
}

using FlexMVVM.WPF.Markup;
using SliceFolder.Main.Components;
using SliceFolder.Main.Game.Components;
using System.Windows;
using System.Windows.Controls;

namespace SliceFolder.Main.Game
{
    public partial class Layout : LayoutComponent
    {
        private readonly Header _header;
        private readonly Favorite _favorite;
        private readonly LeftSideBar _leftSideBar;

        public Layout(Header header, Favorite favorite, LeftSideBar leftSideBar)
        {
            this._header = header;
            this._favorite = favorite;
            this._leftSideBar = leftSideBar;
            this.Margin (leftright: 23);
        }
        protected override IEnumerable<UIElement> Build()
            => new List<UIElement> (){
                        _header
                            .SetDock (Dock.Top),
                        _favorite
                            .SetDock (Dock.Top)
                            .Margin (bottom: 30),
                         this._leftSideBar
                            .SetDock(Dock.Left)
                            .Margin(right: 33)
                            .Top()
                   };
    }
}

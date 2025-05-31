using FlexMVVM.WPF.Markup;
using SliceFolder.Main.Components;
using System.Windows;
using System.Windows.Controls;

namespace SliceFolder.Main.Home
{
    public partial class Layout : LayoutComponent
    {
        private readonly Header _header;
        private readonly Favorite _favorite;
        public Layout(Header header, Favorite favorite)
        {
            this._header = header;
            this._favorite = favorite;

            this.Margin (leftright: 23);
        }
        protected override IEnumerable<UIElement> Build()
            => new List<UIElement> ()
            {
                 this._header
                     .SetDock(Dock.Top),
                this._favorite
                    .SetDock(Dock.Top)
                    .Margin(bottom:30)                            
            };
    }
}

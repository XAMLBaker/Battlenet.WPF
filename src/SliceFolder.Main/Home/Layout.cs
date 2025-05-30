using FlexMVVM.WPF.Markup;
using SliceFolder.Main.Components;
using System.Windows;
using System.Windows.Controls;

namespace SliceFolder.Main.Home
{
    public partial class Layout : LayoutComponent
    {
        private readonly Favorite _favorite;

        public Layout(Favorite favorite) : base()
        {
            this._favorite = favorite;
        }
        protected override IEnumerable<UIElement> Build()
            => new List<UIElement> ()
            {
                _favorite.SetDock(Dock.Top)
            };
    }
}

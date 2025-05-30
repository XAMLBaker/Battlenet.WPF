using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using SliceFolder.Common.Components;
using SliceFolder.Main.Components;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main
{
    public partial class Layout : LayoutComponent
    {
        private readonly RightSideBar _rightSideBar;

        public Layout(RightSideBar rightSideBar) : base ()
        {
            this.Width = 1600;
            this.Height = 1000;
            this._rightSideBar = rightSideBar;
            this._rightSideBar.SetDock (Dock.Right);
        }
        protected override IEnumerable<UIElement> Build()
            => new List<UIElement>() {
                new FlexPanel()
                    .Justify(JustifyContent.End)
                    .Children(
                        new WindowButton (WindowButtonType.MINIAML)
                            .Background (Colors.Transparent, "#23252b")
                            .Foreground ("#4a4c51", "#ffffff")
                            .Height (22)
                            .Width (37),
                        new WindowButton (WindowButtonType.EXIT)
                            .Background (Colors.Transparent, "#dd1313")
                            .Foreground ("#4a4c51", "#ffffff")
                            .Height (22)
                            .Width (37)
                    ).SetDock(Dock.Top),
                _rightSideBar.SetDock(Dock.Right),
                new Header().SetDock(Dock.Top)
            };
    }
}

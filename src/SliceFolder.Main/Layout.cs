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
        private readonly IWindowManager _windowManager;
        private readonly RightSideBar _rightSideBar;

        public Layout(IWindowManager windowManager ,RightSideBar rightSideBar)
        {
            this.Width = 1600;
            this.Height = 1000;
            this.Background = BrushTool.Get ("#15181e");
            this._windowManager = windowManager;
            this._rightSideBar = rightSideBar;
            this._rightSideBar.SetDock (Dock.Right);
        }

        protected override void OnRender(object sender)
        {
            base.OnRender (sender);
            this._windowManager.CornerRadius (15);
        }

        protected override IEnumerable<UIElement> Build()
            => new List<UIElement>() {
                new FlexPanel()
                    .Background("#15181e")
                    .Justify(JustifyContent.End)
                    .SetDock(Dock.Top)
                    .Margin(bottom:7)
                    .Children(
                        new WindowButton (WindowButtonType.MINIAML)
                            .Background (Colors.Transparent, "#23252b")
                            .Foreground ("#4a4c51", "#ffffff")
                            .Height (23)
                            .Width (37),
                        new WindowButton (WindowButtonType.EXIT)
                            .Background (Colors.Transparent, "#dd1313")
                            .Foreground ("#4a4c51", "#ffffff")
                            .Height (23)
                            .Width (37)
                    ),
            };
    }
}

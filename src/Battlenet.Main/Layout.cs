using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using Battlenet.Common.Components;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main
{
    public partial class Layout : LayoutComponent
    {
        private readonly IWindowManager _windowManager;

        public Layout(IWindowManager windowManager)
        {
            this.Width = 1600;
            this.Height = 900;
            this.Background = BrushTool.Get ("#15181e");
            this._windowManager = windowManager;
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
                    )
            };
    }
}

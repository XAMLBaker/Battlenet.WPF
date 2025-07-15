﻿using Battlenet.Common.Components;
using Battlenet.Main._Shared.Components;

namespace Battlenet.Main
{
    public partial class Content : Slate.WPF.Markup.Component
    {
        private readonly ILayoutNavigator _layoutNavigator;
        private readonly IWindowManager _windowManager;

        public Content(ILayoutNavigator layoutNavigator,
                    IWindowManager windowManager)
        {
            this._layoutNavigator = layoutNavigator;
            this.Width = 1600;
            this.Height = 900;
            this._windowManager = windowManager;
        }

        public override void RegionAttached(object argu)
        {
            base.RegionAttached (argu);

            RegionManager.Attach ("Root", this);
        }
        protected override void OnRender(object sender)
        {
            base.OnRender (sender);
        }

        protected override UIElement Build()
            => new DockPanel ()
                  .Children (
                      new FlexPanel ()
                        .Background ("#15181e")
                        .Justify (JustifyContent.End)
                        .SetDock (Dock.Top)
                        .Margin (bottom: 7)
                        .Children (
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
                      new Border()
                        .Padding(leftright:23)
                        .Child (
                              new Grid ()
                                .Columns ("*, auto")
                                .Children (
                                    new Grid()
                                        .Column (0)
                                        .Children(
                                            new SlateRegionControl ("Content"),
                                            new Header(this._layoutNavigator).Top (),
                                            new SlateRegionControl ("SubHeader").Top ().Margin(top:70)
                                        )
                                )
                        )
                  ).Background("#15181e");
    }
}

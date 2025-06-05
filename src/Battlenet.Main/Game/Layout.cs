using Battlenet.Main.Game.Components;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game
{
    public partial class Layout : Component
    {
        private readonly ILayoutNavigator _layoutNavigator;

        public Layout(ILayoutNavigator layoutNavigator)
        {
            this._layoutNavigator = layoutNavigator;
        }

        public override void RegionAttached()
        {
            base.RegionAttached ();

            RegionManager.Attach ("Content", this);
        }

        protected override void InitilzedForms()
        {
            this.Background (new RadialGradientBrush (new GradientStopCollection (new List<GradientStop>
                                                                                    {
                                                                                           new GradientStop (ColorTool.Get ("#0e243b"), 0.0),
                                                                                           new GradientStop (ColorTool.Get ("#10222d"), 0.3),
                                                                                           new GradientStop (ColorTool.Get ("#15171e"), 1.0)
                                                                                    }))
            {
                Center = new Point (0.2, 0.5)
            });
        }

        protected override Visual Build()
            => new DockPanel()
                .Children(
                    new LeftSideBar (this._layoutNavigator)
                            .SetDock (Dock.Left)
                            .Margin (right: 33)
                            .Top (),
                    new FlexRegion("GameContent")
                );
    }
}

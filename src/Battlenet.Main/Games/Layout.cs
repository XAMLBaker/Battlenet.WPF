using Battlenet.Common.Components;
using Battlenet.Main.Components;
using Battlenet.Main.Games.Components;
using Battlenet.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using DryIoc;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Games
{
    public partial class Layout : Component
    {
        private readonly IContainer _container;
        private readonly ILayoutNavigator _layoutNavigator;
        private readonly BattlenetGameLoad _battlenetGameLoad;
        [ObservableProperty] string tabTitle = null;
        public Layout(ILayoutNavigator layoutNavigator,
                      BattlenetGameLoad battlenetGameLoad,
                      IContainer container)
        {
            this._container = container;
            this._layoutNavigator = layoutNavigator;
            this._battlenetGameLoad = battlenetGameLoad;
        }

        public override void RegionAttached(object argu)
        {
            base.RegionAttached (argu);

            RegionManager.Attach ("SubHeader", this._container.Resolve<Favorite> ());
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
                .Margin (top: 150)
                .Children(
                     new LeftSideBar (_layoutNavigator, _battlenetGameLoad)
                                .SetDock (Dock.Left)
                                .Margin (right: 33)
                                .UpdateTile (s =>
                                {
                                    TabTitle = s;
                                })
                                .Top (),
                    new VStack()
                        .Top ()
                        .Children(
                            new HStack ()
                                .Left ()
                                .Margin(bottom: 16)
                                .Children (
                                    new TextBlock ()
                                        .FontSize(24)
                                        .FontWeight(FontWeights.Bold)
                                        .Link(nameof(TabTitle))
                                        .Foreground (Colors.White),
                                    new TextBlock ()
                                        .Text ("Sort by:")

                                ),
                            new FlexRegion ("GamesContent")
                            {
                                Transition = TransitionType.Fade
                            }
                        )
                ).Link(BackgroundProperty, nameof(Background), this);
    }
}

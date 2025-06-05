using Battlenet.Main.Game.Components;
using Battlenet.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game
{
    public partial class Layout : Component
    {
        private readonly LeftSideBar _leftSideBar;
        [ObservableProperty] string tabTitle = null;
        public Layout(ILayoutNavigator layoutNavigator,
                      BattlenetGameLoad battlenetGameLoad)
        {
            _leftSideBar = new LeftSideBar (layoutNavigator, battlenetGameLoad);
            _leftSideBar.Title += (string s) =>
            {
                TabTitle = s;
            };
        }

        public override void RegionAttached(object argu)
        {
            base.RegionAttached (argu);

            RegionManager.Attach ("Content", this);
        }

        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            base.OnLoaded (sender, e);

            _leftSideBar.LoadGameData ();
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
                    _leftSideBar.SetDock (Dock.Left)
                                .Margin (right: 33)
                                .Top (),
                    new VStack()
                        .Children(
                            new HStack ()
                                .Children (
                                    new TextBlock ()
                                        .Link(nameof(TabTitle))
                                        .Foreground (Colors.White),
                                    new TextBlock ()
                                        .Text ("Sort by:")

                                ),
                            new FlexRegion("GameContent")
                        )
                );
    }
}

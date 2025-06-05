using Battlenet.Main.Game.Components;
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
        private readonly ILayoutNavigator _layoutNavigator;
        private readonly LeftSideBar _leftSideBar;
        [ObservableProperty] string tabTitle = null;
        public Layout(ILayoutNavigator layoutNavigator)
        {
            this._layoutNavigator = layoutNavigator;
            _leftSideBar = new LeftSideBar (this._layoutNavigator);

            _leftSideBar.Title += (string s) =>
            {
                TabTitle = s;
            };
        }

        public override void RegionAttached()
        {
            base.RegionAttached ();

            RegionManager.Attach ("Content", this);
        }

        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            base.OnLoaded (sender, e);


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

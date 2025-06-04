using FlexMVVM.WPF.Markup;
using Battlenet.Main.Components;
using Battlenet.Main.Game.Components;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game
{
    public partial class Layout : LayoutComponent
    {
        private readonly Header _header;
        private readonly Favorite _favorite;
        private readonly LeftSideBar _leftSideBar;

        public Layout(Header header, Favorite favorite, LeftSideBar leftSideBar)
        {
            this._header = header;
            this._favorite = favorite;
            this._leftSideBar = leftSideBar;
            this.Margin (leftright: 23);
            this.ClipToBounds = false;
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

        protected override IEnumerable<UIElement> Build()
            => new List<UIElement> (){
                        _header
                            .SetDock (Dock.Top),
                        _favorite
                            .SetDock (Dock.Top)
                            .Margin (bottom: 30),
                         this._leftSideBar
                            .SetDock(Dock.Left)
                            .Margin(right: 33)
                            .Top()
                   };
    }
}

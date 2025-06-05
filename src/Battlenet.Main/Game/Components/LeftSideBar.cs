using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Game.Components
{
    public partial class LeftSideBar : Component
    {
        private readonly ILayoutNavigator _layoutNavigator;

        public LeftSideBar(ILayoutNavigator layoutNavigator)
        {
            this._layoutNavigator = layoutNavigator;
        }

        protected override Visual Build()
            => new Grid ()
                    .Columns ("*")
                    .Rows ("auto, auto, auto, auto, auto, auto, auto, auto, auto, auto")
                    .AddChild (new GameSearchBox (), row: 0)
                    .AddChild (new FlexDivider ()
                                  .Margin(topbottom:10)
                                  .Background ("#31363f"), row: 1)
                    .AddChild (TabItemTemplate ("My Games")
                                    .OnCheckedAsync(async()=>
                                    {
                                        await this._layoutNavigator.NavigateToAsync ("/Battlenet/Main/Game/MyGames");
                                    }), row: 2)
                    .AddChild (TabItemTemplate ("Installed")
                                    .OnCheckedAsync (async () =>
                                    {
                                        await this._layoutNavigator.NavigateToAsync ("/Battlenet/Main/Game/Installed");
                                    }), row: 3)
                    .AddChild (TabItemTemplate ("Favorites")
                                    .OnChecked (() =>
                                    {

                                    }), row: 4)
                    .AddChild (new FlexDivider ()
                                  .Margin (topbottom: 10)
                                  .Background ("#31363f"), row: 5)
                    .AddChild (TabItemTemplate ("All Games")
                                    .OnChecked (() =>
                                    {

                                    }), row: 6)
                    .AddChild (TabItemTemplate ("Start For Free")
                                    .OnChecked (() =>
                                    {

                                    }), row: 7)
                    .AddChild (TabItemTemplate ("Mobile")
                                    .OnChecked (() =>
                                    {

                                    }), row: 8)
                    .AddChild (TabItemTemplate ("MacOS")
                                    .OnChecked (() =>
                                    {

                                    }), row: 9);

        private TabItem TabItemTemplate(string name)
            => new TabItem ()                  
                    .Content (
                        new Label()
                            .Foreground(Colors.White)
                            .FontSize(13)
                            .Content (name)
                    );
    }
}

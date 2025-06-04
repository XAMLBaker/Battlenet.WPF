using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Game.Components
{
    public partial class LeftSideBar : Component
    {
        protected override Visual Build()
            => new Grid ()
                    .Columns ("*")
                    .Rows ("auto, auto, auto, auto, auto, auto, auto, auto, auto, auto")
                    .AddChild (new GameSearchBox (), row: 0)
                    .AddChild (new FlexDivider ()
                                  .Margin(topbottom:10)
                                  .Background ("#31363f"), row: 1)
                    .AddChild (TabItemTemplate ("내 게임"), row: 2)
                    .AddChild (TabItemTemplate ("설치됨"), row: 3)
                    .AddChild (TabItemTemplate ("즐겨찾기"), row: 4)
                    .AddChild (new FlexDivider ()
                                  .Margin (topbottom: 10)
                                  .Background ("#31363f"), row: 5)
                    .AddChild (TabItemTemplate ("전체 게임"), row: 6)
                    .AddChild (TabItemTemplate ("무료로 시작"), row: 7)
                    .AddChild (TabItemTemplate ("모바일"), row: 8)
                    .AddChild (TabItemTemplate ("MacOS"), row: 9);

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

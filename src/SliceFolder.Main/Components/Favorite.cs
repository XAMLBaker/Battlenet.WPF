using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using SliceFolder.Common.Components;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Components
{
    public partial class Favorite : Component
    {
        protected override Visual Build()
            => new Border ()
                  .Height (56)
                  .CornerRadius (5)
                  .Background ("#26272f")
                  .Child (
                      new HStack ()
                         .VCenter()
                         .Spacing (10)
                         .Children (
                                new TextBlock ()
                                    .Text ("즐겨찾기"),
                                GameButton (GameIcon.WorldOfCraft),
                                GameButton (GameIcon.Overwatch),
                                GameButton (GameIcon.WorldOfCraftClassic),
                                GameButton (GameIcon.Hearthstone),
                                GameButton (GameIcon.Diablo3),
                                GameButton (GameIcon.StarCraft2),
                                GameButton (GameIcon.StarCraft)
                         )
                  );

        private GroupButton GameButton(Viewbox content)
            => new GroupButton ()
                    .Height (64)
                    .Width (64)
                    .Background (Colors.Transparent)
                    .Content (
                        content
                            .Width (40)
                            .Height (40)
                            .Margin(top:3)
                    )
                    .OnHover ((el) =>
                    {
                        content.Margin (top: 0);
                        if (el.IsChecked.Value)
                            return;
                        el.Background("#313338");
                    })
                    .OnRelease ((el) =>
                    {
                        content.Margin (top: 3);
                        if (el.IsChecked.Value)
                            return;
                        el.Background(Colors.Transparent);
                    });
    }
}

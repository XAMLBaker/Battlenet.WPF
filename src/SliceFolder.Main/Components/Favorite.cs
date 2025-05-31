using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using SliceFolder.Common.Components;
using System.Windows;
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
                  .Padding(leftright: 10)
                  .Background ("#26272f")
                  .Child (
                      new HStack ()
                      {
                          Spacing = 20
                      }
                      .Left().VCenter()
                      .Children (
                          new TextBlock ()
                              .Text ("즐겨찾기")
                              .VCenter()
                              .Foreground("#8c8e80")
                              .FontSize(13)
                              .FontWeight(FontWeights.Bold),
                          GameButton (GameIcon.WorldOfCraft
                                              .Width (35)
                                              .Height (35)),
                          GameButton (GameIcon.Overwatch
                                              .Width (38)
                                              .Height (38)),
                          GameButton (GameIcon.WorldOfCraftClassic
                                              .Width (38)
                                              .Height (38)),
                          GameButton (GameIcon.Hearthstone
                                              .Width (38)
                                              .Height (38)),
                          GameButton (GameIcon.Diablo3
                                              .Width (38)
                                              .Height (38)),
                          GameButton (GameIcon.StarCraft2
                                              .Width (38)
                                              .Height (38)),
                          GameButton (GameIcon.StarCraft
                                              .Width(38)
                                              .Height(32)),
                          GameButton (GameIcon.HeroesOfTheStorm
                                              .Width (32)
                                              .Height (37))
                      )
                  );

        private GroupButton GameButton(Viewbox content)
            => new GroupButton ()
                    .Height (64)
                    .Width (64)
                    .Background (Colors.Transparent)
                    .Content (
                        content
                            .Margin (top: 5)
                    )
                    .OnHover ((el) =>
                    {
                        content.MarginAnimation (top: 0);
                        if (el.IsChecked.Value)
                            return;
                        el.Background("#313338");
                    })
                    .OnRelease ((el) =>
                    {
                        if (el.IsChecked.Value)
                            return;
                        content.MarginAnimation (top: 5);
                        el.Background(Colors.Transparent);
                    });
    }
}

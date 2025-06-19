using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Battlenet.Common.Components
{
    public partial class Favorite : Slate.WPF.Markup.Component
    {
        private readonly ILayoutNavigator _layoutNavigator;

        public Favorite(ILayoutNavigator layoutNavigator)
        {
            this._layoutNavigator = layoutNavigator;
        }
        protected override Visual Build()
            => new Border ()
                  .Child (
                      new Grid()
                        .Height (56)
                        .Children(
                              new Border ()
                                  .Background("#26272f")
                                  .CornerRadius (5)
                                  .Opacity(0.8),
                              new HStack ()
                              {
                                  Spacing = 20
                              }
                              .Margin(leftright:10)
                              .Left().VCenter()
                              .Children (
                                  new TextBlock ()
                                      .Text ("FAVORITES")
                                      .VCenter()
                                      .Foreground("#8c8e80")
                                      .FontSize(13)
                                      .FontWeight(FontWeights.Bold),
                                  new HStack()
                                  .Children(
                                          GameButton (DotFour(), GameIcon.WorldOfCraft
                                                                         .Width (35)
                                                                         .Height (35))
                                                     .OnCheckedAsync (async() =>
                                                     {
                                                         await this._layoutNavigator.NavigateToAsync (RouteNames.WarCraft);
                                                     }),
                                          GameButton (DotFour (), GameIcon.Overwatch
                                                                          .Width (38)
                                                                          .Height (38))
                                                     .OnCheckedAsync (async () =>
                                                     {
                                                         await this._layoutNavigator.NavigateToAsync (RouteNames.OverWatch);
                                                     }),
                                          GameButton (DotFour (), GameIcon.WorldOfCraftClassic
                                                                        .Width (38)
                                                                        .Height (38)),
                                          GameButton (DotFour (), GameIcon.Hearthstone
                                                                      .Width (38)
                                                                      .Height (38)),
                                          GameButton (DotFour (), GameIcon.Diablo3
                                                                      .Width (38)
                                                                      .Height (38)),
                                          GameButton (DotFour (), GameIcon.StarCraft2
                                                                          .Width (38)
                                                                          .Height (38)),
                                          GameButton (DotFour (), GameIcon.StarCraft
                                                                      .Width(38)
                                                                      .Height(32))
                                                     .OnCheckedAsync (async () =>
                                                     {
                                                         await this._layoutNavigator.NavigateToAsync (RouteNames.StarCraft);
                                                     }),
                                          GameButton (DotFour (), GameIcon.HeroesOfTheStorm
                                                                      .Width (32)
                                                                      .Height (37))
                                  )
                              )
                        )
                  );

        private GroupButton GameButton(Path dotFour, Viewbox content)
            => new GroupButton ()
                    .Height (64)
                    .Width (64)
                    .Background (Colors.Transparent)
                    .Content (
                        new VStack(){
                            Spacing = 3
                        }
                        .Margin(top:4)
                        .Children(
                                dotFour
                                    .Opacity(0),
                                content
                        )
                    )
                    .OnUnchecked ((el) =>
                    {
                        el.Background (Colors.Transparent);
                    })
                    .OnHover ((el) =>
                    {
                        dotFour.OpacityAnimation(1.0, 100);
                        content.TransitionYAnimation (value:-2, EasingMode.EaseIn, durationValue:200);
                        if (el.IsChecked.Value)
                            return;
                        el.Background("#313338");
                    })
                    .OnRelease ((el) =>
                    {
                        dotFour.OpacityAnimation (0.0, 100);
                        content.TransitionYAnimation (0.0, easingMode: EasingMode.EaseOut, durationValue: 200);
                        if (el.IsChecked.Value)
                            return;
                        el.Background(Colors.Transparent);
                    });
        private Path DotFour()
            => new Path ()
            {
                Data = new GeometryGroup ()
                {
                    Children = new GeometryCollection ()
                                        {
                                            new EllipseGeometry()
                                            {
                                                Center = new Point(2,2),
                                                RadiusX = 1.2,
                                                RadiusY = 1.2
                                            },
                                             new EllipseGeometry()
                                            {
                                                Center = new Point(6,2),
                                                RadiusX = 1.2,
                                                RadiusY = 1.2
                                            },
                                            new EllipseGeometry()
                                            {
                                                Center = new Point(10,2),
                                                RadiusX = 1.2,
                                                RadiusY = 1.2
                                            },
                                             new EllipseGeometry()
                                            {
                                                Center = new Point(14,2),
                                                RadiusX = 1.2,
                                                RadiusY = 1.2
                                            }
                                        }
                }
            }
            .HCenter ()
            .Fill ("#5d595a");
    }
}

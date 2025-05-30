using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SliceFolder.Main.Components
{
    public partial class Header : Component
    {
        protected override Visual Build()
            => new FlexPanel ()
                   .Justify (JustifyContent.SpaceBetween)
                   .Height (100)
                   .Background (Colors.Green)
                   .Children (
                       new HStack ()
                           .Spacing(10)
                           .Children (
                                new HStack()
                                    .Background(Colors.Transparent)
                                    .Cursor(Cursors.Hand)
                                    .Children (  
                                        new Grid ()
                                            .Width (42)
                                            .Height (42)
                                            .Background (Colors.Red),
                                       
                                        new Grid ()
                                            .Width (10)
                                            .Height (10)
                                            .Background (Colors.Blue)
                                    )
                                   .OnTapped ((s,e) =>
                                   {
                                       var panel = (FrameworkElement)s;
                                        panel.TransitionYAnimation (2.0, EasingMode.EaseIn, 150);
                                   })
                                   .OnTappedRelease ((s,e) =>
                                   {
                                       var panel = (FrameworkElement)s;
                                       panel.TransitionYAnimation (0.0, EasingMode.EaseOut, 150);
                                   }),

                               new Button()
                                   .Width(100),
                               new Button ()
                                   .Width (100)
                           ),
                       new Border()
                          .Child(
                              new Viewbox ()
                                  .Child (
                                     new Path ()
                                     {
                                         Data = PathExtentions.Data ("M10 21H14C14 22.1 13.1 23 12 23S10 22.1 10 21M21 19V20H3V19L5 17V11C5 7.9 7 5.2 10 4.3V4C10 2.9 10.9 2 12 2S14 2.9 14 4V4.3C17 5.2 19 7.9 19 11V17L21 19M17 11C17 8.2 14.8 6 12 6S7 8.2 7 11V18H17V11Z")
                                     }.Fill (Colors.White)
                                  )
                                  .Height (20)
                                  .Width (20)
                                  .Margin(top: -2, left:-2)
                           )
                          .Background(Colors.Transparent)
                          .Height(40)
                          .Width(42)
                          .CornerRadius(5)
                          .OnHover ((el) =>
                          {
                              el.Background.WithAnimation ("#313239",100);
                          })
                          .OnRelease ((el) =>
                          {
                              el.Background.WithAnimation (Colors.Transparent,100);
                          })
                   );
    }
}

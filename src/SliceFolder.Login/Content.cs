using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using SliceFolder.Login.Components;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Login
{
    public class Content : Component
    {
        public Content()
        {
            this.Width = 364;
            this.Height = 815;
        }

        protected override Visual Build()
            => new Grid ()
                  .Background ("#15171e")
                  .Children (
                        new Border ()
                            .Margin (1)
                            .Brush ("#36383e")
                            .Thickness (1)
                            .Child (
                                 new VStack ()
                                    .Children (
                                         new HStack ()
                                             .Right ()
                                             .Children
                                             (
                                                  new WindowButton (WindowButtonType.MINIAML)
                                                      .Background (Colors.Transparent, "#23252b")
                                                      .Foreground ("#4a4c51", "#ffffff")
                                                      .Height (22)
                                                      .Width (37),
                                                  new WindowButton (WindowButtonType.EXIT)
                                                      .Background (Colors.Transparent, "#dd1313")
                                                      .Foreground ("#4a4c51", "#ffffff")
                                                      .Height (22)
                                                      .Width (37)
                                             ),
                                         new Border ()
                                             .Padding (top: 10, left: 25, right: 26, bottom: 36)
                                             .Child (
                                                 new VStack ()
                                                     .Children (
                                                         new Image ()
                                                         {
                                                             Stretch = Stretch.None
                                                         }
                                                         .Source (PackUrlHelper.Load (this, "Resources/battlenet.png")),

                                                         new SettingButton ()
                                                             .Margin (top: 15, bottom: 10)
                                                             .Height (28)
                                                             .Width (28)
                                                             .Background ("#313238")
                                                             .Foreground (Colors.Transparent, "#3e4046")
                                                             .Right (),

                                                         UserTextBoxTemplate ("이메일 또는 휴대전화").Margin (bottom: 8),
                                                         UserTextBoxTemplate ("비밀번호").Margin (bottom: 12),

                                                         new FlexCheckBox ()
                                                            .BoxStyle (() => new FlexCheckBoxModel ()
                                                                                .BackColor ("#101117")
                                                                                .CheckColor ("#46a4fc")
                                                                                .Size (18)
                                                                                .Padding (1.2, 3)
                                                                                .CornerRadius (2)
                                                                                .Thickness (1.5)
                                                                                .BorderBrush ("#696b6f", "#7f8084"))
                                                            .Foreground ("#bebec0")
                                                            .FontSize (13)
                                                            .Content ("로그인 상태 유지하기"),

                                                            new FlexPanel ()
                                                                .Align (AlignContent.Start)
                                                                .Justify (JustifyContent.SpaceAuto)
                                                                .AddHeight(13)
                                                                .Children (
                                                                    new SocialButton (SocialButtonType.GOOGLE)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background (Colors.White, "#cecece"),
                                                                    new SocialButton (SocialButtonType.FACEBOOK)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background ("#3172d9", "#1860b7"),
                                                                        new SocialButton (SocialButtonType.FACEBOOK)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background ("#3172d9", "#1860b7")
                                                                ),
                                                            new FlexPanel ()
                                                                .Align(AlignContent.End)
                                                                .Justify (JustifyContent.SpaceAuto)
                                                                .AddHeight (13)
                                                                .Children (
                                                                    new SocialButton (SocialButtonType.GOOGLE)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background (Colors.White, "#cecece"),
                                                                    new SocialButton (SocialButtonType.FACEBOOK)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background ("#3172d9", "#1860b7"),
                                                                        new SocialButton (SocialButtonType.FACEBOOK)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background ("#3172d9", "#1860b7"),
                                                                        new SocialButton (SocialButtonType.FACEBOOK)
                                                                        .Width (48)
                                                                        .Height (48)
                                                                        .Background ("#3172d9", "#1860b7")

                                                                )
                                                     )
                                             )
                                    )
                            )
                   );

        private FlexTextBox UserTextBoxTemplate(string waterMarkText)
            => new FlexTextBox ()
                    .WaterMarkText (waterMarkText)
                    .Background ("#101117")
                    .BorderBrush ("#696b6f", "#7f8084")
                    .BorderThickness (1.5)
                    .CornerRadius (3)
                    .Height (33)
                    .FontSize (13)
                    .WaterMarkTextColor ("#88888b");
    }
}

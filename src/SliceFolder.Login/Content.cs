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
                  .Children 
                   (
                        new Border ()
                            .Margin (1)
                            .Brush ("#36383e")
                            .Thickness (1)
                            .Child 
                            (
                                 new VStack()
                                    .Children(
                                         new HStack ()
                                             .Right ()
                                             .Children 
                                             (
                                                  new WindowButton (WindowButtonType.MINIAML)
                                                      .Background (Colors.Transparent, "#23252b")
                                                      .Foreground("#4a4c51", "#ffffff")
                                                      .Height(22)
                                                      .Width(37),
                                                  new WindowButton (WindowButtonType.EXIT)
                                                      .Background (Colors.Transparent, "#dd1313")
                                                      .Foreground ("#4a4c51", "#ffffff")
                                                      .Height (22)
                                                      .Width(37)
                                             ),
                                         new Border()
                                             .Padding (top: 10, left: 25, right: 26, bottom: 36)
                                             .Child(
                                             new VStack()
                                                 .Children(
                                                     new Image ()
                                                     {
                                                         Stretch = Stretch.None
                                                     }
                                                     .Source (PackUrlHelper.Load (this, "Resources/battlenet.png")),

                                                     new SettingButton ()
                                                         .Margin(top:15, bottom:10)
                                                         .Height (28)
                                                         .Width (28)
                                                         .Background ("#313238")
                                                         .Foreground (Colors.Transparent, "#3e4046")
                                                         .Right(),

                                                     UserTextBoxTemplate()
                                                        .Margin (bottom: 8)                                                       
                                                        .WaterMarkText("이메일 또는 휴대전화")
                                                        .WaterMarkTextColor("#88888b"),

                                                     UserTextBoxTemplate()
                                                        .WaterMarkText ("비밀번호")
                                                        .WaterMarkTextColor ("#88888b"),

                                                     new FlexCheckBox()
                                                        .Background(Colors.White)
                                                        .CheckBoxSize(30)
                                                        .Padding(7)
                                                        .Content("h111111111")
                                                        .Foreground(Colors.White),
                                                     new VStack()
                                                        .Children(
                                                            new SocialButton(SocialButtonType.GOOGLE)
                                                                .Width(48)
                                                                .Height(48)
                                                                .Background(Colors.White,"#cecece"),
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

        private FlexTextBox UserTextBoxTemplate()
            => new FlexTextBox ()
                    .Background ("#101117")
                    .BorderBrush ("#696b6f")
                    .HoverBrush("#7f8084")
                    .BorderThickness (1.5)
                    .CornerRadius (3)
                    .Height (33)
                    .Fontsize (13);
    }
}

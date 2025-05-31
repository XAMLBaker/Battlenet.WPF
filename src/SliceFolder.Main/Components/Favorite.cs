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
                      new VStack ()
                         .Spacing (10)
                         .Children (
                                new TextBlock ()
                                    .Text ("즐겨찾기"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi"),
                                new GroupButton ()
                                    .Content ("hihi")
                         )
                  );

    }
}

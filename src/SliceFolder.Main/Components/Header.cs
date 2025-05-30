using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SliceFolder.Main.Components
{
    public partial class Header : Component
    {
        protected override Visual Build()
            => new FlexPanel ()
                   .Justify (JustifyContent.SpaceBetween)
                   .Children (
                       new FlexPanel ()
                           .Justify (JustifyContent.SpaceEvenly)
                           .Children (
                           ),
                       new Viewbox ()
                          .Child (
                             new Path()
                             {
                                 Data = PathExtentions.Data ("")
                             }
                          )
                   ).Height(100);
    }
}

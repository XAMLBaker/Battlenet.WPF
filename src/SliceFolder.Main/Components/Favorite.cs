using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Components
{
    public partial class Favorite : Component
    {
        protected override Visual Build()
            => new Border ()
                  .CornerRadius (1)
                  .Background ("#27252d");
               
    }
}

using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SliceFolder.Common.Components
{
    public enum WindowButtonType
    {
        MINIAML,
        EXIT
    }

    public partial class WindowButton : ButtonComponent
    {
        private readonly string minmimal = "M20,14H4V10H20";
        private readonly string exit = "M13.46,12L19,17.54V19H17.54L12,13.46L6.46,19H5V17.54L10.54,12L5,6.46V5H6.46L12,10.54L17.54,5H19V6.46L13.46,12Z";

        private readonly string ButtonType = null;
        public WindowButton(WindowButtonType type)
        {
            if (type == WindowButtonType.MINIAML)
            {
                ButtonType = minmimal;
                return;
            }
            ButtonType = exit;
        }

        protected override Visual Build()
            => new Border ()
                    .Child (
                        new Viewbox ()
                            .Child (
                                new Path ()
                                {
                                    Data = PathExtentions.Data(ButtonType)
                                }
                                .Link (Shape.FillProperty, nameof (Foreground), this)
                            )
                            .Margin(top: -5, left:-3)
                            .Width (this.Width - 26)
                            .Height (this.Height - 8)
                            .Center()
                    )
                    .Width (this.Width)
                    .Height (this.Height)
                    .Link (BackgroundProperty, nameof (Background), this);
    }
}

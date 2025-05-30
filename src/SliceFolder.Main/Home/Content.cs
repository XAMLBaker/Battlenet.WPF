using FlexMVVM.WPF.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main.Home
{
    public partial class Content : Component
    {
        protected override Visual Build()
            => new Grid ()
                   .Background(Colors.Red);
    }
}

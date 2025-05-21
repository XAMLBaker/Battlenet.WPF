using FlexMVVM;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Components
{
    public class TitleBar : Component
    {
        private readonly State<Visibility> _sideBarState;

        public TitleBar(State<Visibility> sideBarState)
        {
            this._sideBarState = sideBarState;
        }

        protected override Visual Build()
            => new Grid()
                   .Height(50)
                   .Background("#1c62eb")
                   .Children(
                       new HStack()
                           .Children(
                               new Button()
                                    .Width(100)
                                    .OnTapped(()=> this._sideBarState.Value = ShowHidden ())
                           ),
                       new HStack ()
                           {
                                HorizontalAlignment = System.Windows.HorizontalAlignment.Right
                           }
                           .Children(
                                new Button(),
                                new Button()
                           )
                   );

        private Visibility ShowHidden() => this._sideBarState.Value == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
    }
}

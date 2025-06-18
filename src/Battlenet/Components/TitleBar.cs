using Slate;
using Slate.WPF;
using Slate.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Components
{
    public class TitleBar : Slate.WPF.Markup.Component
    {
        private readonly State<bool> _sideBarState;

        public TitleBar(State<bool> sideBarState)
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

        private bool ShowHidden() => this._sideBarState.Value = !this._sideBarState.Value;
    }
}

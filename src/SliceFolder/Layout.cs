using FlexMVVM;
using FlexMVVM.WPF.Markup;
using SliceFolder.Components;
using System.Windows;
using System.Windows.Controls;

namespace SliceFolder
{
    public partial class Layout : LayoutComponent
    {
        public State<Visibility> SideBarState { get; }= new State<Visibility> (Visibility.Visible);


        protected override IEnumerable<UIElement> Build()
            => new UIElement[] {
                    new TitleBar(SideBarState).SetDock(Dock.Top),
                    new SideBar().SetDock(Dock.Left)
                        .Link(VisibilityProperty, "Value", SideBarState)
               };
    }
}
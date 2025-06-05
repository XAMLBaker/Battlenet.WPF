using DryIoc;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Media;

namespace Battlenet
{
    public partial class Layout : Component
    {
        private readonly IContainer _container;

        public Layout(IContainer container)
        {
            this._container = container;
        }
        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            base.OnLoaded (sender, e);

            RegionManager.Attach ("Root", this._container.Resolve<Login.Content> ());
        }
        protected override Visual Build()
            => new FlexRegion ("Root");
    }
}

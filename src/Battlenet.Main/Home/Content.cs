using Battlenet.Main.Components;
using DryIoc;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Battlenet.Main.Home
{
    public partial class Content : Component
    {
        private readonly IContainer _container;

        public Content(IContainer container)
        {
            this._container = container;
        }

        public override void RegionAttached()
        {
            base.RegionAttached ();

            RegionManager.Attach ("SubHeader", this._container.Resolve<Favorite> ());
            RegionManager.Attach ("Content", this);
        }

        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            base.OnLoaded (sender, e);
        }

        protected override Visual Build()
            => new Grid ()
                    .Background (Colors.Red);
    }
}

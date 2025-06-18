using Battlenet.Common.Components;
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
            _container = container;
        }

        public override void RegionAttached(object argu)
        {
            base.RegionAttached (argu);
            RegionManager.Attach ("SubHeader", _container.Resolve<Favorite> ());
            RegionManager.Attach ("Content", this);
        }

        protected override void OnLoaded(object sender, RoutedEventArgs e)
        {
            base.OnLoaded (sender, e);
        }

        protected override Visual Build()
            => new Grid ()
                    .Margin(top: 150)
                    .Background (Colors.Red);
    }
}

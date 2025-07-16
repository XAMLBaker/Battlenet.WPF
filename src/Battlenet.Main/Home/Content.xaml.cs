using Battlenet.Common.Components;

namespace Battlenet.Main.Home
{
    /// <summary>
    /// Content.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Content : UserControl, IShellComponent
    {
        private IContainer _container;
        public Content(IContainer container)
        {
            InitializeComponent ();
            _container = container;
        }

        public void RegionAttached(object argu = null)
        {
            RegionManager.Attach ("SubHeader", _container.Resolve<Favorite> ());
            RegionManager.Attach ("Content", this);
        }
    }
}

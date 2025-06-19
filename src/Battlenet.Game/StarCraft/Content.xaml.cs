using Battlenet.Common.Components;

namespace Battlenet.Game.StarCraft
{
    /// <summary>
    /// Content.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Content : UserControl, IShellComponent
    {
        private readonly IContainer _container;

        public Content(IContainer container)
        {
            InitializeComponent ();
            this._container = container;
        }

        public void RegionAttached(object argu = null)
        { 
            RegionManager.Attach ("SubHeader", this._container.Resolve<Favorite> ());
            RegionManager.Attach ("Content", this);
        }
    }
}

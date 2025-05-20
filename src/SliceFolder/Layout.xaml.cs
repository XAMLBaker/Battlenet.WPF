using System.Windows.Controls;

namespace SliceFolder
{
    /// <summary>
    /// Layout.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Layout : DockPanel
    {
        public Layout(LayoutViewModel layoutViewModel)
        {
            InitializeComponent ();
            this.DataContext = layoutViewModel;
        }
    }
}

using System.Windows.Controls;

namespace SliceFolder.Main
{
    /// <summary>
    /// Layout.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Layout : UserControl
    {
        public Layout(LayoutViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}

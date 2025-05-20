using System.Windows;

namespace SliceFolder
{
    /// <summary>
    /// Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowStyle : Window
    {
        public WindowStyle()
        {
            InitializeComponent ();
            this.PreviewMouseLeftButtonDown += WindowStyle_PreviewMouseLeftButtonDown;
        }

        private void WindowStyle_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove ();
        }
    }
}

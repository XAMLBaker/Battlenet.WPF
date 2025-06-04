using System.Windows;
using System.Windows.Input;

namespace Battlenet
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent ();
            this.MouseLeftButtonDown += WindowStyle_MouseLeftButtonDown;
        }

        private void WindowStyle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove ();
        }
    }
}

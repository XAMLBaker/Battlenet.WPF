namespace Battlenet.Main.Games._Shared.Components
{
    public class LeftSideBarItem : RadioButton
    {
        public int Count
        {
            get { return (int)GetValue (CountProperty); }
            set { SetValue (CountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register ("Count", typeof (int), typeof (LeftSideBarItem), new PropertyMetadata (0));


        static LeftSideBarItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (LeftSideBarItem), new FrameworkPropertyMetadata (typeof (LeftSideBarItem)));
        }
    }
}

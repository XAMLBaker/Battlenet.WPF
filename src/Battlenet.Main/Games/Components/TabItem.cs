using System.Windows;
using System.Windows.Controls;

namespace Battlenet.Main.Games.Components
{
    public class TabItem : RadioButton
    {


        public int Count
        {
            get { return (int)GetValue (CountProperty); }
            set { SetValue (CountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register ("Count", typeof (int), typeof (TabItem), new PropertyMetadata (0));


        static TabItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (TabItem), new FrameworkPropertyMetadata (typeof (TabItem)));
        }
    }
}

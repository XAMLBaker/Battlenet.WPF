using FlexMVVM.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SliceFolder.Common.Components
{
    public class GroupButton : RadioButton
    {
        static GroupButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (GroupButton), new FrameworkPropertyMetadata (typeof (GroupButton)));
        }
        public GroupButton()
        {
            this.Cursor = Cursors.Hand;
        }

        Border bdr;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            bdr = this.GetTemplateChild ("bdr") as Border;

            this.GroupName = "NaviTab";

            this.Loaded += (s, e) =>
            {
                StateRun ();
            };
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged (e);

            if(e.Property.Name == nameof(IsChecked))
            {
                if(this.ActualWidth == double.NaN || bdr == null)
                {
                    return;
                }
                StateRun ();
            }
        }

        private void StateRun()
        {
            if (IsChecked == true)
            {
                bdr.WidthAnimation (this.ActualWidth);
            }
            else if (IsChecked == false)
            {
                bdr.WidthAnimation (0);
            }
        }
    }
}

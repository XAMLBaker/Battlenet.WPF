
namespace Battlenet.Main.Home.Components
{
    public class AdListBox : ListBox
    {
        static AdListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (AdListBox), new FrameworkPropertyMetadata (typeof (AdListBox)));
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged (e);

            if(e.Property.Name == "ItemsSource")
            {
                if(this.Items.Count != 0)
                {
                    this.SelectedItem = this.Items[0];
                }
            }
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;

namespace SliceFolder.Main
{
    public partial class Content : Component
    {
        [ObservableProperty] int _count = 0;
        [ObservableProperty] string _name = "";

        protected override  Visual Build()
            => new StackPanel()
                    .Children(
                        new Label ()
                            .Link (nameof (Count))
                            .OnTapped(()=>this.Count++),
                        new Button ()
                            { 
                                Width = 100,
                                Height = 50,
                            }
                            .Link (nameof(Count))
                            .OnTapped (() => this.Count++)
                     );
    }
}

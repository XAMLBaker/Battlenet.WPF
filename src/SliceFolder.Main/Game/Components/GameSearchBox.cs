using CommunityToolkit.Mvvm.ComponentModel;
using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SliceFolder.Main.Game.Components
{
    public partial class GameSearchBox : Component
    {
        [ObservableProperty] Geometry searchModeShape;
        [ObservableProperty] bool isSearchMode = false;
        [ObservableProperty] string searchText;

        public GameSearchBox()
        {
            SearchWait ();
        }
        protected override void InitilzedForms()
        {
            this.Width (188);
            this.Height (37);
            this.Background (Colors.Transparent);
        }

        protected override Visual Build()
            => new Border ()
                .CornerRadius (5)
                .Background ("#222730")
                .Padding (right: 8)
                .Link (WidthProperty, nameof (Width), this)
                .BorderThickness (1)
                .Link (BorderBrushProperty, nameof (Background), this)
                .Child (
                    new Grid ()
                       .Columns ("*", "20")
                       .AddChild (
                            new FlexTextBox ()
                                .WaterMarkText("게임 검색")
                                .WaterMarkTextColor("#a7a9ac")
                                .Foreground(Colors.White)
                                .CaretBrush(Colors.White)
                                .OnTextChanged(TextChange)
                                .OnFocus(OnFocus)
                                .OnLostFocus(OnLostFocus)
                                .Background(Colors.Transparent)
                                .Link(TextBox.TextProperty, nameof(SearchText), source: this, updateSourceTrigger: UpdateSourceTrigger.PropertyChanged)

                       )
                       .AddChild (
                            new Viewbox()
                                .Size (15, 15)
                                .Child(
                                    new Grid()
                                        .Children(
                                            new Path ()
                                                .Left()
                                                .VCenter()                                
                                                .Fill("#c6c6c8")
                                                .Link(Path.DataProperty, nameof(SearchModeShape))
                                        )
                                        .Link (IsEnabledProperty, nameof (IsSearchMode))
                                        .Cursor (Cursors.Hand)
                                        .Background(Colors.Transparent)
                                )
                                .Link(IsEnabledProperty, nameof (IsSearchMode))
                                .OnTapped (() =>
                                {
                                    this.SearchText = "";
                                })
                                
                       , column: 1)
                );

        private void SearchMode()
        {
            SearchModeShape = PathExtentions.Data ("M13.46,12L19,17.54V19H17.54L12,13.46L6.46,19H5V17.54L10.54,12L5,6.46V5H6.46L12,10.54L17.54,5H19V6.46L13.46,12Z");
            IsSearchMode = true;
        }
        private void SearchWait()
        {
            SearchModeShape = PathExtentions.Data ("M9.5,3A6.5,6.5 0 0,1 16,9.5C16,11.11 15.41,12.59 14.44,13.73L14.71,14H15.5L20.5,19L19,20.5L14,15.5V14.71L13.73,14.44C12.59,15.41 11.11,16 9.5,16A6.5,6.5 0 0,1 3,9.5A6.5,6.5 0 0,1 9.5,3M9.5,5C7,5 5,7 5,9.5C5,12 7,14 9.5,14C12,14 14,12 14,9.5C14,7 12,5 9.5,5Z");
            IsSearchMode = false;
        }

        private void TextChange(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                SearchWait ();
                if (sender is TextBox tb)
                {
                    if (tb.IsFocused)
                        return;
                }
                this.Background (Colors.Transparent);
                return;
            }
            SearchMode ();
            this.Background (Colors.White);
        }

        private void OnFocus()
        {
            this.Background (Colors.White);
        }
        private void OnLostFocus()
        {
            this.Background (Colors.Transparent);
        }
    }
}

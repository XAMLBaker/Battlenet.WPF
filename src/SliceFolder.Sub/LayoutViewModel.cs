using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlexMVVM.Navigation;

namespace SliceFolder.Sub
{
    public partial class LayoutViewModel: ObservableObject
    {
        private readonly ILayoutNavigator _layoutNavigator;

        public LayoutViewModel(ILayoutNavigator layoutNavigator)
        {
            this._layoutNavigator = layoutNavigator;
        }

        [RelayCommand]
        private void Home()
        {
            this._layoutNavigator.RootLayout ();
        }
    }
}

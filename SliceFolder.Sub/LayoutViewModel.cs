using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlexMVVM.Navigation;

namespace SliceFolder.Sub
{
    public partial class LayoutViewModel: ObservableObject
    {
        private readonly INavigator _navigator;

        public LayoutViewModel(INavigator navigator) 
        {
            this._navigator = navigator;
        }

        [RelayCommand]
        private void Home()
        {
            this._navigator.RootLayout ();
        }
    }
}

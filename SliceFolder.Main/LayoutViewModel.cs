using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlexMVVM.Navigation;

namespace SliceFolder.Main;

public partial class LayoutViewModel : ObservableObject
{
    private readonly INavigator _navigator;

    public LayoutViewModel(INavigator navigator)
    {
        this._navigator = navigator;
    }
    [RelayCommand]
    private void Home()
    {

    }

    [RelayCommand]
    private void Route()
    {
        this._navigator.Move ("SliceFolder.Sub.Layout"); // or this._navigator.Move ("SliceFolder/Sub/Layout");
    }
}

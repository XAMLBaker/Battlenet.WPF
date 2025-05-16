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
    private void Route1()
    {
        this._navigator.Move ("SliceFolder.Sub"); // or this._navigator.Move ("SliceFolder/Sub/Test2");
    }
    [RelayCommand]
    private void Route2()
    {
        // this._navigator.Move ("SliceFolder.Sub.Layout");
        this._navigator.Move ("SliceFolder.Sub.Test"); // or this._navigator.Move ("SliceFolder/Sub");
    }
    [RelayCommand]
    private void Route3()
    {
        // this._navigator.Move ("SliceFolder.Sub.Layout");
        this._navigator.Move ("SliceFolder.Sub.Test2"); // or this._navigator.Move ("SliceFolder/Sub/Test2");
    }
}

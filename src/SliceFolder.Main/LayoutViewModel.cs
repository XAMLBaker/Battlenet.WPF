using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlexMVVM.Navigation;

namespace SliceFolder.Main;

public partial class LayoutViewModel : ObservableObject
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

    [RelayCommand]
    private void Route1()
    {
        this._layoutNavigator.NavigateTo ("SliceFolder.Sub"); // or this._navigator.Move ("SliceFolder/Sub/Test2");
    }

    [RelayCommand]
    private void Route2()
    {
        this._layoutNavigator.NavigateTo ("SliceFolder.Sub.Test"); // or this._navigator.Move ("SliceFolder/Sub/Test");
    }

    [RelayCommand]
    private void Route3()
    {
        this._layoutNavigator.NavigateTo ("SliceFolder.Sub.Test2"); // or this._navigator.Move ("SliceFolder/Sub/Test2");
    }
}

using OrlandoCodeCamp2022.ViewModels;

namespace OrlandoCodeCamp2022;

public partial class App : Caliburn.Micro.Maui.MauiApplication
{
    public App()
    {
        InitializeComponent();

        Initialize();

        DisplayRootViewForAsync<MainViewModel>();
    }
}

using Foundation;

namespace OrlandoCodeCamp2022;

[Register("AppDelegate")]
public class AppDelegate : Caliburn.Micro.Maui.CaliburnApplicationDelegate
{
    public AppDelegate()
    {
        Initialize();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

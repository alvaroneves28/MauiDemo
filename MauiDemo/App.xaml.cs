namespace MauiDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var navPage = new NavigationPage(new StackLayoutDemo());
        
        return new Window(navPage);
    }
}



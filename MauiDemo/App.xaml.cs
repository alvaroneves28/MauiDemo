namespace MauiDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var navPage = new NavigationPage(new GridLayoutDemo());
        
        return new Window(navPage);
    }
}



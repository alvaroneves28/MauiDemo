namespace MauiDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var tabbedPage = new TabbedPageDemo();

        var navPage = new NavigationPage(new MinhaPágina())
        {
            Title = "Início",
            BarBackgroundColor = Colors.Yellow,
            BarTextColor = Colors.Blue
        };

        tabbedPage.Children.Add(navPage);

        return new Window(tabbedPage);
    }
}



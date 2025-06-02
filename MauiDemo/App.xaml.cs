namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MinhaPágina());

            navPage.BarBackground = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            MainPage = navPage;
        }

        
    }
}
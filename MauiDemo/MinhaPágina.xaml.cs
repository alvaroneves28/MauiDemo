using System.Threading.Tasks;

namespace MauiDemo;

public partial class MinhaPágina : ContentPage
{
	public MinhaPágina()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}
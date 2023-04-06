namespace Shop_Bike.Views;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Servers Down!",
                    $"Please try again later", "OK");
    }
}
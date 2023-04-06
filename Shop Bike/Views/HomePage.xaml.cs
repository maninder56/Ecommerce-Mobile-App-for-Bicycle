using Shop_Bike.Models;
using Shop_Bike.ViewModels;

namespace Shop_Bike.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;		
	}

	// got to cart page 
    private async void OnImageButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }

    private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        await Shell.Current.DisplayAlert("Search Not available!",
                    $"Please try again later", "OK");
    }
}
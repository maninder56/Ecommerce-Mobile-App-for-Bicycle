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
    private void OnImageButtonClicked(object sender, EventArgs e)
    {

    }

    
}
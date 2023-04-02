using Shop_Bike.ViewModels;

namespace Shop_Bike.Views;

public partial class BikeDetailPage : ContentPage
{
	public BikeDetailPage(BikeDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
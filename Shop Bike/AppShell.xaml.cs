using Shop_Bike.Views;

namespace Shop_Bike;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BikeDetailPage), typeof(BikeDetailPage));
	}
}

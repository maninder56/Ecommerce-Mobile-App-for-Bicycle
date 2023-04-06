using CommunityToolkit.Mvvm.Input;
using Shop_Bike.ViewModels;

namespace Shop_Bike.Views;

public partial class MapPage : ContentPage
{
    public MapPage(MapViewModel map)
	{
		InitializeComponent();
		BindingContext = map;
	}
}
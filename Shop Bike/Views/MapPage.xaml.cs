using CommunityToolkit.Mvvm.Input;
using Shop_Bike.ViewModels;

namespace Shop_Bike.Views;

public partial class MapPage : ContentPage
{
    IMap map;

    public MapPage(MapViewModel map)
	{
		InitializeComponent();
		BindingContext = map;
	}

    private async void Map_Button_Clicked(object sender, EventArgs e)
    {
        await OpenMapAsync();
    }

    public async Task OpenMapAsync()
    {
        var location = new Location(47.645160, -122.1306032);

        try
        {
            await map.OpenAsync(location);
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to open map: {ex.Message}", "OK");
        }


    }
}
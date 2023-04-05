using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.ViewModels
{
    public partial class MapViewModel : BaseViewModel
    {
        IMap map;
        public MapViewModel(IMap map)
        {
            this.map = map;

        }



        [RelayCommand]
        async Task OpenMapAsync()
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
}

/* [RelayCommand]
        async Task UserLocationAsync()
        {
            try
            {
                var location = await geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await geolocation.GetLocationAsync(
                        new GeolocationRequest
                        {
                            DesiredAccuracy = GeolocationAccuracy.Medium,
                            Timeout = TimeSpan.FromSeconds(30),
                        });
                }

                if (location == null) return;

            } catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to get Location: {ex.Message}", "OK");
            }
        } */

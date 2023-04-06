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
            var placemark = new Placemark
            { 
                Thoroughfare = "Bike Shops",
            };
            try
            {
                await map.OpenAsync(placemark);

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to open map: {ex.Message}", "OK");
            } 
        }

        [RelayCommand]
        async Task OpenShopBike()
        {
            var placemark = new Placemark
            {
                Thoroughfare = "Woodinville Bicycle",
            };
            try
            {
                await map.OpenAsync(placemark);

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to open map: {ex.Message}", "OK");
            }
        }
    }
}

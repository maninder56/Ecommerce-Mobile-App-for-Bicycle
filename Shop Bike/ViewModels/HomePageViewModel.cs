using CommunityToolkit.Mvvm.ComponentModel;
using Shop_Bike.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shop_Bike.Services;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using Shop_Bike.Views;

namespace Shop_Bike.ViewModels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        BikeService BikeService;
       public ObservableCollection<Bike> BikeList { get; } = new();
        public ObservableCollection<Cart> CartList { get; } = new();

        IConnectivity connectivity;
        IGeolocation geolocation; 

       public HomePageViewModel(BikeService bikeService, IConnectivity connectivity, IGeolocation geolocation)
        {
            //Title = "Shop Bike__";
            this.BikeService = bikeService;
            this.connectivity = connectivity; 
            this.geolocation = geolocation;

            _ = LoadBikes();

        }


        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GoToBikeDetailAsync(Bike bike)
        {
            if (bike is null)
            {
                return;
            }

            // pass id when using databse
            await Shell.Current.GoToAsync($"{nameof(BikeDetailPage)}", true, 
                new Dictionary<String, object>
                {
                    {"Bike", bike}
                }); 

        }

        [RelayCommand]
       async Task LoadBikes()
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet) 
            {
                await Shell.Current.DisplayAlert("Internet issue",
                    $"Check your internet and try again!", "OK");
            }

            if (BikeList.Count != 0)
            {
                BikeList.Clear();
            }
            var Bikes = await BikeService.GetBikes();

            foreach (var Bike in Bikes)
            {
                BikeList.Add(Bike);
            }

            IsRefreshing = false;
        }

        



    }
}


/* 
 
 [RelayCommand]
        async Task GetBikeAsync()
        {
            

            try
            {
                //IsBusy = true;
                var Bikes = await BikeService.GetBikes();

                if (BikeList.Count != 0)
                {
                    BikeList.Clear();
                }

                foreach (var bike in Bikes)
                {
                    BikeList.Add(bike);
                }
            }

            catch (Exception ex) 
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error",
                    $"Unable to get Bike Date {ex.Message}", "OK");
            }

            finally 
            {
                //IsBusy = false;
            }
        }
 
 
 */
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
       public HomePageViewModel(BikeService bikeService)
        {
            //Title = "Shop Bike__";
            this.BikeService = bikeService;

            _ = LoadBikes();

        }

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

       async Task LoadBikes()
        {
            var Bikes = await BikeService.GetBikes();

            foreach (var Bike in Bikes)
            {
                BikeList.Add(Bike);
            }
        }




    }
}

// 
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
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

namespace Shop_Bike.ViewModels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        BikeService bikeService;
       public ObservableCollection<Bike> BikeList { get; } = new();

        public Command GetBikeCommand { get;}
       public HomePageViewModel(BikeService bikeService)
        {
            Title = "Shop Bike__";
            this.bikeService = bikeService;
        }

        async Task GetBikeAsync()
        {
            if (IsBusy) { return; }

            try
            {
                IsBusy = true;
                var Bikes = await bikeService.GetBikes();

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
                IsBusy = false;
            }
        }
    }

    

}

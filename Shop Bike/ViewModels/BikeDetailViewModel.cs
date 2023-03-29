using CommunityToolkit.Mvvm.ComponentModel;
using Shop_Bike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.ViewModels
{
    [QueryProperty(nameof(Bike), "Bike")]
    public partial class BikeDetailViewModel : BaseViewModel
    {
        public BikeDetailViewModel() 
        {
            
        }

        [ObservableProperty]
        Bike bike;
    }
}

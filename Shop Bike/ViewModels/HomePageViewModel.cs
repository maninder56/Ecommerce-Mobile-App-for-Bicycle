using Shop_Bike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.ViewModels
{
    public class HomePageViewModel
    {
        public Models.BikesModel BikesModel { get; set; }

        public string Bike_one
        {
            get => BikesModel.Bike_one;
        }

        public string Bike_two
        {
            get => BikesModel.Bike_two;
        }

        public string Bike_three
        {
            get => BikesModel.Bike_three;
        }



        // constructor 
        public HomePageViewModel()
        {
            BikesModel = new Models.BikesModel();
                
        }


    }

    

}

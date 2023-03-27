using Shop_Bike.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.ViewModels
{
    public class HomePageViewModel
    {
         public List<BikesModel> Bikes;




        // constructor 
        public HomePageViewModel()
        {
            Bikes = new List<BikesModel>();
            create_bikes();
        }

        void create_bikes()
        {
            Bikes.Add(new BikesModel
            {
                Bike_name = "Bike One",
                Bike_image = "bike_one.jpg",
                Bike_price = "£ 50",
            });
            

            Bikes.Add(new BikesModel
            {
                Bike_name = "Bike Two",
                Bike_image = "bike_two.jpg",
                Bike_price = "£ 100",
            });

            Bikes.Add(new BikesModel
            {
                Bike_name = "Bike Three",
                Bike_image = "bike_three.jpg",
                Bike_price = "£ 3000",
            });

        }

    }

    

}

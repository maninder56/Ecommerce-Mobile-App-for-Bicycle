using Shop_Bike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Shop_Bike.Services
{
    public class BikeService
    {

        HttpClient httpClient;
        public BikeService ()
        {
            httpClient = new HttpClient ();
        }

        List<Bike> BikeList = new List<Bike>();

        public async Task<List<Bike>> GetBikes()
        {
            if (BikeList?.Count > 0)
            {
                return BikeList;
            }

            var url = "https://github.coventry.ac.uk/raw/singhm50/Bikes/main/bikes.json";

            var response = await httpClient.GetAsync (url);

            if (response.IsSuccessStatusCode)
            {
                BikeList = await response.Content.ReadFromJsonAsync<List<Bike>>();
            }


            // If internet unavailable use local file 

            /*using var stream = await FileSystem.OpenAppPackageFileAsync("bikes.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            BikeList = JsonSerializer.Deserialize<List<Bike>>(contents); */

            return BikeList;
        }
    }
}

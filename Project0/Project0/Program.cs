using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project0.Models;
using Project0.Abstracts;


namespace Project0
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantList restaurantList = new RestaurantList();
            Restaurant rest1 = new Restaurant();
            Restaurant rest2 = new Restaurant();
            Restaurant rest3 = new Restaurant();
            Restaurant rest4 = new Restaurant();


            restaurantList.AddRestaurant(rest1);
            restaurantList.AddRestaurant(rest2);
            restaurantList.AddRestaurant(rest3);
            restaurantList.AddRestaurant(rest4);
            restaurantList.g







            Console.ReadKey();
            //restaurant.getAverageRating();
        }
    }
}

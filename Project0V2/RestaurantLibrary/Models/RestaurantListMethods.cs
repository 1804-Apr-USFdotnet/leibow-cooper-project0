using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary.Models;

namespace RestaurantLibrary.Models
{
    public class RestaurantListMethods
    {

        public void AddRestaurant(Restaurant restaurant, List<Restaurant> restaurantList)
        {
            restaurantList.Add(restaurant);
        }





        public void TopThree(List<Restaurant> restaurantList)
        { 
            List<Restaurant> SortedList = restaurantList.OrderBy(o => o.AverageRating).ToList();
            Restaurant first = SortedList.ElementAt(0);
            Restaurant second = SortedList.ElementAt(1);
            Restaurant third = SortedList.ElementAt(2);

            Console.WriteLine("1st: " + first.Name);
            Console.WriteLine("2nd: " + second.Name);
            Console.WriteLine("3rd: " + third.Name);

        }
    }
}

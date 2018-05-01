using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary.Models;
using RestuarantReviewDataLayer;
using RestaurantLibrary.LibraryHelper;



namespace RestaurantLibrary.Models
{
    public static class RestaurantListMethods
    {
        public static List<Restaurant> CreateRestaurantList(IEnumerable<RestuarantReviewDataLayer.Restaurant> restaurantList)
        {
            List<Restaurant> myList = new List<Restaurant>();

            foreach (var res in restaurantList)
            {
                Restaurant libRes = LibraryHelper.LibraryHelper.DataToLibrary(res);
                myList.Add(libRes);
            }
            return myList;
        }

        public static void AddRestaurant(Restaurant restaurant, List<Restaurant> restaurantList)
        {
            restaurantList.Add(restaurant);
        }





        public static void TopThree(List<Restaurant> restaurantList)
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

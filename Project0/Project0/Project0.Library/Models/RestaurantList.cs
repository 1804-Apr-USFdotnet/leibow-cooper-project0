using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0.Models
{
    public class RestaurantList
    {
        List<Restaurant> restaurantList = new List<Restaurant>();


        

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurantList.Add(restaurant);
        }



        public Restaurant FindRestaurant(string name)
        {
            Restaurant foundRes = null;

            foreach (Restaurant restaurant in restaurantList)
            {
                if (restaurant.Name.Equals(name))
                {
                    foundRes = restaurant;
                    break;
                }
            }
            return foundRes;
        }

     

        public List<Restaurant> TopThree()
        {
            List<Restaurant> topThree = new List<Restaurant>();
            List<Restaurant> preservedRestaurantList = restaurantList;

            for (var i = 0; i <= 2; i++)
            { 
                Restaurant previous = null;
                Restaurant current = null;

                for(var x = 0; x< restaurantList.Count(); x++)
                {
                    current = restaurantList.ElementAt(i);
                    if (current.AverageRating > previous.AverageRating)
                    {
                        previous = current;
                    }   
                }
                topThree.Add(current);
                restaurantList.Remove(current);
            }
            restaurantList = preservedRestaurantList;
            return topThree;
        }
    }


}

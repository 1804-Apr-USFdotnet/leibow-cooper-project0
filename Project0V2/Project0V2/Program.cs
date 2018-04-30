using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary.Models;
using RestaurantLibrary.Serializers;


namespace Project0V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant res = new Restaurant("Papa Johns");

            RestaurantSerializer resSerializer = new RestaurantSerializer();

            resSerializer.SerializeMethod(res, "restaurant2");

            RestaurantDeserializer resDeserializer = new RestaurantDeserializer();

            Console.WriteLine(resDeserializer.DeserializeMethod("restaurant2").AverageRating);

            Console.ReadKey();

        }
    }
}

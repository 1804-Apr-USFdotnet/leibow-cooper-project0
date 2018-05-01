using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantReviewDataLayer;
using RestaurantLibrary;

namespace RestaurantLibrary.LibraryHelper
{
    public static class LibraryHelper
    {

        // parameter is the EF Restuarant model
        public static RestaurantLibrary.Models.Restaurant DataToLibrary(RestuarantReviewDataLayer.Restaurant data)
        {
            var libModel = new RestaurantLibrary.Models.Restaurant()
            {
                Name = data.Name,
                AverageRating = data.averagerating,
                
                
            };
            
            return libModel;
        }

        public static RestuarantReviewDataLayer.Restaurant LibraryToData(RestaurantLibrary.Models.Restaurant libraryRes)
        {
            var dataModel = new RestuarantReviewDataLayer.Restaurant()
            {
                Name = libraryRes.Name,
                averagerating = libraryRes.AverageRating
            };
            return dataModel;
        }
    }
}

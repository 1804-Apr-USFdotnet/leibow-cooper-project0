using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantReviewDataLayer.LibraryHelper
{
    public static class LibraryHelper
    {

        // parameter is the EF Restuarant model
        public static Restaurant DataToLibrary(RestuarantReviewDataLayer.Restaurant data)
        {
            var libModel = new Restaurant()
            {
                Name = data.Name,
                averagerating = data.averagerating,
                location = data.location
                
            };
            return libModel;
        }

        public static RestuarantReviewDataLayer.Restaurant LibraryToData(Restaurant libraryRes)
        {
            var dataModel = new RestuarantReviewDataLayer.Restaurant()
            {
                Name = libraryRes.Name,
                averagerating = libraryRes.averagerating,
                location = libraryRes.location
            };
            return dataModel;
        }
    }
}

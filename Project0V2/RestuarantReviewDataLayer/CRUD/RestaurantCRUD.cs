using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantReviewDataLayer
{
    public class RestaurantCRUD
    {
        //public async Task AddRestaurant(Restaurant res)
        //{
        //    using (var db = new RestaurantDBEntities())
        //    {
        //        db.Restaurants.Add(res);
        //        await db.SaveChangesAsync();
        //    }
        //}

        private RestaurantDBEntities _db;

        public RestaurantCRUD()
        {
            _db = new RestaurantDBEntities();
        }

        public IEnumerable<Restaurant> GetRestaurant()
        {
            var list = _db.Restaurants.ToList();
            return list;
        }

        public void AddRestaurant(Restaurant res)
        {
            _db.Restaurants.Add(res);
            _db.SaveChanges();
        }

    }

}

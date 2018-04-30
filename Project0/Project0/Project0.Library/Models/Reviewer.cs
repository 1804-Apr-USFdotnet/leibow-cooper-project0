using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project0.Models;

namespace Project0.Models
{
    public class Reviewer
    {
        public string name;
        public string email;

        public Reviewer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public Review MakeReview(double rating, Restaurant restaurant, string content)
        {
            Review review = new Review(rating, this, content, restaurant);
            restaurant.AddReview(review);
            return review;
        }
            

    }


}

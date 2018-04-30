using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary.Models;

namespace RestaurantLibrary.Models
{
    public class Review
    {


        // has a rating and other relevant data(e.g.reviewer name)
        public double Rating { get; set; }
        public Reviewer reviewer;
        public string Content { get; set; }
        Restaurant restaurant;

       
        public Review(double rating, Reviewer reviewer, string content, Restaurant restaurant)
        {
            Rating = rating;
            this.reviewer = reviewer;
            Content = content;
            this.restaurant = restaurant;
        }

        public Review()
        {

        }
    }
}

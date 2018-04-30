using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0.Models
{
    public class Review
    {


        // has a rating and other relevant data(e.g.reviewer name)
        internal double Rating { get; set; }
        Reviewer reviewer;
        private string Content { get; set; }
        Restaurant restaurant;
        public Review()
        {

        }
        public Review(double rating, Reviewer reviewer, string content, Restaurant restaurant)
        {
            this.Rating = rating;
            this.reviewer = reviewer;
            this.Content = content;
            this.restaurant = restaurant;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Project0.Models;

namespace Project0.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        private string Location { get; set; }
        public double AverageRating;
        public List<Review> Reviewlist;


        public Restaurant(string name)
        {
            this.Name = name;
            Reviewlist = new List<Review>();
            AverageRating = 0;
            
     
        }

        public Restaurant()
        {

        }

       
        public void AddReview(Review review)
        {
            Reviewlist.Add(review);
        }

 
        // take rating of all relevant reviews and calculate average
        public double getAverageRating()
        {
            AverageRating = 0;
            foreach (Review review in Reviewlist)
            {
                AverageRating += review.Rating;
            }
            return AverageRating /= (double)Reviewlist.Count();
            
            
            
        }

        
   
        public List<Review> getAllReviews()
        {
            return Reviewlist;
        }


//      has a name and other relevant data(e.g.location)
//*     has many reviews
//*     has average rating, computed from all its reviews
    }
}

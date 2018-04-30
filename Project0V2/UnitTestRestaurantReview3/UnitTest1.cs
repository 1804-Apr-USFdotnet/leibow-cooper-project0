using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantLibrary.Models;

namespace UnitTestRestaurantReview3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Reviewer reviewer = new Reviewer("Cooper", "leibowcooper@gmail.com");
            string expected = "Cooper";

            var actual = reviewer.name;

            Assert.AreEqual(expected, actual);



        }
        // test getAvgrating can add one value and obtain average
        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            Reviewer reviewer = new Reviewer("Cooper", "leibowcooper@gmail.com");
            Restaurant restaurant = new Restaurant();
            reviewer.MakeReview(3.4, restaurant, "it was a good place to eat");
            restaurant.getAverageRating();
            double expected = 3.4;

            // act
            var actual = restaurant.AverageRating;

            //assert
            Assert.AreEqual(expected, actual);

        }
        //test get avg rating can add more than one value and get average
        [TestMethod]
        public void TestMethod3()
        {
            Reviewer reviewer = new Reviewer("Cooper", "leibowcooper@gmail.com");
            Restaurant restaurant = new Restaurant("the Krusty Krab");
            
            reviewer.MakeReview(3.4, restaurant, "it was a good place to eat");
            reviewer.MakeReview(4.5, restaurant, "food was amazinggggg");

            restaurant.getAverageRating();
            double expected = 3.95;

            var actual = restaurant.AverageRating;

            Assert.AreEqual(expected, actual);

        }
    }
}

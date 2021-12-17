using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantMS.Models;

namespace RestaurantMS.Services
{
    public class FakeReviewService : IReviewService
    {
        public Task<Review[]> GetAllReviewsAsync()
        {
            var item1 = new Review
            {
                Review_ID = 1,
                Rating = 5,
                Comment = "Wow! Great food.",
                Store_ID = 1,
                Customer_ID = 1
            };

            var item2 = new Review
            {
                Review_ID = 2,
                Rating = 3,
                Comment = "Food was bland.",
                Store_ID = 1,
                Customer_ID = 2
            };        

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
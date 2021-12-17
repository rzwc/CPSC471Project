using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantMS.Models;

namespace RestaurantMS.Services
{
    public interface IReviewService 
    {
        Task<Review[]> GetAllReviewsAsync();
    }
}
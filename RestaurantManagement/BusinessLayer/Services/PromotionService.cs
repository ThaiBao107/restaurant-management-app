using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using RestaurantManagement.DAL;
using BusinessLayer.DTOs;
namespace BusinessLayer.Services
{
    public class PromotionService
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public PromotionService()
        {
            this.restaurantDbContext = new RestaurantDbContext();
        }

        public List<PromotionDTO> loadPromotion()
        {
            try
            {
                var promotions = (this.restaurantDbContext.Promotions.Select(p => 
                new PromotionDTO
                {
                    PromotionID = p.PromotionID,
                    PromotionName = p.PromotionName,
                    Description = p.Description,
                    DiscountPercentage = p.DiscountPercentage,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate,
                    IsActive = p.IsActive
                })).ToList();
                return promotions;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

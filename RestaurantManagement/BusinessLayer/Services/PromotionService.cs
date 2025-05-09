using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PromotionService
    {
        private readonly Repository<Promotion> _context;

        public PromotionService()
        {
            _context = new Repository<Promotion>();
        }

        // Lấy danh sách mã giảm giá
        public List<PromotionDTO> GetPromotion()
        {
            var promotion = _context.GetAll().ToList();

            return promotion.Select(p => new PromotionDTO
            {
                PromotionID = p.PromotionID,
                PromotionName = p.PromotionName,
                Description = p.Description,
                DiscountPercentage = p.DiscountPercentage,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                IsActive = p.IsActive
            }).ToList();
        }

        // Thêm mã giảm giá mới
        public bool AddPromotion(PromotionDTO promotionDTO)
        {
            // Kiểm tra tên mã giảm giá đã tồn tại (không phân biệt hoa thường)
            bool isDuplicate = _context.GetAll()
                .Any(p => p.PromotionName.ToLower() == promotionDTO.PromotionName.ToLower());

            if (isDuplicate)
            {
                return false; // Thêm thất bại do trùng tên
            }

            Promotion promotion = new Promotion
            {
                PromotionName = promotionDTO.PromotionName,
                Description = promotionDTO.Description,
                DiscountPercentage = promotionDTO.DiscountPercentage,
                StartDate = promotionDTO.StartDate,
                EndDate = promotionDTO.EndDate,
                IsActive = promotionDTO.IsActive
            };

            _context.Add(promotion);
            _context.SaveChanges();
            return true; // Thêm thành công
        }

        // Cập nhật mã giảm giá
        public bool UpdatePromotion (PromotionDTO promotionDTO)
        {
            var existingPromotion = _context.GetById(promotionDTO.PromotionID);
            if (existingPromotion == null)
                return false;

            existingPromotion.PromotionName = promotionDTO.PromotionName;
            existingPromotion.Description = promotionDTO.Description;
            existingPromotion.DiscountPercentage = promotionDTO.DiscountPercentage;
            existingPromotion.StartDate = promotionDTO.StartDate;
            existingPromotion.EndDate = promotionDTO.EndDate;
            existingPromotion.IsActive = promotionDTO.IsActive;
            _context.Update(existingPromotion);
            _context.SaveChanges();
            return true;
        }

        // Xóa mã giảm giá
        public bool DeletePromotion(int promotionId)
        {
            var promotion = _context.GetById(promotionId);
            if (promotion == null)
                return false;

            _context.Delete(promotion);
            _context.SaveChanges();
            return true;
        }

        // Tìm kiếm mã giảm giá theo tên
        public List<PromotionDTO> SearchPromotionByName(string keyword)
        {
            var matchedPromotion = _context.GetAll()
                .Where(p => p.PromotionName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedPromotion.Select(p => new PromotionDTO
            {
                PromotionID = p.PromotionID,
                PromotionName = p.PromotionName,
                Description = p.Description,
                DiscountPercentage = p.DiscountPercentage,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                IsActive = p.IsActive
            }).ToList();
        }
    }
}

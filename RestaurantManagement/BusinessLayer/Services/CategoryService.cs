using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Services
{
    public class CategoryService
    {
        private readonly Repository<Category> _context;

        public CategoryService()
        {
            _context = new Repository<Category>();
        }

        // Lấy danh sách danh mục
        public List<CategoryDTO> GetCategories()
        {
            var categories = _context.GetAll().ToList();

            return categories.Select(c => new CategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                Image = c.Image
            }).ToList();
        }

        // Thêm danh mục mới
        public bool AddCategory(CategoryDTO categoryDTO)
        {
            // Kiểm tra tên danh mục đã tồn tại (không phân biệt hoa thường)
            bool isDuplicate = _context.GetAll()
                .Any(c => c.CategoryName.ToLower() == categoryDTO.CategoryName.ToLower());

            if (isDuplicate)
            {
                return false; // Thêm thất bại do trùng tên
            }

            var category = new Category
            {
                CategoryName = categoryDTO.CategoryName,
                Image = categoryDTO.Image
            };

            _context.Add(category);
            _context.SaveChanges();
            return true; // Thêm thành công
        }

        // Cập nhật danh mục
        public bool UpdateCategory(CategoryDTO categoryDTO)
        {
            var existingCategory = _context.GetById(categoryDTO.CategoryID);
            if (existingCategory == null)
                return false;

            bool isDuplicate = _context.GetAll()
             .Any(c => c.CategoryName.ToLower() == categoryDTO.CategoryName.ToLower());

            if (isDuplicate)
            {
                return false; // Update thất bại do trùng tên
            }

            existingCategory.CategoryName = categoryDTO.CategoryName;

            _context.Update(existingCategory);
            _context.SaveChanges();
            return true;
        }

        // Xóa danh mục
        public bool DeleteCategory(int categoryId)
        {
            var category = _context.GetById(categoryId);
            if (category == null)
                return false;

            _context.Delete(category);
            _context.SaveChanges();
            return true;
        }

        // Tìm kiếm danh mục theo tên
        public List<CategoryDTO> SearchCategoriesByName(string keyword)
        {
            var matchedCategories = _context.GetAll()
                .Where(c => c.CategoryName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedCategories.Select(c => new CategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName
            }).ToList();
        }
    }
}

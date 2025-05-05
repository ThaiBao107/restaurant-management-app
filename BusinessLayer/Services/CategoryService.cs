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
    public class CategoryService
    {
        private readonly Repository<Category> _repository;

        public CategoryService()
        {
            _repository = new Repository<Category>();
        }

        // Lấy tất cả category
        public List<CategoryDTO> GetAllCategories()
        {
            var categories = _repository.GetAll(); // Lấy danh sách entity 

            // Chuyển sang DTO
            return categories.Select(c => new CategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).ToList();
        }

        // Lấy category theo ID
        public bool GetCategoryById(int id)
        {
            return true;
            //return _repository.GetById(id);
        }

        // Thêm mới category
        public bool AddCategory(CategoryDTO categoryDTO)
        {
            try
            {
                var category = new Category
                {
                    CategoryName = categoryDTO.CategoryName,
                    Description = categoryDTO.Description
                };

                _repository.Add(category);
                _repository.SaveChanges();
                return true; // Thêm thành công
            }
            catch (Exception)
            {
                return false; // Có lỗi khi thêm
            }
        }

        // Cập nhật category
        public bool UpdateCategory(CategoryDTO categoryDTO)
        {
            try
            {
                var category = new Category
                {
                    CategoryName = categoryDTO.CategoryName,
                    Description = categoryDTO.Description
                };

                _repository.Update(category);
                _repository.SaveChanges();
                return true; // Thêm thành công
            }
            catch (Exception)
            {
                return false; // Có lỗi khi thêm
            }
        }

        // Xóa category
        public void DeleteCategory(int id)
        {
            var category = _repository.GetById(id);
            if (category != null)
            {
                _repository.Delete(category);
                _repository.SaveChanges();
            }
        }
    }
}

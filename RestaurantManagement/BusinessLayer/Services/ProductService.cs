using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProductService
    {
        private readonly Repository<Product> _context;

        public ProductService()
        {
            _context = new Repository<Product>();
        }

        // Lấy tất cả sản phẩm
        public List<ProductDTO> GetProducts()
        {
            var products = _context.GetAll().ToList();

            return products.Select(p => new ProductDTO
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price,
                Description = p.Description,
                Image = p.Image,
                IsAvailable = p.IsAvailable,
                CategoryID = p.CategoryID
            }).ToList();
        }

        // Thêm sản phẩm mới
        public bool AddProduct(ProductDTO productDTO)
        {
            var product = new Product
            {
                ProductName = productDTO.ProductName,
                Price = productDTO.Price,
                Description = productDTO.Description,
                Image = productDTO.Image,
                IsAvailable = productDTO.IsAvailable,
                CategoryID = productDTO.CategoryID
            };

            _context.Add(product);
            _context.SaveChanges();
            return true;
        }

        // Cập nhật sản phẩm
        public bool UpdateProduct(ProductDTO productDTO)
        {
            var existingProduct = _context.GetById(productDTO.ProductID);
            if (existingProduct == null)
                return false;

            existingProduct.ProductName = productDTO.ProductName;
            existingProduct.Price = productDTO.Price;
            existingProduct.Description = productDTO.Description;
            existingProduct.Image = productDTO.Image;
            existingProduct.IsAvailable = productDTO.IsAvailable;
            existingProduct.CategoryID = productDTO.CategoryID;

            _context.Update(existingProduct);
            _context.SaveChanges();
            return true;
        }

        // Xóa sản phẩm
        public bool DeleteProduct(int productId)
        {
            var product = _context.GetById(productId);
            if (product == null)
                return false;

            _context.Delete(product);
            _context.SaveChanges();
            return true;
        }

        // Tìm kiếm sản phẩm theo tên
        public List<ProductDTO> SearchProductsByName(string keyword)
        {
            var matchedProducts = _context.GetAll()
                .Where(p => p.ProductName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedProducts.Select(p => new ProductDTO
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price,
                Description = p.Description,
                Image = p.Image,
                IsAvailable = p.IsAvailable,
                CategoryID = p.CategoryID
            }).ToList();
        }



        public List<ProductDTO> getAllProductByCategorieID(int categoriesID)
        {

            //where p.CategoryID == 1
            try
            {

                if (categoriesID != -1)
                {
                    var query = _context.GetAll().Where(p => p.CategoryID == categoriesID);
                    return query.Select(p => new DTOs.ProductDTO
                                 {
                                     ProductID = p.ProductID,
                                     ProductName = p.ProductName,
                                     Price = p.Price,
                                     IsAvailable = p.IsAvailable,
                                     Description = p.Description,
                                     CategoryID = p.CategoryID,
                                     Image = p.Image
                                 }).ToList();
                }
                else
                {
                    var products = _context.GetAll().Select(p => new DTOs.ProductDTO
                    {
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        Price = p.Price,
                        IsAvailable = p.IsAvailable,
                        Description = p.Description,
                        CategoryID = p.CategoryID,
                        Image = p.Image
                    }).ToList();
                    return products;
                }


            }
            catch (Exception ex) { throw ex; }
        }
    }
}

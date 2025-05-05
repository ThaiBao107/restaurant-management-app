using RestaurantManagement.DAL.Models;
using RestaurantManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using BusinessLayer.DTOs;

namespace BusinessLayer.Services
{
    public class LoadProducts
    {
        private readonly RestaurantDbContext context;

        public LoadProducts()
        {
            this.context = new RestaurantDbContext();
        }

        public List<DTOs.Products> getAllCategories(int categoriesID)
        {
            
            //where p.CategoryID == 1
            try
            {
               
                if (categoriesID != -1)
                {
                    var query = (from p in context.Products
                                where p.CategoryID == categoriesID
                                select new DTOs.Products
                                {
                                    id = p.ProductID,
                                    productName = p.ProductName,
                                    price = p.Price,
                                    isAvailable = p.IsAvailable,
                                    Description = p.Description,
                                    CategoriesID = p.CategoryID
                                }).ToList();
                    return query;

                }
                else
                {
                    var products = this.context.Products.Select(p => new DTOs.Products
                    {
                        id = p.ProductID,
                        productName = p.ProductName,
                        price = p.Price,
                        isAvailable = p.IsAvailable,
                        Description = p.Description,
                        CategoriesID = p.CategoryID
                    }).ToList();
                    return products;
                }
                
                
            }
            catch (Exception ex) { throw ex; }




        }
    }
}

using BusinessLayer.DTOs;
using RestaurantManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class OrderDetailsService
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public OrderDetailsService()
        {
            this.restaurantDbContext = new RestaurantDbContext();
        }

        public ProductDTO GetProduct(int productID)
        {
            try
            {
                ProductDTO product = new ProductDTO();
                var item = restaurantDbContext.Products.Where(x => x.ProductID == productID).FirstOrDefault();
                product.ProductID = item.ProductID;
                product.ProductName = item.ProductName;
                product.Price = item.Price;
                return product;
            }
            catch(Exception ex){ throw ex; }
        }

        public List<ProductDTO> loadOrderDetails(int id)
        {
            try
            {
                    List<ProductDTO> productDTOs = new List<ProductDTO>();
                var item = (from i in this.restaurantDbContext.OrderDetails
                            where i.OrderID == id
                            select new
                            {
                                i.ProductID, i.Quantity
                            }).ToList();

                    foreach(var i in item )
                    {
                        ProductDTO p = this.GetProduct(i.ProductID);
                    p.quatity = i.Quantity;
                    productDTOs.Add(p);
                    }
                    return productDTOs;

            }
            catch (Exception ex) { throw ex; }
        }
    }
}

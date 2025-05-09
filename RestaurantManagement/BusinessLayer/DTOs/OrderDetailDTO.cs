using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class OrderDetailDTO
    {
        //public OrderDetailDTO(int productID, int quantity, decimal uniprice)
        //{
        //    this.ProductId = productID;
        //    this.Quantity = quantity;
        //    this.UnitPrice = uniprice;
        //}

        //public OrderDetailDTO(int orderDID, int orderID, int productID, int quantity, decimal uniprice)
        //{
        //    this.OrderDetailId = orderDID;
        //    this.OrderId = orderID;
        //    this.ProductId = productID;
        //    this.UnitPrice= uniprice;
        //    this.Quantity = quantity;
        //}


        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }    
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

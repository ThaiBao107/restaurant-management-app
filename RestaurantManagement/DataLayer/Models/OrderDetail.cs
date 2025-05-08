using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class OrderDetail
    {
        public OrderDetail( int orderID, int productId, int quantity, decimal unitprice)
        {
            
            this.OrderID = orderID;
            this.ProductID  = productId;
            this.Quantity = quantity;
            this.UnitPrice = unitprice;
        }

        [Key]
        public int OrderDetailID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "UnitPrice must be non-negative")]
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
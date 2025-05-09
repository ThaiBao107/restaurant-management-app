using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{

    public enum OrderStatus
    {
        Pending, Paid, Cancelled
    }
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public int StaffID {get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public int? PromotionId { get; set; }
        public OrderStatus Status { get; set; }

    }
    
}

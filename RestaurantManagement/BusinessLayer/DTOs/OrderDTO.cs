using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{

    public enum orderStatus
    {
        Pending, Paid, Cancelled
    }
    public class OrderDTO
    {
        public OrderDTO(int cusID, int tabID, int staID, DateTime date, float Total, int status)
        {
            this.CustomerID = cusID;
            this.TableID = tabID;
            this.StaffID = staID;
            this.OrderDate = date;
            this.TotalAmount = Total;
            this.Status = orderStatus.Paid;
        }

        //public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public int StaffID {get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public int? PromotionId { get; set; }
        public orderStatus Status { get; set; }

    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace RestaurantManagement.DAL.Models
{
    public enum OrderStatus
    {
        Pending, Paid, Cancelled
    }

    public class Order
    {
        //public Order(int cusID, int tabID, int staID, DateTime date, float Total)
        //{
        //    this.CustomerID = cusID;
        //    this.TableID = tabID;
        //    this.StaffID = staID;
        //    this.OrderDate = date;
        //    this.TotalAmount = Total;
        //    this.Status = OrderStatus.Paid;
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Table")]
        public int TableID { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public double TotalAmount { get; set; }

        [ForeignKey("Promotion")]
        public int? PromotionID { get; set; }

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public virtual Customer Customer { get; set; }
        public virtual Table Table { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Promotion Promotion { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
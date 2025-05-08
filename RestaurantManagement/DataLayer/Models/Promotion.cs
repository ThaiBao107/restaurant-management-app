using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class Promotion
    {
        [Key]
        public int PromotionID { get; set; }

        [Required, StringLength(100)]
        public string PromotionName { get; set; }

        public string Description { get; set; }

        [Required, Range(0, 100)]
        public double DiscountPercentage { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
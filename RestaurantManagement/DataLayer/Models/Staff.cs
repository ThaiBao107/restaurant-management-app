using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public enum StaffRole
    {
        Manager,
        Waiter,
        Cashier,
        Chef
    }

    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public StaffRole Role { get; set; }

        [Phone, StringLength(10)]
        public string Phone { get; set; }

        [EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public double Salary { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
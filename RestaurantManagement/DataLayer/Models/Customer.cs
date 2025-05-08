using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Phone, StringLength(10)]
        public string Phone { get; set; }

        [EmailAddress, StringLength(100)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public int LoyaltyPoints { get; set; } = 0;

        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
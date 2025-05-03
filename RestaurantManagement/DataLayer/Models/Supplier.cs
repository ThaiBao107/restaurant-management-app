using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required, StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Phone, Required, StringLength(10)]
        public string PhoneNumber { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
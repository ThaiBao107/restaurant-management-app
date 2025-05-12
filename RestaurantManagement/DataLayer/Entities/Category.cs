using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required, StringLength(100)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
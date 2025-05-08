using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }

        [Required, StringLength(100)]
        public string IngredientName { get; set; }

        [Required, StringLength(50)]
        public string Unit { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "StockQuantity must be non-negative")]
        public double StockQuantity { get; set; } = 0;

        [Required]
        public int SupplierID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
    }
}
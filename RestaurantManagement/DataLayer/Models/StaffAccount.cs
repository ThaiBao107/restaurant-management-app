using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public class StaffAccount
    {
        [Key]
        public int AccountID { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
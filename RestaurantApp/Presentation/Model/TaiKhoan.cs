using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public int maNguoi { get; set; }
        [ForeignKey(nameof(maNguoi))]
        public Nguoi Nguoi { get; set; }
    }
}

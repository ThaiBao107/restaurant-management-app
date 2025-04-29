using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime NgayDat { get; set; } = DateTime.Now;
        public int MaKH {  get; set; }
        [ForeignKey(nameof(MaKH))]
        public KhachHang KhachHang { get; set; }
       

    }
}

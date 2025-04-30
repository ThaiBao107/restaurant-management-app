using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    [Table("LichSuGiaoDich")]
    public class LichSuGiaoDich
    {
        [Key]
        public int Id { get; set; }
        public int KhachHangId { get; set; }
        [ForeignKey(nameof(KhachHangId))]
        public KhachHang KhachHang { get; set; }
    }
}

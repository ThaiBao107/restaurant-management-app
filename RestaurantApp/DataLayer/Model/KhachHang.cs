using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    [Table("KhachHang")]
    public class KhachHang : Nguoi
    {

        public double? DiemTichLuy { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<LichSuGiaoDich> LichSuGiaoDichs { get; set; }
    }
}

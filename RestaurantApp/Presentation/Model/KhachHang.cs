using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    [Table("KhachHang")]
    public class KhachHang:Nguoi
    {
       
        public double? DiemTichLuy { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}

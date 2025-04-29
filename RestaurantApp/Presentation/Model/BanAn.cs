using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public enum KhuVuc
    {
        G,L1,L2,L3
    }
    public enum TrangThai
    {
        Trong,
        DaDat,
        DangCoKhach
    }
    [Table("BanAn")]
    public class BanAn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SoBan { get; set; }
        [Required]
        public KhuVuc KhuVuc { get; set; }
        [Required]
        public TrangThai TrangThai { get; set; }
        public string GhiChu { get; set; }
       public virtual ICollection<DonHang> DonHangs { get; set; }
     }
}

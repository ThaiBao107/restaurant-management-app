using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public enum TrangThaiThanhToan
    {
        ChuaThanhToan,
        DaThanhToan
    }
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime NgayDat { get; set; } = DateTime.Now;
        
        public int MaKH { get; set; }
        [ForeignKey(nameof(MaKH))]
        public KhachHang KhachHang { get; set; }
        public int MaHD { get; set; }   
        [ForeignKey(nameof(MaHD))]
        public HoaDon HoaDon { get; set; }
        public TrangThaiThanhToan TrangThaiThanhToan { get; set; }
        public virtual ICollection<DonHangBanAn> DonHangBanAns { get; set; }



    }
}

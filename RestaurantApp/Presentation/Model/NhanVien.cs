using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public enum Status
    {
        CaSang,
        CaChieu,
        CaToi
    }
    public enum Sex
    {
        Male,
        Female
    }

    public enum ChucVu
    {
        NVQuanLy,
        NVThuNgan,
        NVPhucVu
    }
    [Table("NhanVien")]
    public class NhanVien:Nguoi
    {

            public double Luong { get; set; }
            [Required]
            public Status CaLam { get; set; }
            public DateTime NgaySinh { get; set; }
            public DateTime NgayVaoLam { get; set; }
            public Sex GioiTinh { get; set; }
            [StringLength(100)]
            public string Mail { get; set; }
            public ChucVu ChucVu { get; set; }
    }
}

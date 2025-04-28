using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFrist.Data
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
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string ho { get; set; }
        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        public double luong { get; set; }
        [Required]
        public Status caLam { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayVaoLam { get; set; }
        public Sex gioiTinh { get; set; }
        [StringLength(100)]
        public string mail { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public enum DonViTinh
    {
        Kilogram,gram
    }
    [Table("MonAn")]
    public class MonAn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TenMonAn { get; set; }   
        public double GiaBan {  get; set; }
        public DonViTinh DonViTinh { get; set; }
        [Required]
        [StringLength(100)]
        public string GhiChu {  get; set; }
        public int LoaiId {  get; set; }
        [ForeignKey(nameof(LoaiId))]
        public Loai Loai { get; set; }
    }
}

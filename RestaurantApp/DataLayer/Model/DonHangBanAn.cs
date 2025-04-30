using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    [Table("DonHangBanAn")]
    public class DonHangBanAn
    {
        [Key]
        public int Id { get; set; }
        public int BanAnId { get; set; }
        [ForeignKey(nameof(BanAnId))]
        public BanAn BanAn { get; set; }
        public int DonHangId {  get; set; }
        [ForeignKey(nameof(DonHangId))]
        public DonHang DonHang { get; set; }
    }
}

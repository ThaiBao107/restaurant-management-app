using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string TenLoai {  get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}

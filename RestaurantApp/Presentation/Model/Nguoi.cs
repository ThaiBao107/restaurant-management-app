using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public class Nguoi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Ho { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}

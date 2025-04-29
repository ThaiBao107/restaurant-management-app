using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        public double TongTien { get; set; }
        public string GhiChu { get; set; }  
    }
}

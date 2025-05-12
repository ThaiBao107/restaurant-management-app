using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryID { get; set; }
        //Tam thoi di
        public int quatity { get; set; }
    }
}

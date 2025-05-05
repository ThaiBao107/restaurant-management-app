using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class Products
    {
        public int id { get; set; }
        public string productName {  get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }
        public string Description { get; set; }
        public int CategoriesID {  get; set; }

    }
}

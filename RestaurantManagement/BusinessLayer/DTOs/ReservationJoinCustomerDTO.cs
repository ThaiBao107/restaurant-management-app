using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class ReservationJoinCustomerDTO : ReservationDTO
    {
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    }
}

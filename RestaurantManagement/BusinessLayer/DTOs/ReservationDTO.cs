using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public enum ReservationStatusDTO
    {
        Pending,
        Confirmed,
        Cancelled
    }
    public class ReservationDTO
    {
        public int ReservationID { get; set; }

        public int CustomerID { get; set; }

        public int TableID { get; set; }

        public DateTime ReservationTime { get; set; }

        public int NumberOfGuests { get; set; }
        public ReservationStatusDTO Status { get; set; }
    }
}

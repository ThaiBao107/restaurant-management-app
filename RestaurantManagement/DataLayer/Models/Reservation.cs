using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DAL.Models
{
    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }

    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Table")]
        public int TableID { get; set; }

        [Required]
        public DateTime ReservationTime { get; set; }

        [Required]
        public int NumberOfGuests { get; set; }

        [Required]
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public virtual Customer Customer { get; set; }
        public virtual Table Table { get; set; }
    }
}
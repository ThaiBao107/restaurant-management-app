using RestaurantManagement.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public enum TableStatus
{
    Available,
    Occupied,
    Reserved
}

public class Table
{
    [Key]
    public int TableID { get; set; }

    [Required, StringLength(10)]
    public string TableNumber { get; set; }

    [Required]
    public int Capacity { get; set; }

    [Required]
    public TableStatus Status { get; set; } = TableStatus.Available;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

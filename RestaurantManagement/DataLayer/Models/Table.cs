using RestaurantManagement.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public enum TableStatus
{
    Available,
    Occupied,
    Reserved
}

public enum Area
{
    G,L1,L2,L3
}

public class Table
{
    [Key]
    public int TableID { get; set; }

    [Required, StringLength(10)]
    public string TableNumber { get; set; }

    public int Capacity { get; set; }

    [Required]
    public Area Area { get; set; } = Area.G;

   
    public TableStatus Status { get; set; } = TableStatus.Available;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

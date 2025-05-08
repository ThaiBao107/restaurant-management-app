using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public enum TableStatus
    {
        Available,
        Occupied,
        Reserved
    }

    public enum Area
    {
        G, L1, L2, L3
    }

    public class TableDTO
    {
        public int TableID { get; set; }

        public string TableNumber { get; set; }

        public int Capacity { get; set; }

        public Area Area { get; set; }

        public TableStatus Status { get; set; }
    }
}

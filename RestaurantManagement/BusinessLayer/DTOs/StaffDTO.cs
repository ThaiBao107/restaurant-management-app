using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
   
        public enum StaffRoleDTO
        {
            Manager,
            Waiter,
            Cashier,
            Chef,
            Cleaner
        }

        public enum SexDTO
        {
            Male,
            Female
        }

        public enum ShiftDTO
        {
            Morning,
            Afternoon,
            Eveving
        }

        public class StaffDTO
        {
            public int StaffID { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public StaffRoleDTO Role { get; set; }

            public SexDTO Sex { get; set; }

            public ShiftDTO Shift { get; set; }

            public string Phone { get; set; }

            public string Email { get; set; }

            public DateTime HireDate { get; set; }

            public double Salary { get; set; }
        }
    
}

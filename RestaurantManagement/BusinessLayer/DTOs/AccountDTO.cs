using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class AccountDTO
    {
        public int AccountID { get; set; }
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

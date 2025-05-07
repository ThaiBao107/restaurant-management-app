using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using RestaurantManagement.DAL;
namespace BusinessLayer.Services
{
    public class LoadStaffs
    {
        private RestaurantDbContext res;

        public LoadStaffs()
        {
            this.res = new RestaurantDbContext();
        }
        public List<DTOs.StaffDTO> getStaffs()
        {

            
            try
            {


                var query = (from s in this.res.Staffs

                             select new DTOs.StaffDTO
                             {
                                 StaffID = s.StaffID,
                                 FirstName = s.FirstName,
                                 LastName = s.LastName,
                                 Role = (DTOs.StaffRoleDTO)s.Role,
                                 Sex = (DTOs.SexDTO)s.Sex,
                                 Shift = (DTOs.ShiftDTO)s.Shift,
                                 Phone = s.Phone,
                                 Email = s.Email,
                                 HireDate = s.HireDate,
                                 Salary = s.Salary
                             }).ToList();
                return query;
            }
            catch (Exception ex) { throw ex; }

        }
    }
}

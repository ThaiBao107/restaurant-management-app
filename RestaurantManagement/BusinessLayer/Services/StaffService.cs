using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class StaffService
    {
        private readonly Repository<Staff> _context;

        public StaffService()
        {
            _context = new Repository<Staff>();
        }

        public List<StaffDTO> GetStaffs()
        {
            var staff = _context.GetAll().ToList();

            return staff.Select(s => new StaffDTO
            {
                StaffID = s.StaffID,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Sex = (DTOs.SexDTO)s.Sex,
                Role = (DTOs.StaffRoleDTO)s.Role,
                Phone = s.Phone,
                Email = s.Email,
                Shift = (DTOs.ShiftDTO)s.Shift,
                Salary = s.Salary
            }).ToList();
        }

        public bool AddStaff(StaffDTO staffDTO)
        {
            bool isDuplicate = _context.GetAll()
                .Any(s => s.Phone.ToLower() == staffDTO.Phone.ToLower());

            if (isDuplicate)
            {
                return false; 
            }

            var staff = new Staff
            {
                FirstName = staffDTO.FirstName,
                LastName = staffDTO.LastName,
                Sex = (RestaurantManagement.DAL.Models.Sex)staffDTO.Sex,
                Role = (RestaurantManagement.DAL.Models.StaffRole)staffDTO.Role,
                Phone = staffDTO.Phone,
                Email = staffDTO.Email,
                Shift = (RestaurantManagement.DAL.Models.Shift)staffDTO.Shift,
                Salary = staffDTO.Salary
            };

            _context.Add(staff);
            _context.SaveChanges();
            return true; // Thêm thành công
        }

        public bool UpdateStaff(StaffDTO staffDTO)
        {
            var existingStaff = _context.GetById(staffDTO.StaffID);
            if (existingStaff == null)
                return false;

            existingStaff.FirstName = staffDTO.FirstName;
            existingStaff.LastName = staffDTO.LastName;
            existingStaff.Sex = (RestaurantManagement.DAL.Models.Sex)staffDTO.Sex;
            existingStaff.Role = (RestaurantManagement.DAL.Models.StaffRole)staffDTO.Role;
            existingStaff.Phone = staffDTO.Phone;
            existingStaff.Email = staffDTO.Email;
            existingStaff.Shift = (RestaurantManagement.DAL.Models.Shift)staffDTO.Shift;
            existingStaff.Salary = staffDTO.Salary;

            _context.Update(existingStaff);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStaff(int staffId)
        {
            var staff = _context.GetById(staffId);
            if (staff == null)
                return false;

            _context.Delete(staff);
            _context.SaveChanges();
            return true;
        }

        public List<StaffDTO> SearchStaffsByName(string keyword)
        {
            var matchedStaffs = _context.GetAll()
                .Where(s => s.FirstName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedStaffs.Select(s => new StaffDTO
            {
                StaffID = s.StaffID,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Sex = (DTOs.SexDTO)s.Sex,
                Role = (DTOs.StaffRoleDTO)s.Role,
                Phone = s.Phone,
                Email = s.Email,
                Shift = (DTOs.ShiftDTO)s.Shift,
                Salary = s.Salary
            }).ToList();
        }
    }
}

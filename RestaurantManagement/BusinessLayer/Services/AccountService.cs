using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTOs;
using DataLayer;
using DataLayer.Repositories;
using RestaurantManagement.DAL;
using RestaurantManagement.DAL.Models;

namespace BusinessLayer.Services
{
    public class AccountService
    {
        private readonly Repository<StaffAccount> _context;

        public AccountService()
        {
            _context = new Repository<StaffAccount>();
        }

        public AccountDTO Login(string username, string password)
        {

            var user = _context.GetAll().FirstOrDefault(a => a.Username == username && a.Password == password);

            if (user == null)
                return null;

            var staffService = new StaffService();
            var staff = staffService.GetStaffs()
                .FirstOrDefault(s => s.StaffID == user.StaffID);

            if (staff == null)
                return null;

            USER = user.Username;
            ROLE = staff.Role;

            return new AccountDTO
            {
                AccountID = user.AccountID,
                Username = user.Username,
                StaffID = user.StaffID
            };
        }


        public static string user;
        public static StaffRoleDTO ROLE { get; private set; }

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        public bool AddAccount(AccountDTO accountDTO)
        {
            bool isDuplicate = _context.GetAll()
                .Any(a => a.Username.ToLower() == accountDTO.Username.ToLower());

            if (isDuplicate)
            {
                return false; // Thêm thất bại do trùng tên
            }

            var account = new StaffAccount
            {
                Username = accountDTO.Username,
                Password = accountDTO.Password,
                AccountID = accountDTO.AccountID,
                StaffID = accountDTO.StaffID
            };

            _context.Add(account);
            _context.SaveChanges();
            return true; // Thêm thành công
        }

        public List<AccountDTO> GetAccounts()
        {
            var accounts = _context.GetAll().ToList();

            return accounts.Select(a => new AccountDTO
            {
                AccountID = a.AccountID,
                Username = a.Username,
                Password = a.Password,
                StaffID = a.StaffID
            }).ToList();
        }

        public bool UpdateAccount(AccountDTO accountDTO)
        {
            var existingCategory = _context.GetById(accountDTO.AccountID);
            if (existingCategory == null)
                return false;

            existingCategory.AccountID = accountDTO.AccountID;
            existingCategory.StaffID = accountDTO.StaffID;
            existingCategory.Username = accountDTO.Username;
            existingCategory.Password = accountDTO.Password;

            _context.Update(existingCategory);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteAccount(int accountId)
        {
            var account = _context.GetById(accountId);
            if (account == null)
                return false;

            _context.Delete(account);
            _context.SaveChanges();
            return true;
        }
    }
}

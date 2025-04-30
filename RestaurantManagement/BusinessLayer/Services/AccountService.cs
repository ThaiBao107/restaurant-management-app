using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTOs;
using DataLayer;
using RestaurantManagement.DAL;
using RestaurantManagement.DAL.Models;

namespace BusinessLayer.Services
{
    public class AccountService
    {
        private readonly RestaurantDbContext _context;

        public AccountService()
        {
            _context = new RestaurantDbContext();
        }

        public AccountDTO Login(string username, string password)
        {
            var user =  _context.StaffAccounts.FirstOrDefault(a => a.Username == username && a.Password == password);
            if (user == null)
                return null;
            return new AccountDTO
            {
                AccountID = user.AccountID,
                Username = user.Username,
                StaffID = user.StaffID
            };
        }
    }
}

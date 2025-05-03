using System;
using System.Collections.Generic;
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
            var user =  _context.GetAll().FirstOrDefault(a => a.Username == username && a.Password == password);
            if (user == null)
                return null;
            USER = user.Username;
            return new AccountDTO
            {
                AccountID = user.AccountID,
                Username = user.Username,
                StaffID = user.StaffID
            };
        }


        //Create property for username
        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}

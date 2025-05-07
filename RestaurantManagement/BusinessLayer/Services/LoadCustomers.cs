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
    public class LoadCustomers
    {
        private RestaurantDbContext res;

        public LoadCustomers()
        {
            this.res = new RestaurantDbContext();
        }

        public List<CustomerDTO> loadCustomer()
        {
            try
            {
                var customer = (from c in this.res.Customers
                                select new DTOs.CustomerDTO
                                {
                                    Id = c.CustomerID,
                                    FName = c.FirstName,
                                    LName = c.LastName,
                                    Phone = c.Phone,
                                    Email = c.Email,
                                    Address = c.Address,
                                    LoyaltyPoints = c.LoyaltyPoints
                                }).ToList();
                return customer;

            }
            catch (Exception ex) { throw ex; }
        }

        public string checkPhone(string phone)
        {
            string result = "-1";
            List<CustomerDTO> cus = this.loadCustomer();
            foreach (var item in cus)
            {
                if(phone.Equals(item.Phone) == true)
                {
                    result = item.Id.ToString();
                    break;
                }
            }
            return result;

        }
    }
}

using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CustomerService
    {
        private readonly Repository<Customer> _context;

        public CustomerService()
        {
            _context = new Repository<Customer>();
        }

        // Lấy danh sách danh mục
        public List<CustomerDTO> GetCustomer()
        {
            var customer = _context.GetAll().ToList();

            return customer.Select(c => new CustomerDTO
            {
                CustomerID = c.CustomerID,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Phone = c.Phone,
                Email = c.Email,
                Address = c.Address
            }).ToList();
        }

        // Thêm danh mục mới
        public bool AddCustomer(CustomerDTO customerDTO)
        {
            bool isDuplicate = _context.GetAll()
               .Any(p => p.Phone.ToLower() == customerDTO.Phone);

            if (isDuplicate)
            {
                return false;
            }

            var customer = new Customer
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Phone = customerDTO.Phone,
                Email = customerDTO.Email,
                Address = customerDTO.Address,
            };

            _context.Add(customer);
            _context.SaveChanges();
            return true;
        }

        // Cập nhật danh mục
        public bool UpdateCustomer(CustomerDTO customerDTO)
        {
            bool isDuplicate = _context.GetAll()
              .Any(p => p.Phone.ToLower() == customerDTO.Phone);

            if (isDuplicate)
            {
                return false;
            }


            var existingCustomer = _context.GetById(customerDTO.CustomerID);
            if (existingCustomer == null)
                return false;


            existingCustomer.FirstName = customerDTO.FirstName;
            existingCustomer.LastName = customerDTO.LastName;
            existingCustomer.Phone = customerDTO.Phone;
            existingCustomer.Email = customerDTO.Email;
            existingCustomer.Address = customerDTO.Address;
            

            _context.Update(existingCustomer);
            _context.SaveChanges();
            return true;
        }

        // Xóa danh mục
        public bool DeleteCustomer(int customerID)
        {
            var customer = _context.GetById(customerID);
            if (customer == null)
                return false;

            _context.Delete(customer);
            _context.SaveChanges();
            return true;
        }

        // Tìm kiếm danh mục theo tên
        public List<CustomerDTO> SearchCustomerByName(string keyword)
        {
            var matchedCustomers = _context.GetAll()
                .Where(c => c.FirstName.ToLower().Contains(keyword.ToLower()) || c.LastName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedCustomers.Select(c => new CustomerDTO
            {
                CustomerID = c.CustomerID,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Phone = c.Phone,
                Email = c.Email,
                Address = c.Address
            }).ToList();
        }

        public bool SearchCustomerByID(int keyword)
        {
            var matchedCustomers = _context.GetById(keyword);
            if (matchedCustomers != null)
                return true;
            return false;
                
        }
        public string GetCustomerNameByID(int keyword)
        {
            var matchedCustomer = _context.GetById(keyword);
            return matchedCustomer.FirstName;
        }
        public string GetCustomerPhoneByID(int keyword)
        {
            var matchedCustomer = _context.GetById(keyword);
            return matchedCustomer.Phone;
        }

        public CustomerDTO CheckCustomerByPhone(string phone)
        {
            
            try
            {
                var customer = _context.GetAll().FirstOrDefault(p => p.Phone == phone);
                return new CustomerDTO
                {
                    FirstName = customer.FirstName
                };
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Object null: " + ex.Message);
                throw; // hoặc xử lý theo logic riêng
            }
        }
    }
}

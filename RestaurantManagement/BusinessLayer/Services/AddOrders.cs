using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
namespace BusinessLayer.Services
{
    public class AddOrders
    {
        private readonly Repository<Order> _context;

        public AddOrders()
        {
            this._context = new Repository<Order>();
        }

        public bool AddOrder(DTOs.OrderDTO o)
        {
            try
            {
                
                Order order = new Order(o.CustomerID, o.TableID, o.StaffID, o.OrderDate, o.TotalAmount);
                this._context.Add(order);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool checkOrder(int CustomerId, int TableId, int StaddId, DateTime orderDate, int orderStatus, float totalAmount)
        {
            try
            {


                DTOs.OrderDTO o = new DTOs.OrderDTO(CustomerId, TableId, StaddId, orderDate, totalAmount, orderStatus);
                if(AddOrder(o)) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

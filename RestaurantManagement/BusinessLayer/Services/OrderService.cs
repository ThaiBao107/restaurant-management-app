using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

    public class OrderService
    {
        private readonly Repository<Order> _order;

        public OrderService()
        {

            this._order = new Repository<Order>();
        }

        public List<OrderDTO> loadOrder()
        {
            try

            {
                var orders = _order.GetAll().ToList();
                return orders.Select(o => new OrderDTO
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    TotalAmount = float.Parse(o.TotalAmount.ToString()),
                    Status = (DTOs.OrderStatus)o.Status

                }).ToList();


            }
            catch (Exception ex) { throw ex; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
    public class AddOrders
    {
        private readonly Repository<Order> _context;
        private readonly Repository<OrderDetail> _orders;
        private readonly Repository<Table> _tables;
        private readonly RestaurantDbContext restaurantDbContext;
        public AddOrders()
        {
            this._context = new Repository<Order>();
            this._orders = new Repository<OrderDetail>();
            this._tables = new Repository<Table>();
            this.restaurantDbContext = new RestaurantDbContext();
        }

        public void addOrderdetail(int orderID, List<DTOs.OrderDetailDTO> ods)
        {
            Console.WriteLine(orderID);
            foreach(var item in ods)
            {
                OrderDetail od = new OrderDetail(orderID, item.ProductId, item.Quantity, item.UnitPrice);
                Console.WriteLine(od.OrderID + od.ProductID + od.Quantity + od.UnitPrice);
                this._orders.Add(od); 
                
                
            }
            this._orders.SaveChanges();

        }

        private void updateTable(int tableID)
        {
            try
            {
                string cn = "Data Source=.;Initial Catalog=RestaurantManager;Integrated Security=True;Encrypt=False";
                string sql = $"update tables set Status = 0 where TableID = '{tableID}'";
                SqlConnection cnn = new SqlConnection(cn);
                SqlCommand cmd = new SqlCommand(sql,cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AddOrder(DTOs.OrderDTO o, List<DTOs.OrderDetailDTO> orderdetail)
        {
            try
            {
                
                Order order = new Order { CustomerID=o.CustomerID, TableID=o.TableID, StaffID=o.StaffID, OrderDate=o.OrderDate,TotalAmount= o.TotalAmount };
                this._context.Add(order);
                this._context.SaveChanges();
                Console.WriteLine(order.OrderID);
                addOrderdetail(int.Parse(order.OrderID.ToString()), orderdetail);
                updateTable(o.TableID);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }


        

        public bool checkOrder(int CustomerId, int TableId, int StaddId, DateTime orderDate, int orderStatus, float totalAmount, List<DTOs.OrderDetailDTO> ods)
        {
            try
            {


                DTOs.OrderDTO o = new DTOs.OrderDTO { CustomerID=CustomerId, TableID=TableId, StaffID=StaddId, OrderDate=orderDate, TotalAmount=totalAmount, Status= DTOs.OrderStatus.Paid };
                if(AddOrder(o,ods)) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

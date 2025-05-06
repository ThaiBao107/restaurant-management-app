using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTOs;
using DataLayer;
using RestaurantManagement.DAL;
namespace BusinessLayer.Services
{
    public class LoadTables
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public LoadTables()
        {
            this.restaurantDbContext = new RestaurantDbContext();
        }

        public List<Tables> GetTables()
        {
            try
            {
                var tables = this.restaurantDbContext.Tables.Select(n =>
                new Tables
                {
                    id = n.TableID,
                    TNumber = n.TableNumber,
                    Capacity = n.Capacity

                }).ToList();
                Console.WriteLine(tables);
                return tables;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

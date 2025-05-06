using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class TableService
    {
        private readonly Repository<Table> _context;

        public TableService()
        {
            _context = new Repository<Table>();
        }

        public List<TableDTO> GetTables()
        {
            var tables = _context.GetAll().ToList();

            return tables.Select(t => new TableDTO
            {
                TableID = t.TableID,
                TableNumber = t.TableNumber
            }).ToList();
        }

        public bool AddTable(TableDTO tableDTO)
        {
            bool isDuplicate = _context.GetAll()
                .Any(t => t.TableNumber.ToLower() == tableDTO.TableNumber.ToLower());

            if (isDuplicate)
            {
                return false; // Thêm thất bại do trùng tên
            }

            var table = new Table
            {
                TableNumber = tableDTO.TableNumber
            };

            _context.Add(table);
            _context.SaveChanges();
            return true; // Thêm thành công
        }

        public bool UpdateTable(TableDTO tableDTO)
        {
            var existingTable = _context.GetById(tableDTO.TableID);
            if (existingTable == null)
                return false;

            bool isDuplicate = _context.GetAll()
             .Any(t => t.TableNumber.ToLower() == tableDTO.TableNumber.ToLower());

            if (isDuplicate)
            {
                return false; // Update thất bại do trùng tên
            }

            existingTable.TableNumber = tableDTO.TableNumber;

            _context.Update(existingTable);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteTable(int tableId)
        {
            var table = _context.GetById(tableId);
            if (table == null)
                return false;

            _context.Delete(table);
            _context.SaveChanges();
            return true;
        }

        public List<TableDTO> SearchTablesByNumber(string keyword)
        {
            var matchedTables = _context.GetAll()
                .Where(t => t.TableNumber.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return matchedTables.Select(t => new TableDTO
            {
                TableNumber = t.TableNumber,
                TableID = t.TableID
            }).ToList();
        }
    }
}

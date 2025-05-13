using BusinessLayer.DTOs;
using DataLayer.Repositories;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ReservationService
    {
        private readonly Repository<Reservation> _context;
        private readonly Repository<ReservationJoinCustomerDTO> _joinCustomer;
        private CustomerService customerService;
        public ReservationService()
        {
            _context = new Repository<Reservation>();
            customerService = new CustomerService();
        }

        public List<ReservationDTO> GetReservation()
        {

            var reservations = _context.GetAll().ToList();

            return reservations.Select(r => new ReservationDTO
            {
                ReservationID = r.ReservationID,
                CustomerID = r.CustomerID,
                TableID = r.TableID,
                ReservationTime = r.ReservationTime,
                NumberOfGuests = r.NumberOfGuests,
                Status = (ReservationStatusDTO)r.Status
            }).ToList();
        }

        public void checkStatusTable(int tableID, ReservationStatus reser)
        {
            try
            {
                if(reser == ReservationStatus.Cancelled)
                {
                    string cn = "Data Source=.;Initial Catalog=RestaurantDB;Integrated Security=True;Encrypt=False";
                    string sql = $"update tables set Status = 0 where TableID = '{tableID}'";
                    SqlConnection cnn = new SqlConnection(cn);
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                else
                {
                    string cn = "Data Source=.;Initial Catalog=RestaurantDB;Integrated Security=True;Encrypt=False";
                    string sql = $"update tables set Status = 1 where TableID = '{tableID}'";
                    SqlConnection cnn = new SqlConnection(cn);
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                
            }
            catch (Exception ex) { throw ex; }
        }


        public bool AddReservation(ReservationDTO reservationDTO)
        {

            var reservations = new Reservation
            {
                ReservationID = reservationDTO.ReservationID,
                CustomerID = reservationDTO.CustomerID,
                TableID = reservationDTO.TableID,
                ReservationTime = reservationDTO.ReservationTime,
                NumberOfGuests = reservationDTO.NumberOfGuests,
                Status = (ReservationStatus)reservationDTO.Status
            };
            
            _context.Add(reservations);
            _context.SaveChanges();
            if((ReservationStatus)reservationDTO.Status == ReservationStatus.Confirmed )
                checkStatusTable(reservationDTO.TableID, ReservationStatus.Confirmed);
            else if ((ReservationStatus)reservationDTO.Status == ReservationStatus.Cancelled)
                checkStatusTable(reservationDTO.TableID, ReservationStatus.Cancelled);
            
            return true;
        }

        // Cập nhật đặt bàn
        public bool UpdateReservation(ReservationDTO reservationDTO)
        {
            var existingReservation = _context.GetById(reservationDTO.ReservationID);
            if (existingReservation == null)
                return false;

            existingReservation.ReservationID = reservationDTO.ReservationID;
            existingReservation.CustomerID = reservationDTO.CustomerID;
            existingReservation.TableID = reservationDTO.TableID;
            existingReservation.ReservationTime = reservationDTO.ReservationTime;
            existingReservation.NumberOfGuests = reservationDTO.NumberOfGuests;
            existingReservation.Status = (ReservationStatus)reservationDTO.Status;

            _context.Update(existingReservation);
            _context.SaveChanges();

            if ((ReservationStatus)reservationDTO.Status == ReservationStatus.Confirmed)
                checkStatusTable(reservationDTO.TableID, ReservationStatus.Confirmed);
            else if ((ReservationStatus)reservationDTO.Status == ReservationStatus.Cancelled)
                checkStatusTable(reservationDTO.TableID, ReservationStatus.Cancelled);
            return true;
        }

        // Xóa đặt bàn
        public bool DeleteReservation(int reservationId)
        {
            var reservation = _context.GetById(reservationId);
            if (reservation == null)
                return false;

            _context.Delete(reservation);
            _context.SaveChanges();
            return true;
        }

        // Tìm kiếm đặt bàn theo tên
        public List<ReservationJoinCustomerDTO> SearchReservationsByName(string keyword)
        {
            // Lấy tất cả dữ liệu đã join
            var joinedData = joinPhoneAndNameIntoReservation();

            // Lọc theo tên khách hàng (không phân biệt hoa thường)
            var matchedReservations = joinedData
                .Where(r => r.CustomerName.ToLower().Contains(keyword.ToLower()))
                .ToList();

            // Chuyển kết quả về dạng DTO ban đầu nếu cần (hoặc có thể trả về luôn dạng Join DTO)
            return matchedReservations.Select(r => new ReservationJoinCustomerDTO
            {
                ReservationID = r.ReservationID,
                CustomerID = r.CustomerID,
                CustomerName = r.CustomerName,
                CustomerPhone  = r.CustomerPhone,
                TableID = r.TableID,
                ReservationTime = r.ReservationTime,
                NumberOfGuests = r.NumberOfGuests,
                Status = r.Status
            }).ToList();
        }

        public List<ReservationJoinCustomerDTO> joinPhoneAndNameIntoReservation ()
        {
            List<ReservationDTO> reservations = GetReservation();
            List<ReservationJoinCustomerDTO> data = reservations.Select(r => new ReservationJoinCustomerDTO
            {
                ReservationID = r.ReservationID,
                CustomerID = r.CustomerID,
                CustomerName = customerService.GetCustomerNameByID(r.CustomerID),
                CustomerPhone = customerService.GetCustomerPhoneByID(r.CustomerID),
                TableID = r.TableID,
                ReservationTime = r.ReservationTime,
                NumberOfGuests = r.NumberOfGuests,
                Status = r.Status
            }).ToList();

            return data;
        }
    }
}

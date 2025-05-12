using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Adds
{
    public partial class frmReservationAdd : Form
    {
        private ReservationService reservationService;
        private TableService tableService;
        private CustomerService customerService;

        public frmReservationAdd()
        {
            InitializeComponent();
            reservationService = new ReservationService();
            tableService = new TableService();
            customerService = new CustomerService();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int id = 0;
        private string customerName;
        private string customerPhone;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                string customerID = txtCustomerID.Text.Trim();
                if (customerID == null)
                {
                    MessageBox.Show("Nhập ID khách hàng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerID.Clear();
                    txtCustomerID.Focus();
                }

                bool isCustomerID = customerService.SearchCustomerByID(Convert.ToInt32(customerID));
                if (!isCustomerID)
                {
                    MessageBox.Show("Mã khách hàng không có trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerID.Clear();
                    return;
                }
                
                
                try
                {

                    ReservationDTO reservation = new ReservationDTO
                    {
                        CustomerID = Convert.ToInt32(txtCustomerID.Text.Trim()),
                        TableID = Convert.ToInt32(cbTable.SelectedValue.ToString()),
                        ReservationTime = DateTime.Now,
                        NumberOfGuests = Convert.ToInt32(txtGuest.Text.Trim()),
                        Status = (ReservationStatusDTO)cbStatus.SelectedItem
                    };

                    bool result = reservationService.AddReservation(reservation);

                    if (result)
                    {
                        MessageBox.Show("Thêm đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm đặt bàn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                try
                {
                    ReservationDTO reservation = new ReservationDTO
                    {
                        ReservationID = id,
                        CustomerID = Convert.ToInt32(txtCustomerID.Text.Trim()),
                        TableID = Convert.ToInt32(cbTable.SelectedValue.ToString()),
                        ReservationTime = DateTime.Now,
                        NumberOfGuests = Convert.ToInt32(txtGuest.Text.Trim()),
                        Status = (ReservationStatusDTO)cbStatus.SelectedItem
                    };

                    bool result = reservationService.UpdateReservation(reservation);


                    if (result)
                    {
                        MessageBox.Show("Cập nhật bàn đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bàn đặt thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadData ()
        {
            cbStatus.DataSource = Enum.GetValues(typeof(ReservationStatusDTO));
            cbTable.DataSource = tableService.GetTables();
            cbTable.ValueMember = "TableID";
            
        }


        private void frmReservationAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

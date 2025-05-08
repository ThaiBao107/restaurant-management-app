using BusinessLayer.Services;
using PresentationLayer.Adds;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class frmCustomerView : Form
    {
        private CustomerService customerService;
        public frmCustomerView()
        {
            InitializeComponent();
            customerService = new CustomerService();
            dgvCustomer.RowPostPaint += dgvCustomer_RowPostPaint;
        }

        private void LoadData()
        {
            dgvCustomer.DataSource = customerService.GetCustomer();
        }


        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvCustomer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCustomer.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frm = new frmCustomerAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
                LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = customerService.SearchCustomerByName(txtSearch.Text.Trim());
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmCustomerAdd frm = new frmCustomerAdd();

                // Truyền id để check xem là edit hay delete
                frm.id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerID"].Value);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvCustomer.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int customerId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerID"].Value);
                string customerName = dgvCustomer.CurrentRow.Cells["FirstName"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa khách hàng {customerName} với mã khách hàng {customerId}?", "Xóa khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    customerService.DeleteCustomer(customerId);
                    LoadData();
                }
            }
        }
    }
}

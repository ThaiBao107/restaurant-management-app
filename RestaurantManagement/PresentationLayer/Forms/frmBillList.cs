using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DTOs;
using BusinessLayer.Services;
using PresentationLayer.Adds;
namespace PresentationLayer.Forms
{
    public partial class frmBillList : Form
    {
        private OrderService orderService;
        public frmBillList()
        {
            InitializeComponent();
            this.orderService = new OrderService();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = int.Parse(dgvOrder.Rows[row].Cells["dgvrOrderId"].Value.ToString());
            frmOrderDetails frmOrderDetails = new frmOrderDetails( id);
            frmOrderDetails.ShowDialog();
        }

        private void BillList_Load(object sender, EventArgs e)
        {
            try
            {
                
                dgvOrder.DataSource = orderService.loadOrder();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

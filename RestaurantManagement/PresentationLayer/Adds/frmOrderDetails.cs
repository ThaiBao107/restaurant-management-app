using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Services;
namespace PresentationLayer.Adds
{
    public partial class frmOrderDetails : Form
    {
        private OrderDetailsService orderDetailsService;
        private int id;
        public frmOrderDetails(int ids)
        {
            InitializeComponent();
            this.id = ids;
            this.orderDetailsService = new OrderDetailsService();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            var pro = orderDetailsService.loadOrderDetails(this.id);
            dgvorderDetails.DataSource = pro;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

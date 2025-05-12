using BusinessLayer.Services;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FrmMain: Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //Method to add Controls in Main form

        public void AddControls(Form f)
        {
            pnlCenter.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            pnlCenter.Controls.Add(f);
            f.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = AccountService.USER;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void BtnTables_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            AddControls(new frmReservationView());
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            AddControls(new frmCustomerView());
        }

        private void BtnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
        }

        private void BtnPromotion_Click(object sender, EventArgs e)
        {
            AddControls(new frmPromotionView());
        }
    }
}

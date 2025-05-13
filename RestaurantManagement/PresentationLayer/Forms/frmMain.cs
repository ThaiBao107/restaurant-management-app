using BusinessLayer.DTOs;
using BusinessLayer.Services;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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

            var role = AccountService.ROLE;

            // Ẩn toàn bộ nút trước
            btnPromotion.Visible = false;
            btnStaff.Visible = false;
            btnTables.Visible = false;
            btnCategories.Visible = false;
            btnProducts.Visible = false;
            btnReservation.Visible = false;
            btnPOS.Visible = false;
            btnCustomer.Visible = false;
            btnAccount.Visible = false;


            // Hiện nút theo quyền
            if (role == StaffRoleDTO.Manager)
            {
                btnPromotion.Visible = true;
                btnStaff.Visible = true;
                btnTables.Visible = true;
                btnCategories.Visible = true;
                btnProducts.Visible = true;
                btnReservation.Visible = true;
                btnPOS.Visible = true;
                btnCustomer.Visible = true;
                btnAccount.Visible = true;
            }
            else if (role == StaffRoleDTO.Cashier)
            {
                btnReservation.Visible = true;
                btnPOS.Visible = true;
                btnCustomer.Visible = true;
                btnTables.Visible = true;
            }
            else if (role == StaffRoleDTO.Waiter)
            {
                btnPOS.Visible = true;
            }
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

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            AddControls(new frmAccontView());
        }
    }
}

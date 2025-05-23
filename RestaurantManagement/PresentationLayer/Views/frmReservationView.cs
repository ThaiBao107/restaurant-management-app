﻿using BusinessLayer.Services;
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
    public partial class frmReservationView : Form
    {
        private ReservationService reservationService;
        private CustomerService customerService;
        public frmReservationView()
        {
            InitializeComponent();
            reservationService = new ReservationService();
            customerService = new CustomerService();
            dgvReservation.RowPostPaint += dgvReservation_RowPostPaint;
        }

        private void LoadData()
        {
            dgvReservation.DataSource = reservationService.joinPhoneAndNameIntoReservation();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmReservationAdd frm = new frmReservationAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
                LoadData();
        }

        private void frmReservationView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReservation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvReservation.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }




        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservation.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmReservationAdd frm = new frmReservationAdd();

                // Truyền id để check xem là edit hay delete
                frm.id = Convert.ToInt32(dgvReservation.CurrentRow.Cells["ReservationID"].Value);
                frm.txtCustomerID.Text = Convert.ToString(dgvReservation.CurrentRow.Cells["CustomerID"].Value);
                frm.txtGuest.Text = Convert.ToString(dgvReservation.CurrentRow.Cells["NumberOfGuests"].Value);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvReservation.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int reservationId = Convert.ToInt32(dgvReservation.CurrentRow.Cells["ReservationID"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa bàn đặt {reservationId}?", "Xóa bàn đặt", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    reservationService.DeleteReservation(reservationId);
                    LoadData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReservation.DataSource = reservationService.SearchReservationsByName(txtSearch.Text.Trim());
        }
    }
}

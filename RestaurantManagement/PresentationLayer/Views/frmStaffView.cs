using BusinessLayer.Services;
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
    public partial class frmStaffView: Form
    {
        private StaffService staffService;
        public frmStaffView()
        {
            InitializeComponent();
            staffService = new StaffService();
        }

        private void LoadData()
        {
            dgvStaff.RowPostPaint += dgvStaff_RowPostPaint;
            dgvStaff.DataSource = staffService.GetStaffs();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvStaff_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvStaff.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStaff.DataSource = staffService.SearchStaffsByName(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm = new frmStaffAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmStaffAdd frm = new frmStaffAdd();
                frm.id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["dgvId"].Value);
                frm.txtFirstName.Text = Convert.ToString(dgvStaff.CurrentRow.Cells["FirstName"].Value);
                frm.txtLastName.Text = Convert.ToString(dgvStaff.CurrentRow.Cells["LastName"].Value);
                frm.txtPhone.Text = Convert.ToString(dgvStaff.CurrentRow.Cells["Phone"].Value);
                frm.txtEmail.Text = Convert.ToString(dgvStaff.CurrentRow.Cells["Email"].Value);
                frm.txtSalary.Text = Convert.ToString(dgvStaff.CurrentRow.Cells["Salary"].Value);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvStaff.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int staffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells["dgvId"].Value);
                string firstName = Convert.ToString(dgvStaff.CurrentRow.Cells["FirstName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa nhân viên {firstName}?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    staffService.DeleteStaff(staffId);
                    LoadData();
                }
            }
        }
    }
}

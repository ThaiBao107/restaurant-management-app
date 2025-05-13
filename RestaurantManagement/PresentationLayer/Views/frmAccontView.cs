using BusinessLayer.DTOs;
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
    public partial class frmAccontView: Form
    {
        private AccountService accountService;
        private StaffService staffService;

        public frmAccontView()
        {
            InitializeComponent();
            accountService = new AccountService();
            staffService = new StaffService();
        }

        private void LoadData()
        {
            List<AccountDTO> accounts = accountService.GetAccounts();

            DataTable table = new DataTable();
            table.Columns.Add("AccountID", typeof(int));
            table.Columns.Add("StaffID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("StaffName", typeof(string));

            foreach (var a in accounts)
            {
                table.Rows.Add(
                   a.AccountID,
                   a.StaffID,
                   a.Username,
                   a.Password,
                    staffService.getStaffNameByID(a.StaffID)
                );
            }

            dgvAccount.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccountAdd frm = new frmAccountAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void frmAccontView_Load(object sender, EventArgs e)
        {
            dgvAccount.RowPostPaint += dgvAccount_RowPostPaint;
            LoadData();
        }

        private void dgvAccount_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvAccount.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmAccountAdd frm = new frmAccountAdd();
                frm.id = Convert.ToInt32(dgvAccount.CurrentRow.Cells["dgvId"].Value);
                frm.txtUsername.Text = Convert.ToString(dgvAccount.CurrentRow.Cells["Username"].Value);
                frm.txtStaffID.Text = Convert.ToString(dgvAccount.CurrentRow.Cells["dgvName"].Value);
                frm.txtUsername.Enabled = false;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvAccount.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int accountId = Convert.ToInt32(dgvAccount.CurrentRow.Cells["dgvId"].Value);
                string staffName = Convert.ToString(dgvAccount.CurrentRow.Cells["StaffName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa tài khoản nhân viên {staffName}?", "Xóa tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    accountService.DeleteAccount(accountId);
                    LoadData();
                }
            }
        }
    }
}

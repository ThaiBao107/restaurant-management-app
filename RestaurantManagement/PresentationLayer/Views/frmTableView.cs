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
    public partial class frmTableView: Form
    {
        private TableService tableService;
        public frmTableView()
        {
            InitializeComponent();
            tableService = new TableService();
        }

        private void LoadData()
        {
            dgvTable.RowPostPaint += dgvCategory_RowPostPaint;
            dgvTable.DataSource = tableService.GetTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTable.DataSource = tableService.SearchTablesByNumber(txtSearch.Text.Trim());
        }

        private void frmTableView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvTable.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmTableAdd frm = new frmTableAdd();
                frm.id = Convert.ToInt32(dgvTable.CurrentRow.Cells["dgvId"].Value);
                frm.txtNumber.Text = Convert.ToString(dgvTable.CurrentRow.Cells["dgvName"].Value);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvTable.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int tableId = Convert.ToInt32(dgvTable.CurrentRow.Cells["dgvId"].Value);
                string tableName = Convert.ToString(dgvTable.CurrentRow.Cells["dgvName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa bàn {tableName}?", "Xóa bàn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    tableService.DeleteTable(tableId);
                    LoadData();
                }
            }
        }
    }
}

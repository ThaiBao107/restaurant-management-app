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
    public partial class frmCategoryView: Form
    {
        private CategoryService categoryService;
        public frmCategoryView()
        {
            InitializeComponent();
            categoryService = new CategoryService();
        }

        private void LoadData()
        {
            dgvCategory.RowPostPaint += dgvCategory_RowPostPaint;
            dgvCategory.DataSource = categoryService.GetCategories();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategory.DataSource = categoryService.SearchCategoriesByName(txtSearch.Text.Trim());
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCategory.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgvCategory.CurrentRow.Cells["dgvName"].Value);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvCategory.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int categoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["dgvId"].Value);
                string categoryName = Convert.ToString(dgvCategory.CurrentRow.Cells["dgvName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa danh mục {categoryName}?", "Xóa danh mục", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    categoryService.DeleteCategory(categoryId);
                    LoadData();
                }
            }
        }

        private void dgvCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCategory.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}

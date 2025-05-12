using BusinessLayer.DTOs;
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
    public partial class frmProductView: Form
    {
        private ProductService productService;
        private CategoryService categoryService;

        public frmProductView()
        {
            InitializeComponent();
            productService = new ProductService();
            categoryService = new CategoryService();
        }

        private void LoadData()
        {
            dgvProduct.RowPostPaint += dgvProduct_RowPostPaint;

            List<ProductDTO> products = productService.GetProducts();

            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("IsAvailable", typeof(bool));
            table.Columns.Add("Image", typeof(string));
            table.Columns.Add("CategoryID", typeof(int));
            table.Columns.Add("CategoryName", typeof(string)); 

            foreach (var p in products)
            {
                table.Rows.Add(
                    p.ProductID,
                    p.ProductName,
                    p.Price,
                    p.Description,
                    p.IsAvailable,
                    p.Image,
                    p.CategoryID,
                    categoryService.GetCategoryNameByID(p.CategoryID)
                );
            }

            dgvProduct.DataSource = table;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productService.SearchProductsByName(txtSearch.Text.Trim());
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               if(dgvProduct.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(dgvProduct.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgvProduct.CurrentRow.Cells["ProductName"].Value);
                frm.txtPrice.Text = Convert.ToString(dgvProduct.CurrentRow.Cells["Price"].Value);
                frm.SetDescription(Convert.ToString(dgvProduct.CurrentRow.Cells["Description"].Value),
                    Convert.ToBoolean(dgvProduct.CurrentRow.Cells["IsAvailable"].Value),
                    Convert.ToString(dgvProduct.CurrentRow.Cells["Image"].Value),
                    Convert.ToInt32(dgvProduct.CurrentRow.Cells["CategoryID"].Value));
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvProduct.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int productId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["dgvId"].Value);
                string productName = Convert.ToString(dgvProduct.CurrentRow.Cells["ProductName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa sản phẩm {productName}?", "Xóa danh mục", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    productService.DeleteProduct(productId);
                    LoadData();
                }
            }
        }

        private void dgvProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvProduct.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}

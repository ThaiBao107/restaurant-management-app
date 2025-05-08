using BusinessLayer.DTOs;
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
    public partial class frmCategoryAdd: Form
    {
        private CategoryService categoryService;
        public frmCategoryAdd()
        {
            InitializeComponent();
            categoryService = new CategoryService();
        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            if (id == 0)
            {
                CategoryDTO categoryDTO = new CategoryDTO { CategoryName = txtName.Text };
                if (categoryService.AddCategory(categoryDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Dang mục đã tồn tại!");
                    txtName.Clear();
                }
            }
            else
            {
                CategoryDTO categoryDTO = new CategoryDTO {CategoryID = id ,CategoryName = txtName.Text };
                if (categoryService.UpdateCategory(categoryDTO))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Trùng tên danh mục!");
                    txtName.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.DTOs;

namespace PresentationLayer.Forms
{
    public partial class frmCategories_CategoryAdd : frmCategories_SampleAdd
    {
        private readonly CategoryService _categoryService;
        private frmCategories_CategoryView frmCategories_CategoryView;
        public frmCategories_CategoryAdd(frmCategories_CategoryView _frmCategories_CategoryView)
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            frmCategories_CategoryView = _frmCategories_CategoryView;
        }

        private void frmCategories_CategoryAdd_Load(object sender, EventArgs e)
        {

        }
        public override void btn_Categories_Save_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ text box
            string categoryName = txt_NameCategory.Text.Trim();
            string categoryDescription = txt__Category_Description.Text.Trim();

            // Tạo đối tượng CategoryDTO thuộc lớp Business để khi gọi phương thức add lớp Business có thể làm việc với lớp Data
            var newCategory = new CategoryDTO
            {
                CategoryName = categoryName,
                Description = categoryDescription,
            };

            
            // Gọi phương thức add của Category ở lớp Business
            var addCategory = _categoryService.AddCategory(newCategory);

            // Nếu thêm thành công ở lớp Business
            if (addCategory)
            {
                MessageBox.Show("Sửa thành công!");
                frmCategories_CategoryView.loadData();
            }
            else
                MessageBox.Show("Xảy ra lỗi!");

        }

        public override void btn_Categories_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

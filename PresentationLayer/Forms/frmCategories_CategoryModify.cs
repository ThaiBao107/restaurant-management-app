using BusinessLayer.DTOs;
using BusinessLayer.Services;
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
    public partial class frmCategories_CategoryModify : frmCategories_SampleAdd
    {
        private readonly CategoryService _categoryService;
        private frmCategories_CategoryView frmCategories_CategoryView;
        public frmCategories_CategoryModify(frmCategories_CategoryView _frmCategories_CategoryView)
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            frmCategories_CategoryView = _frmCategories_CategoryView;
        }

        private void frmCategories_CategoryDelete_Load(object sender, EventArgs e)
        {

        }

        public override void btn_Categories_Save_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ text box
            string categoryName = txt_NameCategory.Text.Trim();
            string categoryDescription = txt__Category_Description.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                txt_NameCategory.Focus();
                return;
            }

            // Nếu đã tồn tại tên category trong database
            var existing = _categoryService.GetAllCategories()
                    .Any(c => c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (existing)
            {
                MessageBox.Show("Tên danh mục đã tồn tại.");
                return;
            }

            // Tạo đối tượng CategoryDTO thuộc lớp Business để khi gọi phương thức add lớp Business có thể làm việc với lớp Data
            var newCategory = new CategoryDTO
            {
                CategoryName = categoryName,
                Description = categoryDescription,
            };


            // Gọi phương thức add của Category ở lớp Business
            var updateCategory = _categoryService.UpdateCategory(newCategory);

            // Nếu thêm thành công ở lớp Business
            if (updateCategory)
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
    }
}

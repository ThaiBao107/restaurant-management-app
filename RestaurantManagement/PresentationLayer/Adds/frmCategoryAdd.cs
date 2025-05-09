using BusinessLayer.DTOs;
using BusinessLayer.Services;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (id == 0)
            {
                CategoryDTO categoryDTO = new CategoryDTO { CategoryName = txtName.Text,
                Image = filePath};
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

        string filePath;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Tạo thư mục Images trong thư mục dự án (nếu chưa có)
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                // Copy ảnh được chọn vào thư mục Images
                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(imagesFolder, fileName);
                File.Copy(ofd.FileName, destPath, true);

                // Gán ảnh cho PictureBox
                txtImage.Image = new Bitmap(destPath);

                // Lưu đường dẫn tương đối vào filePath
                filePath = Path.Combine("Images", fileName);
            }
        }
    }
}

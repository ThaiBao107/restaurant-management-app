using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class frmProductAdd: Form
    {
        private CategoryService categoryService;
        private ProductService productService;
        public frmProductAdd()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            productService = new ProductService();
        }


        public void SetDescription(string description, bool status, string image, int catId)
        {
            rtbDescription.Text = description;
            tgStatus.Checked = status;
            txtImage.Image = Image.FromFile(image);
            filePath = image;
            cbCategoryId.SelectedValue = catId;
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

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            cbCategoryId.DataSource = categoryService.GetCategories();
            cbCategoryId.DisplayMember = "CategoryName";
            cbCategoryId.ValueMember = "CategoryID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                if (txtImage.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh!", "Thiếu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    var product = new ProductDTO
                    {
                        ProductName = txtName.Text.Trim(),
                        Price = double.Parse(txtPrice.Text.Trim()),
                        IsAvailable = tgStatus.Checked,
                        CategoryID = Convert.ToInt32(cbCategoryId.SelectedValue),
                        Description = rtbDescription.Text.Trim(),
                        Image = filePath
                    };

                    bool result = productService.AddProduct(product);

                    if (result)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtImage.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh!", "Thiếu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    var product = new ProductDTO
                    {
                        ProductID = id,
                        ProductName = txtName.Text.Trim(),
                        Price = double.Parse(txtPrice.Text.Trim()),
                        IsAvailable = tgStatus.Checked,
                        CategoryID = Convert.ToInt32(cbCategoryId.SelectedValue),
                        Description = rtbDescription.Text.Trim(),
                        Image = filePath
                    };

                    bool result = productService.UpdateProduct(product);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

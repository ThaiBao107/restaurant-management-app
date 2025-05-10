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
using System.Xml.Linq;

namespace PresentationLayer.Adds
{
    public partial class frmPromotionAdd : Form
    {
        private PromotionService promotionService;
        public frmPromotionAdd()
        {
            InitializeComponent();
            promotionService = new PromotionService();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPromotionAdd_Load(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int id = 0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                try
                {
                    string name = txtPromotionName.Text.Trim();
                    string description = txtDes.Text.Trim();
                    double discount = Convert.ToDouble(nmrPromotionPercentage.Value);
                    DateTime startDate = dateStart.Value;
                    DateTime endDate = dateEnd.Value;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Tên mã giảm giá không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (name.Length > 100)
                    {
                        MessageBox.Show("Tên mã giảm giá không được vượt quá 100 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (discount < 0 || discount > 100)
                    {
                        MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (startDate >= endDate)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    PromotionDTO promotion = new PromotionDTO
                    {
                        PromotionName = name,
                        Description = description,
                        DiscountPercentage = discount,
                        StartDate = startDate,
                        EndDate = endDate,
                        IsActive = guna2ToggleSwitch1.Checked
                    };

                    bool result = promotionService.AddPromotion(promotion);

                    if (result)
                    {
                        MessageBox.Show("Thêm mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mã giảm giá thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Mã giảm giá không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var promotion = new PromotionDTO
                    {
                        PromotionID = id,
                        PromotionName = txtPromotionName.Text.Trim(),
                        Description = txtDes.Text.Trim(),
                        DiscountPercentage = Convert.ToDouble(nmrPromotionPercentage.Value),
                        StartDate = dateStart.Value,
                        EndDate = dateEnd.Value,
                        IsActive = guna2ToggleSwitch1.Checked
                    };

                    bool result = promotionService.UpdatePromotion(promotion);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mã giảm giá thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Mã giảm giá không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

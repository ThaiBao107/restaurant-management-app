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
    public partial class frmPromotionView : Form
    {
        private PromotionService promotionService;
        public frmPromotionView()
        {
            InitializeComponent();
            promotionService = new PromotionService();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPromotion.DataSource = promotionService.SearchPromotionByName(txtSearch.Text.Trim());

        }

        public void LoadData ()
        {
            dgvPromotion.DataSource = promotionService.GetPromotion();
            dgvPromotion.RowPostPaint += dgvPromotion_RowPostPaint;
        }

        private void frmPromotionView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPromotionAdd frm = new frmPromotionAdd();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvPromotion_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPromotion.Rows[e.RowIndex].Cells["dgvSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPromotion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPromotion.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmPromotionAdd frm = new frmPromotionAdd();

                // Truyền id để check xem là edit hay delete
                frm.id = Convert.ToInt32(dgvPromotion.CurrentRow.Cells["PromotionID"].Value);
                frm.txtPromotionName.Text = Convert.ToString(dgvPromotion.CurrentRow.Cells["PromotionName"].Value);
                frm.txtDes.Text = Convert.ToString(dgvPromotion.CurrentRow.Cells["Description"].Value);
                frm.nmrPromotionPercentage.Value = Convert.ToDecimal(dgvPromotion.CurrentRow.Cells["DiscountPercentage"].Value);
                frm.dateStart.Value = Convert.ToDateTime(dgvPromotion.CurrentRow.Cells["StartDate"].Value);
                frm.dateEnd.Value = Convert.ToDateTime(dgvPromotion.CurrentRow.Cells["EndDate"].Value);
                frm.guna2ToggleSwitch1.Checked = Convert.ToBoolean(dgvPromotion.CurrentRow.Cells["isActive"].Value);

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
            }
            if (dgvPromotion.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int promotionId = Convert.ToInt32(dgvPromotion.CurrentRow.Cells["PromotionID"].Value);
                string promotionName = Convert.ToString(dgvPromotion.CurrentRow.Cells["PromotionName"].Value);
                DialogResult result = MessageBox.Show($"Bạn đồng ý xóa mã giảm giá {promotionName}?", "Xóa danh mục", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    promotionService.DeletePromotion(promotionId);
                    LoadData();
                }
            }
        }
    }
}

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
    public partial class frmTableAdd: Form
    {
        private TableService tableService;
        public frmTableAdd()
        {
            InitializeComponent();
            tableService = new TableService();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                TableDTO tableDTO = new TableDTO { TableNumber = txtNumber.Text };
                if (tableService.AddTable(tableDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Bàn đã tồn tại!");
                    txtNumber.Clear();
                }
            }
            else
            {
                TableDTO tableDTO = new TableDTO { TableID = id, TableNumber = txtNumber.Text };
                if (tableService.UpdateTable(tableDTO))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Trùng tên bàn!");
                    txtNumber.Clear();
                }
            }
        }
    }
}

using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer.Adds
{
    public partial class frmAccountAdd: Form
    {
        private AccountService accountService;
        public frmAccountAdd()
        {
            InitializeComponent();
            accountService = new AccountService();
        }


        public int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
                return;
            }

            try
            {
                if (id == 0)
                {
                    AccountDTO accountDTO = new AccountDTO { StaffID = Convert.ToInt32(txtStaffID.Text), Username = txtUsername.Text, Password = txtPassword.Text};
                    if (accountService.AddAccount(accountDTO))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Username is used");
                        txtUsername.Clear();
                    }
                }
                else
                {
                    AccountDTO accountDTO = new AccountDTO {AccountID=id, StaffID = Convert.ToInt32(txtStaffID.Text), Username = txtUsername.Text, Password = txtPassword.Text };
                    if (accountService.UpdateAccount(accountDTO))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

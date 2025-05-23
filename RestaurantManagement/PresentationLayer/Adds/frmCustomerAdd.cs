﻿using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PresentationLayer.Adds
{
    public partial class frmCustomerAdd : Form
    {
        private CustomerService customerService;
        public frmCustomerAdd()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        public int id = 0;
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtFirstName.Text.Trim()) || string.IsNullOrWhiteSpace(txtLastName.Text.Trim()))
                    {
                        MessageBox.Show("Nhập đầy đủ họ tên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtPhone.Text.Trim()))
                    {
                        MessageBox.Show("Nhập số điện thoại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtPhone.Text.Trim()))
                    {
                        MessageBox.Show("Nhập email", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string address = txtAddress.Text.Trim();


                    if (string.IsNullOrWhiteSpace(address))
                    {
                        address = "";
                    }


                    CustomerDTO customer = new CustomerDTO
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = address
                    };

                    

                    bool result = customerService.AddCustomer(customer);

                    if (result)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                    string address = txtAddress.Text.Trim();


                    if (string.IsNullOrWhiteSpace(address))
                    {
                        address = "";
                    }

                    CustomerDTO customer = new CustomerDTO
                    {
                        CustomerID = id,
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = address
                    };

                    bool result = customerService.UpdateCustomer(customer);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

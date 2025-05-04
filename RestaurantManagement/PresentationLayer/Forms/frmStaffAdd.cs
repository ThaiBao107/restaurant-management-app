using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class frmStaffAdd: Form
    {
        private StaffService staffService;
        public frmStaffAdd()
        {
            InitializeComponent();
            staffService = new StaffService();
        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    if (cbSex.SelectedItem == null || cbRole.SelectedItem == null || cbShift.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ giới tính, vai trò và ca làm.");
                        return;
                    }

                    StaffDTO staffDTO = new StaffDTO
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Sex = (SexDTO)cbSex.SelectedItem,
                        Role = (StaffRoleDTO)cbRole.SelectedItem,
                        Shift = (ShiftDTO)cbShift.SelectedItem,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        Salary = Double.Parse(txtSalary.Text)
                    };
                    if (staffService.AddStaff(staffDTO))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã tồn tại!");
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtEmail.Clear();
                        txtSalary.Clear();
                        txtPhone.Clear();
                        cbRole.SelectedIndex = -1;
                        cbSex.SelectedIndex = -1;
                        cbShift.SelectedIndex = -1;
                    }
                }
                else
                {
                    StaffDTO staffDTO = new StaffDTO
                    {
                        StaffID = id,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Sex = (SexDTO)cbSex.SelectedItem,
                        Role = (StaffRoleDTO)cbRole.SelectedItem,
                        Shift = (ShiftDTO)cbShift.SelectedItem,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        Salary = Double.Parse(txtSalary.Text)
                    };
                    if (staffService.UpdateStaff(staffDTO))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Trùng SDT!");
                        txtPhone.Clear();
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Với EF6 – hiển thị các lỗi validation chi tiết
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                string fullError = string.Join("\n", errorMessages);
                MessageBox.Show("Lỗi xác thực dữ liệu:\n" + fullError);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu vào database:\n" + ex.InnerException?.Message);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("Lỗi kiểm tra dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmStaffAdd_Load(object sender, EventArgs e)
        {
            cbSex.DataSource = Enum.GetValues(typeof(SexDTO));
            cbRole.DataSource = Enum.GetValues(typeof(StaffRoleDTO));
            cbShift.DataSource = Enum.GetValues(typeof(ShiftDTO));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BusinessLayer.DTOs;


namespace PresentationLayer.Forms
{
    public partial class frmCreateOrder : Form
    {
        private AddOrders AddOrders;
        private CustomerService customerService;
        private StaffService staffService;
        string soBan;
        string soTien;
        int idBan;
        int staffID = 0;
        List<OrderDetailDTO> ods;
        public frmCreateOrder(string soBan, string soTien, int inBAN, List<OrderDetailDTO> od)
        {
            InitializeComponent();
            this.soBan = soBan;
            this.soTien = soTien;
            this.customerService = new CustomerService();   
            this.staffService =   new StaffService();
            if(soBan == "0")
                this.idBan = 9;
            else
                this.idBan = inBAN;
            this.AddOrders = new AddOrders();
            this.ods = od;
        }

        private void frmTaoDH_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = this.soTien;
            lbBanSo.Text = this.soBan;
            txtNgayTao.Text = DateTime.Now.ToString();
            var staffs = staffService.GetStaffs();
            foreach (var staff in staffs)
            {
                comboBoxNV.Items.Add(staff.StaffID);
            }

        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
        }

        

        private void btnTim_Click(object sender, EventArgs e)
        {
            CustomerDTO result = customerService.CheckCustomerByPhone(txtSDT.Text.ToString());
            if(result == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
            else
            {
                MessageBox.Show("Tìm thấy khách hàng");
                txtMAKH.Text = result.FirstName;
            }
        }

        private void comboBoxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            this.staffID = int.Parse(comboBoxNV.SelectedItem.ToString());
        }

      

        private void radioTTTienMat_CheckedChanged(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Clear();
            System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
            textBox1.Size = new Size(140, 100);  
            textBox1.Location = new Point(120,10);
            textBox1.Name = "txtTienKhach" ;
            textBox1.TextChanged += new EventHandler(txtTienKhach_TextChanged);

            System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
            textBox2.Size = new Size(140, 100);
            textBox2.Location = new Point(120, 40);
            textBox2.Name = "txtTienThoi";
            

            System.Windows.Forms.Label lbtextbox1 = new System.Windows.Forms.Label();
            lbtextbox1.Location = new Point(8, 8);
            lbtextbox1.Text = "Tiền nhận:";
            lbtextbox1.Font = new Font("Arial", 9, FontStyle.Bold);
            System.Windows.Forms.Label lbtextbox2 = new System.Windows.Forms.Label();
            lbtextbox2.Location = new Point(8, 40);
            lbtextbox2.Text = "Tiền thối:";
            lbtextbox2.Font = new Font("Arial", 9, FontStyle.Bold);
            pnlThanhToan.Controls.Add(lbtextbox2);
            pnlThanhToan.Controls.Add(lbtextbox1);

            pnlThanhToan.Controls.Add(textBox1);
            pnlThanhToan.Controls.Add(textBox2 );

        }

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            double tongtien = double.Parse(txtTongTien.Text.ToString().Replace(" ", "").Replace("VND", ""));
            
            System.Windows.Forms.TextBox txttienkhach = (System.Windows.Forms.TextBox)sender;

            if (!double.TryParse(txttienkhach.Text, out double tienkhach))
            {
                
                if (pnlThanhToan.Controls["txtTienThoi"] is System.Windows.Forms.TextBox txtTienThoiInvalid)
                    txtTienThoiInvalid.Text = "";
                return;
            }

            string tienthoi = (double.Parse(txttienkhach.Text) - tongtien).ToString();
            if (pnlThanhToan.Controls["txtTienThoi"] is System.Windows.Forms.TextBox txtTienThoi)
            {
                txtTienThoi.Text = tienthoi + " VND"; 
            }

        }

        private void radioTTVNPAY_CheckedChanged(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Clear();
            System.Windows.Forms.Button btnThanhToan = new System.Windows.Forms.Button();
            btnThanhToan.Text = "Thanh toán VNPAY";
            btnThanhToan.Size = new Size(120, 40);
            int x = (pnlThanhToan.Width - btnThanhToan.Width) / 2;
            int y = (pnlThanhToan.Height - btnThanhToan.Height) / 2;
            btnThanhToan.Location = new Point(x, y);

            RadioButton radioTick = new RadioButton();
            radioTick.Text = "Đã thanh toán thành công";
            radioTick.Name = "radioThanhToanTC";
            radioTick.Location = new Point(x, 65);
            
            btnThanhToan.Click += BtnThanhToan_Click;
            pnlThanhToan.Controls.Add(btnThanhToan);
            pnlThanhToan.Controls.Add(radioTick);
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn nút Thanh toán!");
        }

        




        private void btnTaoDH_Click(object sender, EventArgs e)
        {
            string maKH = txtMAKH.Text.ToString();
            if (maKH == "x") maKH = "3"; 
            int idB = this.idBan;
            int staffid = this.staffID; 
            DateTime orderdate = DateTime.Now;
            float TotalAmount = int.Parse(this.soTien.Replace(" ","").Replace("VND",""));
            int orderstatus = 1;
            
            if(txtMAKH.Text.ToString() == "" || lbBanSo.Text.ToString() == "" )
            {
                MessageBox.Show("Them day du thong tin");
            }
            else
            {
                if (AddOrders.checkOrder(int.Parse(maKH), idB, staffid, orderdate, orderstatus, TotalAmount, this.ods))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            


        }


    }
}

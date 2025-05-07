using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using BusinessLayer.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace PresentationLayer.Forms
{
    public partial class frmTaoDH : Form
    {
        private LoadCustomers loadCustomers;
        private LoadStaffs loadStaffs;
        string soBan;
        string soTien;
        public frmTaoDH(string soBan, string soTien)
        {
            InitializeComponent();
            this.soBan = soBan;
            this.soTien = soTien;
            this.loadCustomers = new LoadCustomers();   
            this.loadStaffs =   new LoadStaffs();
        }

        private void frmTaoDH_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = this.soTien;
            lbBanSo.Text = this.soBan;
            txtNgayTao.Text = DateTime.Now.ToString();
            var staffs = loadStaffs.getStaffs();
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
            string result = loadCustomers.checkPhone(txtSDT.Text.ToString());
            if(result.Equals("-1"))
            {
                MessageBox.Show("Khong tim thay khach hang");
            }
            else
            {
                MessageBox.Show("Tim thay khach hang");
                txtMAKH.Text = result;
            }
        }

        private void comboBoxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        }
    }
}

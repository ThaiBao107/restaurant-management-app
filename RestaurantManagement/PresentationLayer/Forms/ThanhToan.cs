using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTOs;
using BusinessLayer.Services;
using Guna.UI2.WinForms;
using PresentationLayer.View;
using BusinessLayer.DTOs;
using System.IO;
namespace PresentationLayer.Forms
{
    public partial class ThanhToan : Form
    {
        private LoadProducts loadProducts;
        private int idBan;
        public ThanhToan()
        {
            InitializeComponent();
            this.loadProducts = new LoadProducts();
        }

        private void monpizzabtn_Click(object sender, EventArgs e)
        {

        }

        private double tongTien()
        {
            double k = 0;
            
          
            for (int i = 0; i < dgvTotal.Rows.Count; i++)
            {
                
                DataGridViewRow row = dgvTotal.Rows[i];

                
                if (row.Cells["dgvrTotal"].Value != null)
                {
                    k += double.Parse(row.Cells["dgvrTotal"].Value.ToString());
                }
            }
            
            return k;
        }
        private void reloadThanhTien()
        {
            double total = tongTien();
            lbTongTien.Text = "";
            lbThue.Text = "";
            lbThanhTien.Text = "";
            lbTongTien.Text += $"{total} VND";
            lbThue.Text += $"{total * 0.1} VND";
            lbThanhTien.Text += $"{total + (total * 0.1)} VND";
        }
        
        private void AddItems(int id, string name, double price, Image image)
        {
            var k = new ucProduct()
            {
                id = id,
                price = price.ToString(),
                Pname = name,
                PImage = image
            };
            
            Productpnl.Controls.Add(k);
            k.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in dgvTotal.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvrId"].Value) == id)
                    {
                        item.Cells["dgvrSL"].Value = int.Parse(item.Cells["dgvrSL"].Value.ToString()) + 1;
                        item.Cells["dgvrTotal"].Value = int.Parse(item.Cells["dgvrSL"].Value.ToString()) *
                        double.Parse(item.Cells["dgvrPrice"].Value.ToString());
                        reloadThanhTien();
                        return ;
                    }

                }
                
                dgvTotal.Rows.Add(new object[] { wdg.id, wdg.Pname, 1, wdg.price, double.Parse(wdg.price) });
                reloadThanhTien();

            };
            
        }


        private void LoadProducts(string fouder, int categoriesID)
        {
            
            var dt = loadProducts.getAllCategories(categoriesID);
            foreach(var i in dt)
            {
                string pathImage = $"D:\\LTCSDL\\restaurant-management-app\\RestaurantManagement" +
                    $"\\PresentationLayer\\Resources\\{fouder}\\{i.Description}.jpg";
                Image img = null;
                img = Image.FromFile(pathImage);
                
                AddItems(Convert.ToInt32(i.id), i.productName.ToString(),
                    double.Parse(i.price.ToString()), img);
            }
            
        }



        private Guna2DataGridView CustomDataGridView(Guna2DataGridView dgv)
        {
            dgv.Rows.Clear();
            var path = Directory.GetParent(Application.StartupPath).FullName;
            DataGridViewImageColumn imageColum = new DataGridViewImageColumn();
            imageColum.Image = Image.FromFile(path + "\\Image\\thungrac.png");
            imageColum.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgv.Columns.Add(imageColum);

            return dgv;
        }





        private void ThanhToan_Load(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("All", -1);
            dgvTotal = CustomDataGridView(dgvTotal);
        }

        private void billListbtn_Click(object sender, EventArgs e)
        {

        }

       

        private void nuocbtn_Click(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("Nuoc", 1);
            
        }

        private void supbtn_Click(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("sup", 3);
        }

        private void pizzabtn_Click(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("pizza", 4);
        }

        private void banhngotbtn_Click(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("banhngot", 2);
        }

        private void allbtn_Click(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("All", -1);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in Productpnl.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.Pname.ToLower().Contains(txtSearchProduct.Text.Trim().ToLower());
            }
        }

        private void tablebtn_Click(object sender, EventArgs e)
        {
            frmTable_ThanhToan f = new frmTable_ThanhToan(this);
            f.Show();
            f.FormBorderStyle = FormBorderStyle.None;
        }

        public void UpdateLabel(String text, int flag, int idBan)
        {
            if (flag == 1)
            {
                lbHinhThuc.Text = "Ăn tại quán";
                lbBanSo.Visible = true;
                lbBanSo.Text = text;
                this.idBan = idBan;

            }
            else
            {
                lbHinhThuc.Text = "Mua mang về";
                lbBanSo.Visible = false;
            }
            
            
        }

        private void takeawaybtn_Click(object sender, EventArgs e)
        {
            UpdateLabel("", 2, -1);
        }




        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            if(dgvTotal.Rows.Count > 0 && lbHinhThuc.Text.ToString() != "")
            {
                List<OrderDetailDTO> list = new List<OrderDetailDTO>();
                for (int i = 0; i < dgvTotal.Rows.Count; i++)
                {
                    
                    int id = 0;
                    string name = "";
                    int quantity = 0;
                    decimal amount = 0;
                    DataGridViewRow dr = dgvTotal.Rows[i];
                    if (dr.IsNewRow || dr.Cells["dgvrId"].Value == null)
                        continue;
                    id = int.Parse(dr.Cells["dgvrId"].Value.ToString());
                    name = dr.Cells["dgvrName"].Value.ToString();
                    quantity = int.Parse(dr.Cells["dgvrSL"].Value.ToString());
                    amount = (decimal)double.Parse(dr.Cells["dgvrTotal"].Value.ToString());
                    
                    OrderDetailDTO od = new OrderDetailDTO(id, quantity, amount);
                    list.Add(od);
                }
                frmTaoDH form = new frmTaoDH(lbBanSo.Text.ToString(), lbThanhTien.Text.ToString(), idBan, list);
                DialogResult result = form.ShowDialog();
                this.Enabled = false;
                if (result == DialogResult.OK)
                {
                    this.Enabled = true;
                    MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvTotal.Rows.Clear();
                    lbHinhThuc.Text = "";
                    lbBanSo.Text = "0";
                    lbTongTien.Text = "0";  
                    lbThue.Text = "0";
                    lbThanhTien.Text = "0";

                }
                else if (result == DialogResult.Cancel)
                {
                    this.Enabled = true;
                    MessageBox.Show("Tạo đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        

        private void dgvTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvTotal.Columns[col] is DataGridViewImageColumn)
            {
                int rol = e.RowIndex;

                string id = dgvTotal.Rows[rol].Cells["dgvrId"].Value.ToString();
                foreach (DataGridViewRow row in dgvTotal.Rows)
                {
                    if(int.Parse(id) == int.Parse(row.Cells["dgvrId"].Value.ToString()))
                    {
                        dgvTotal.Rows.Remove(row);
                        break; 
                    }
                }
            }
            reloadThanhTien();
        }
    }
}

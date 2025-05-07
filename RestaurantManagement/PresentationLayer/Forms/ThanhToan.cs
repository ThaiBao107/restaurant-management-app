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
using BusinessLayer.Services;
using Guna.UI2.WinForms;
using PresentationLayer.View;

namespace PresentationLayer.Forms
{
    public partial class ThanhToan : Form
    {
        private LoadProducts loadProducts;

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


        
        
       

        

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            Productpnl.Controls.Clear();
            LoadProducts("All", -1);

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

        public void UpdateLabel(String text, int flag)
        {
            if (flag == 1)
            {
                lbHinhThuc.Text = "Ăn tại quán";
                lbBanSo.Visible = true;
                lbBanSo.Text = text;

            }
            else
            {
                lbHinhThuc.Text = "Mua mang về";
                lbBanSo.Visible = false;
            }
            
            
        }

        private void takeawaybtn_Click(object sender, EventArgs e)
        {
            UpdateLabel("", 2);
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            frmTaoDH form = new frmTaoDH(lbBanSo.Text.ToString(), lbThanhTien.Text.ToString());
            DialogResult result = form.ShowDialog();
            this.Enabled = false;
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                MessageBox.Show("Da tao don hang");
            }
            else if (result == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
        }
    }
}

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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
        
        private void addForms(Form form)
        {
            form.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        private void thanhtoanbtn_Click(object sender, EventArgs e)
        {
            addForms(new ThanhToan());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.View
{
    public partial class ucTable : UserControl
    {
        public event EventHandler onSelect = null;
        public ucTable()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public int id {  get; set; }
        public string TNumber
        {
            get { return lbNameTable.Text; }
            set { lbNameTable.Text = value; }
        }

        

        private void txtTable_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}

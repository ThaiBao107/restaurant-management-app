using PresentationLayer.View;
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
namespace PresentationLayer.Forms
{
    public partial class frmTable_ThanhToan : Form
    {
        private ThanhToan currentForm;
        private LoadTables loadTables;
        public frmTable_ThanhToan(ThanhToan currentForm)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            this.loadTables = new LoadTables();
        }

       

        private void AddItemTables(int id, string TNumber, int Capacity)
        {
            var k = new ucTable()
            {
                id = id,
                TNumber = TNumber
            };
            Tablepnl.Controls.Add(k);
            k.onSelect += (ss, ee) =>
            {
                var wdg = (ucTable)ss;
                currentForm.UpdateLabel(wdg.TNumber, 1);
                this.Hide();
            };
        }
        private void LoadTables()
        {
            try
            {
                var tables = loadTables.GetTables();
                foreach ( var table in tables)
                {
                    AddItemTables(table.id, table.TNumber.ToString(), int.Parse(table.Capacity.ToString()));
                }
            }catch (Exception ex) {MessageBox.Show(ex.Message);}
        }




        
        private void Tablepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTable_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
    }
}

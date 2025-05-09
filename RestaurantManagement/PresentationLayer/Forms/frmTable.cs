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
    public partial class frmTable : Form
    {
        private frmPOS currentForm;
        private TableService tableService;

        public frmTable(frmPOS currentForm)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            this.tableService = new TableService();
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
                currentForm.UpdateLabel(wdg.TNumber, 1, wdg.id);
                this.Hide();
            };
        }
        private void LoadTables()
        {
            try
            {
                var tables = tableService.GetTables();
                foreach ( var table in tables)
                {
                    AddItemTables(table.TableID, table.TableNumber.ToString(), int.Parse(table.Capacity.ToString()));
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

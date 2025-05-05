using BusinessLayer.Services;
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
    public partial class frmCategories_CategoryView : frmCategories_SampleView
    {
        private readonly CategoryService _categoryService;
        public frmCategories_CategoryView()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
        }

        public void loadData ()
        {
            var listCategories = _categoryService.GetAllCategories();
            dgv_Categories.DataSource = listCategories;
        }

        private void frmCategories_CategoryView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public override void txt_Categories_Search_TextChanged(object sender, EventArgs e)
        {

        }

        public override void btn_Categories_Add_Click(object sender, EventArgs e)
        {
            frmCategories_CategoryAdd frmAdd = new frmCategories_CategoryAdd(this);
            frmAdd.ShowDialog();
        }

        private void dgv_Categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

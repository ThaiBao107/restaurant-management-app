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
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Method to add Controls in Main form

        public void AddControls(Form f)
        {
            pnlCenter.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            pnlCenter.Controls.Add(f);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = AccountService.USER;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }
    }
}

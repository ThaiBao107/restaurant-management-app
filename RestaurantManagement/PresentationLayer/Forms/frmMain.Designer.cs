namespace PresentationLayer.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlNavigation.Controls.Add(this.btnExit);
            this.pnlNavigation.Controls.Add(this.lblSettings);
            this.pnlNavigation.Controls.Add(this.lblReports);
            this.pnlNavigation.Controls.Add(this.lblKitchen);
            this.pnlNavigation.Controls.Add(this.lblPos);
            this.pnlNavigation.Controls.Add(this.lblStaff);
            this.pnlNavigation.Controls.Add(this.lblTables);
            this.pnlNavigation.Controls.Add(this.lblProducts);
            this.pnlNavigation.Controls.Add(this.lblCategories);
            this.pnlNavigation.Controls.Add(this.lblDashboard);
            this.pnlNavigation.Controls.Add(this.lblBrand);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 450);
            this.pnlNavigation.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBrand.ForeColor = System.Drawing.Color.Blue;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(200, 58);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "NONAME";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Blue;
            this.lblDashboard.Location = new System.Drawing.Point(52, 75);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(148, 36);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategories
            // 
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategories.ForeColor = System.Drawing.Color.Blue;
            this.lblCategories.Location = new System.Drawing.Point(52, 111);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(148, 35);
            this.lblCategories.TabIndex = 2;
            this.lblCategories.Text = "Categories";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProducts
            // 
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProducts.ForeColor = System.Drawing.Color.Blue;
            this.lblProducts.Location = new System.Drawing.Point(52, 146);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(148, 36);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Products";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTables
            // 
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTables.ForeColor = System.Drawing.Color.Blue;
            this.lblTables.Location = new System.Drawing.Point(52, 182);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(148, 37);
            this.lblTables.TabIndex = 4;
            this.lblTables.Text = "Tables";
            this.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaff
            // 
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaff.ForeColor = System.Drawing.Color.Blue;
            this.lblStaff.Location = new System.Drawing.Point(52, 219);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(148, 32);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "Staff";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPos
            // 
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPos.ForeColor = System.Drawing.Color.Blue;
            this.lblPos.Location = new System.Drawing.Point(52, 251);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(148, 33);
            this.lblPos.TabIndex = 6;
            this.lblPos.Text = "POS";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKitchen
            // 
            this.lblKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKitchen.ForeColor = System.Drawing.Color.Blue;
            this.lblKitchen.Location = new System.Drawing.Point(52, 284);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(148, 34);
            this.lblKitchen.TabIndex = 7;
            this.lblKitchen.Text = "Kitchen";
            this.lblKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReports
            // 
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblReports.ForeColor = System.Drawing.Color.Blue;
            this.lblReports.Location = new System.Drawing.Point(52, 318);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(148, 33);
            this.lblReports.TabIndex = 8;
            this.lblReports.Text = "Reports";
            this.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSettings.ForeColor = System.Drawing.Color.Blue;
            this.lblSettings.Location = new System.Drawing.Point(52, 351);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(148, 31);
            this.lblSettings.TabIndex = 9;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(0, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(600, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
    }
}
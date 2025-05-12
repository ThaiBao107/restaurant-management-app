namespace PresentationLayer.Adds
{
    partial class frmOrderDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.dgvorderDetails = new System.Windows.Forms.DataGridView();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 91);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Peru;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Transparent;
            this.lb1.Location = new System.Drawing.Point(321, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(169, 29);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Order Details";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvorderDetails
            // 
            this.dgvorderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.image,
            this.isavailable,
            this.categoriID});
            this.dgvorderDetails.Location = new System.Drawing.Point(0, 98);
            this.dgvorderDetails.Name = "dgvorderDetails";
            this.dgvorderDetails.RowHeadersWidth = 51;
            this.dgvorderDetails.RowTemplate.Height = 24;
            this.dgvorderDetails.Size = new System.Drawing.Size(796, 302);
            this.dgvorderDetails.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(740, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Visible = false;
            this.Description.Width = 125;
            // 
            // image
            // 
            this.image.DataPropertyName = "Image";
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.Visible = false;
            this.image.Width = 125;
            // 
            // isavailable
            // 
            this.isavailable.DataPropertyName = "IsAvailable";
            this.isavailable.HeaderText = "IsAvailable";
            this.isavailable.MinimumWidth = 6;
            this.isavailable.Name = "isavailable";
            this.isavailable.Visible = false;
            this.isavailable.Width = 125;
            // 
            // categoriID
            // 
            this.categoriID.DataPropertyName = "CategoryID";
            this.categoriID.HeaderText = "CategoryID";
            this.categoriID.MinimumWidth = 6;
            this.categoriID.Name = "categoriID";
            this.categoriID.Visible = false;
            this.categoriID.Width = 125;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvorderDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetails";
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dgvorderDetails;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn isavailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriID;
    }
}
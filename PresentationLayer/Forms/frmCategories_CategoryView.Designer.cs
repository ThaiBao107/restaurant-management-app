namespace PresentationLayer.Forms
{
    partial class frmCategories_CategoryView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Categories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Categories_Add
            // 
            this.btn_Categories_Add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Categories_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Categories_Add.HoverState.ImageSize = new System.Drawing.Size(93, 93);
            this.btn_Categories_Add.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btn_Categories_Add.Location = new System.Drawing.Point(34, 73);
            this.btn_Categories_Add.PressedState.ImageSize = new System.Drawing.Size(90, 90);
            this.btn_Categories_Add.Click += new System.EventHandler(this.btn_Categories_Add_Click);
            // 
            // lb_Header
            // 
            this.lb_Header.Location = new System.Drawing.Point(40, 38);
            this.lb_Header.Size = new System.Drawing.Size(181, 32);
            this.lb_Header.Text = "Category List";
            // 
            // lb_Search
            // 
            this.lb_Search.Location = new System.Drawing.Point(729, 102);
            // 
            // txt_Categories_Search
            // 
            this.txt_Categories_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Categories_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Categories_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Categories_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Categories_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Categories_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Categories_Search.Location = new System.Drawing.Point(725, 133);
            this.txt_Categories_Search.Size = new System.Drawing.Size(331, 36);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(34, 194);
            this.guna2Separator1.Size = new System.Drawing.Size(1022, 29);
            // 
            // dgv_Categories
            // 
            this.dgv_Categories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Categories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Categories.ColumnHeadersHeight = 60;
            this.dgv_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.CategoryDescription,
            this.CategoryEdit,
            this.CategoryDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Categories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Categories.EnableHeadersVisualStyles = false;
            this.dgv_Categories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Categories.Location = new System.Drawing.Point(34, 245);
            this.dgv_Categories.Name = "dgv_Categories";
            this.dgv_Categories.ReadOnly = true;
            this.dgv_Categories.RowHeadersVisible = false;
            this.dgv_Categories.RowHeadersWidth = 62;
            this.dgv_Categories.RowTemplate.Height = 28;
            this.dgv_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Categories.Size = new System.Drawing.Size(1022, 471);
            this.dgv_Categories.TabIndex = 6;
            this.dgv_Categories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Categories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Categories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Categories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Categories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Categories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Categories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Categories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Categories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Categories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Categories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Categories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Categories.ThemeStyle.HeaderStyle.Height = 60;
            this.dgv_Categories.ThemeStyle.ReadOnly = true;
            this.dgv_Categories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Categories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Categories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Categories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Categories.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Categories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Categories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Categories_CellContentClick);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.FillWeight = 88.01686F;
            this.CategoryID.HeaderText = "ID";
            this.CategoryID.MinimumWidth = 30;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.FillWeight = 91.89995F;
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.MinimumWidth = 60;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.FillWeight = 170.4545F;
            this.CategoryDescription.HeaderText = "Decsription";
            this.CategoryDescription.MinimumWidth = 60;
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            // 
            // CategoryEdit
            // 
            this.CategoryEdit.FillWeight = 74.81434F;
            this.CategoryEdit.HeaderText = "";
            this.CategoryEdit.MinimumWidth = 10;
            this.CategoryEdit.Name = "CategoryEdit";
            this.CategoryEdit.ReadOnly = true;
            // 
            // CategoryDelete
            // 
            this.CategoryDelete.FillWeight = 74.81434F;
            this.CategoryDelete.HeaderText = "";
            this.CategoryDelete.MinimumWidth = 10;
            this.CategoryDelete.Name = "CategoryDelete";
            this.CategoryDelete.ReadOnly = true;
            // 
            // frmCategories_CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.dgv_Categories);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCategories_CategoryView";
            this.Text = "frmCategories_CategoryView";
            this.Load += new System.EventHandler(this.frmCategories_CategoryView_Load);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.txt_Categories_Search, 0);
            this.Controls.SetChildIndex(this.lb_Search, 0);
            this.Controls.SetChildIndex(this.btn_Categories_Add, 0);
            this.Controls.SetChildIndex(this.lb_Header, 0);
            this.Controls.SetChildIndex(this.dgv_Categories, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_Categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.DataGridViewImageColumn CategoryEdit;
        private System.Windows.Forms.DataGridViewImageColumn CategoryDelete;
    }
}
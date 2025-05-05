namespace PresentationLayer.Forms
{
    partial class frmCategories_CategoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories_CategoryAdd));
            this.lb_NameCategory = new System.Windows.Forms.Label();
            this.txt_NameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt__Category_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btn__Categories_Save
            // 
            this.btn__Categories_Save.CustomizableEdges.BottomLeft = false;
            this.btn__Categories_Save.CustomizableEdges.TopRight = false;
            this.btn__Categories_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn__Categories_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn__Categories_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn__Categories_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn__Categories_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn__Categories_Save.Location = new System.Drawing.Point(91, 17);
            this.btn__Categories_Save.Click += new System.EventHandler(this.btn_Categories_Save_Click);
            // 
            // btn_Categories_Close
            // 
            this.btn_Categories_Close.CustomizableEdges.BottomLeft = false;
            this.btn_Categories_Close.CustomizableEdges.TopRight = false;
            this.btn_Categories_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Categories_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Categories_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Categories_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Categories_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Categories_Close.Location = new System.Drawing.Point(314, 17);
            this.btn_Categories_Close.Click += new System.EventHandler(this.frmCategories_CategoryAdd_Load);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Size = new System.Drawing.Size(589, 135);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(0, 586);
            this.guna2Panel2.Size = new System.Drawing.Size(589, 96);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 55);
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.Text = "Add Category";
            // 
            // lb_NameCategory
            // 
            this.lb_NameCategory.AutoSize = true;
            this.lb_NameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCategory.Location = new System.Drawing.Point(63, 203);
            this.lb_NameCategory.Name = "lb_NameCategory";
            this.lb_NameCategory.Size = new System.Drawing.Size(78, 29);
            this.lb_NameCategory.TabIndex = 3;
            this.lb_NameCategory.Text = "Name";
            // 
            // txt_NameCategory
            // 
            this.txt_NameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameCategory.DefaultText = "";
            this.txt_NameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCategory.Location = new System.Drawing.Point(68, 244);
            this.txt_NameCategory.Name = "txt_NameCategory";
            this.txt_NameCategory.PasswordChar = '\0';
            this.txt_NameCategory.PlaceholderText = "Enter category";
            this.txt_NameCategory.SelectedText = "";
            this.txt_NameCategory.Size = new System.Drawing.Size(422, 59);
            this.txt_NameCategory.TabIndex = 4;
            // 
            // txt__Category_Description
            // 
            this.txt__Category_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__Category_Description.DefaultText = "";
            this.txt__Category_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__Category_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__Category_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__Category_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__Category_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt__Category_Description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt__Category_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt__Category_Description.Location = new System.Drawing.Point(68, 403);
            this.txt__Category_Description.Name = "txt__Category_Description";
            this.txt__Category_Description.PasswordChar = '\0';
            this.txt__Category_Description.PlaceholderText = "Enter description (optional)";
            this.txt__Category_Description.SelectedText = "";
            this.txt__Category_Description.Size = new System.Drawing.Size(422, 59);
            this.txt__Category_Description.TabIndex = 6;
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(63, 362);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(135, 29);
            this.lb_Description.TabIndex = 5;
            this.lb_Description.Text = "Description";
            this.lb_Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmCategories_CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 682);
            this.Controls.Add(this.txt__Category_Description);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.txt_NameCategory);
            this.Controls.Add(this.lb_NameCategory);
            this.Name = "frmCategories_CategoryAdd";
            this.Text = "frmCategories_CategoryAdd";
            this.Load += new System.EventHandler(this.frmCategories_CategoryAdd_Load);
            this.Controls.SetChildIndex(this.guna2Panel1, 0);
            this.Controls.SetChildIndex(this.guna2Panel2, 0);
            this.Controls.SetChildIndex(this.lb_NameCategory, 0);
            this.Controls.SetChildIndex(this.txt_NameCategory, 0);
            this.Controls.SetChildIndex(this.lb_Description, 0);
            this.Controls.SetChildIndex(this.txt__Category_Description, 0);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_NameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt__Category_Description;
        private System.Windows.Forms.Label lb_Description;
    }
}
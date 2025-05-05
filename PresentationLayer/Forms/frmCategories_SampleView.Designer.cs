namespace PresentationLayer.Forms
{
    partial class frmCategories_SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories_SampleView));
            this.lb_Search = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Header = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_Categories_Add = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_Categories_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Search.Location = new System.Drawing.Point(713, 91);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(75, 25);
            this.lb_Search.TabIndex = 1;
            this.lb_Search.Text = "Search";
            this.lb_Search.Click += new System.EventHandler(this.lb_Search_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(692, 125);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search here";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(470, 52);
            this.guna2TextBox1.TabIndex = 2;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.txt_Categories_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.lb_Search_Click);
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Header.Location = new System.Drawing.Point(18, 38);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(169, 32);
            this.lb_Header.TabIndex = 4;
            this.lb_Header.Text = "Header Text";
            this.lb_Header.Click += new System.EventHandler(this.lb_Header_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(12, 197);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1175, 13);
            this.guna2Separator1.TabIndex = 5;
            // 
            // btn_Categories_Add
            // 
            this.btn_Categories_Add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Categories_Add.HoverState.ImageSize = new System.Drawing.Size(93, 93);
            this.btn_Categories_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categories_Add.Image")));
            this.btn_Categories_Add.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Categories_Add.ImageRotate = 0F;
            this.btn_Categories_Add.ImageSize = new System.Drawing.Size(90, 90);
            this.btn_Categories_Add.Location = new System.Drawing.Point(12, 73);
            this.btn_Categories_Add.Name = "btn_Categories_Add";
            this.btn_Categories_Add.PressedState.ImageSize = new System.Drawing.Size(90, 90);
            this.btn_Categories_Add.Size = new System.Drawing.Size(100, 96);
            this.btn_Categories_Add.TabIndex = 3;
            this.btn_Categories_Add.Click += new System.EventHandler(this.btn_Categories_Add_Click);
            // 
            // txt_Categories_Search
            // 
            this.txt_Categories_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Categories_Search.DefaultText = "";
            this.txt_Categories_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Categories_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Categories_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Categories_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Categories_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Categories_Search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Categories_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Categories_Search.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Categories_Search.IconLeft")));
            this.txt_Categories_Search.Location = new System.Drawing.Point(717, 117);
            this.txt_Categories_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Categories_Search.Name = "txt_Categories_Search";
            this.txt_Categories_Search.PasswordChar = '\0';
            this.txt_Categories_Search.PlaceholderText = "Search here";
            this.txt_Categories_Search.SelectedText = "";
            this.txt_Categories_Search.Size = new System.Drawing.Size(470, 52);
            this.txt_Categories_Search.TabIndex = 2;
            this.txt_Categories_Search.TextChanged += new System.EventHandler(this.txt_Categories_Search_TextChanged);
            // 
            // frmCategories_SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1459, 745);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lb_Header);
            this.Controls.Add(this.btn_Categories_Add);
            this.Controls.Add(this.txt_Categories_Search);
            this.Controls.Add(this.lb_Search);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories_SampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategories_SampleView";
            this.Load += new System.EventHandler(this.frmCategories_SampleView_Load);
            this.Click += new System.EventHandler(this.lb_Search_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton btn_Categories_Add;
        public System.Windows.Forms.Label lb_Header;
        public System.Windows.Forms.Label lb_Search;
        public Guna.UI2.WinForms.Guna2TextBox txt_Categories_Search;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
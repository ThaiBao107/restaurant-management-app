namespace PresentationLayer.Forms
{
    partial class frmTaoDH
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lads = new System.Windows.Forms.Label();
            this.txtMAKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBanSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayTao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.radioTTTienMat = new System.Windows.Forms.RadioButton();
            this.radioTTVNPAY = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.comboBoxNV = new System.Windows.Forms.ComboBox();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.btnTaoDH = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Khaki;
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.lb);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(513, 64);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(457, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 36);
            this.btnExit.TabIndex = 21;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Khaki;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb.Location = new System.Drawing.Point(142, 16);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(229, 38);
            this.lb.TabIndex = 0;
            this.lb.Text = "Tạo đơn hàng";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điên thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(149, 92);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(220, 35);
            this.txtSDT.TabIndex = 2;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lads
            // 
            this.lads.AutoSize = true;
            this.lads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lads.Location = new System.Drawing.Point(6, 156);
            this.lads.Name = "lads";
            this.lads.Size = new System.Drawing.Size(137, 22);
            this.lads.TabIndex = 5;
            this.lads.Text = "Mã khách hàng:";
            // 
            // txtMAKH
            // 
            this.txtMAKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMAKH.DefaultText = "x";
            this.txtMAKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMAKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMAKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMAKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMAKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMAKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMAKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMAKH.Location = new System.Drawing.Point(149, 143);
            this.txtMAKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.PlaceholderText = "";
            this.txtMAKH.ReadOnly = true;
            this.txtMAKH.SelectedText = "";
            this.txtMAKH.Size = new System.Drawing.Size(220, 35);
            this.txtMAKH.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bàn số: ";
            // 
            // lbBanSo
            // 
            this.lbBanSo.AutoSize = true;
            this.lbBanSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanSo.Location = new System.Drawing.Point(145, 205);
            this.lbBanSo.Name = "lbBanSo";
            this.lbBanSo.Size = new System.Drawing.Size(19, 22);
            this.lbBanSo.TabIndex = 8;
            this.lbBanSo.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày tạo: ";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayTao.DefaultText = "";
            this.txtNgayTao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayTao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayTao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayTao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayTao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayTao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayTao.Location = new System.Drawing.Point(149, 289);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.PlaceholderText = "";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.SelectedText = "";
            this.txtNgayTao.Size = new System.Drawing.Size(220, 35);
            this.txtNgayTao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(149, 361);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(220, 100);
            this.txtGhiChu.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thành tiền: ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTongTien.Location = new System.Drawing.Point(144, 489);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(25, 29);
            this.txtTongTien.TabIndex = 18;
            this.txtTongTien.Text = "x";
            // 
            // radioTTTienMat
            // 
            this.radioTTTienMat.AutoSize = true;
            this.radioTTTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTTTienMat.Location = new System.Drawing.Point(33, 527);
            this.radioTTTienMat.Name = "radioTTTienMat";
            this.radioTTTienMat.Size = new System.Drawing.Size(178, 24);
            this.radioTTTienMat.TabIndex = 19;
            this.radioTTTienMat.TabStop = true;
            this.radioTTTienMat.Text = "Thanh toán tiền mặt";
            this.radioTTTienMat.UseVisualStyleBackColor = true;
            this.radioTTTienMat.CheckedChanged += new System.EventHandler(this.radioTTTienMat_CheckedChanged);
            // 
            // radioTTVNPAY
            // 
            this.radioTTVNPAY.AutoSize = true;
            this.radioTTVNPAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTTVNPAY.Location = new System.Drawing.Point(265, 527);
            this.radioTTVNPAY.Name = "radioTTVNPAY";
            this.radioTTVNPAY.Size = new System.Drawing.Size(214, 24);
            this.radioTTVNPAY.TabIndex = 20;
            this.radioTTVNPAY.TabStop = true;
            this.radioTTVNPAY.Text = "Thanh toán bằng VNPAY";
            this.radioTTVNPAY.UseVisualStyleBackColor = true;
            this.radioTTVNPAY.CheckedChanged += new System.EventHandler(this.radioTTVNPAY_CheckedChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::PresentationLayer.Properties.Resources.search3;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTim.Location = new System.Drawing.Point(375, 92);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(37, 35);
            this.btnTim.TabIndex = 21;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // comboBoxNV
            // 
            this.comboBoxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNV.FormattingEnabled = true;
            this.comboBoxNV.Location = new System.Drawing.Point(149, 246);
            this.comboBoxNV.Name = "comboBoxNV";
            this.comboBoxNV.Size = new System.Drawing.Size(220, 28);
            this.comboBoxNV.TabIndex = 22;
            this.comboBoxNV.SelectedIndexChanged += new System.EventHandler(this.comboBoxNV_SelectedIndexChanged);
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.Location = new System.Drawing.Point(33, 575);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(435, 106);
            this.pnlThanhToan.TabIndex = 23;
            // 
            // btnTaoDH
            // 
            this.btnTaoDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDH.Location = new System.Drawing.Point(147, 714);
            this.btnTaoDH.Name = "btnTaoDH";
            this.btnTaoDH.Size = new System.Drawing.Size(222, 56);
            this.btnTaoDH.TabIndex = 24;
            this.btnTaoDH.Text = "Tạo";
            this.btnTaoDH.UseVisualStyleBackColor = true;
            this.btnTaoDH.Click += new System.EventHandler(this.btnTaoDH_Click);
            // 
            // frmTaoDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 795);
            this.Controls.Add(this.btnTaoDH);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.comboBoxNV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.radioTTVNPAY);
            this.Controls.Add(this.radioTTTienMat);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBanSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMAKH);
            this.Controls.Add(this.lads);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaoDH";
            this.Text = "frmTaoDH";
            this.Load += new System.EventHandler(this.frmTaoDH_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lads;
        private Guna.UI2.WinForms.Guna2TextBox txtMAKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBanSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayTao;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.RadioButton radioTTTienMat;
        private System.Windows.Forms.RadioButton radioTTVNPAY;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox comboBoxNV;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Button btnTaoDH;
    }
}
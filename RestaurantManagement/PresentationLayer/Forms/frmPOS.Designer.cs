namespace PresentationLayer.Forms
{
    partial class frmPOS
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
            this.POS = new System.Windows.Forms.Label();
            this.taoDHbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.thanhtoanbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.POS);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 73);
            this.panel1.TabIndex = 1;
            // 
            // POS
            // 
            this.POS.AutoSize = true;
            this.POS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.POS.Location = new System.Drawing.Point(16, 14);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(74, 32);
            this.POS.TabIndex = 2;
            this.POS.Text = "POS";
            // 
            // taoDHbtn
            // 
            this.taoDHbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.taoDHbtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.taoDHbtn.Image = global::PresentationLayer.Properties.Resources.donhang;
            this.taoDHbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.taoDHbtn.ImageRotate = 1F;
            this.taoDHbtn.ImageSize = new System.Drawing.Size(200, 200);
            this.taoDHbtn.Location = new System.Drawing.Point(702, 263);
            this.taoDHbtn.Name = "taoDHbtn";
            this.taoDHbtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.taoDHbtn.Size = new System.Drawing.Size(299, 211);
            this.taoDHbtn.TabIndex = 3;
            // 
            // thanhtoanbtn
            // 
            this.thanhtoanbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thanhtoanbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.thanhtoanbtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.thanhtoanbtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.thanhtoanbtn.Image = global::PresentationLayer.Properties.Resources.thanhtoan2;
            this.thanhtoanbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.thanhtoanbtn.ImageRotate = 1F;
            this.thanhtoanbtn.ImageSize = new System.Drawing.Size(200, 200);
            this.thanhtoanbtn.Location = new System.Drawing.Point(316, 257);
            this.thanhtoanbtn.Name = "thanhtoanbtn";
            this.thanhtoanbtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.thanhtoanbtn.Size = new System.Drawing.Size(273, 217);
            this.thanhtoanbtn.TabIndex = 2;
            this.thanhtoanbtn.Click += new System.EventHandler(this.thanhtoanbtn_Click);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 697);
            this.Controls.Add(this.taoDHbtn);
            this.Controls.Add(this.thanhtoanbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label POS;
        private Guna.UI2.WinForms.Guna2ImageButton thanhtoanbtn;
        private Guna.UI2.WinForms.Guna2ImageButton taoDHbtn;
    }
}
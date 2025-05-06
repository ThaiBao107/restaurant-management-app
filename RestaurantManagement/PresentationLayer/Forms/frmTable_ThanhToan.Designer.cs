namespace PresentationLayer.Forms
{
    partial class frmTable_ThanhToan
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
            this.lb1 = new System.Windows.Forms.Label();
            this.Tablepnl = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Bisque;
            this.guna2Panel1.Controls.Add(this.lb1);
            this.guna2Panel1.Location = new System.Drawing.Point(4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(667, 78);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Bisque;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Brown;
            this.lb1.Location = new System.Drawing.Point(273, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(94, 29);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "TABLE";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tablepnl
            // 
            this.Tablepnl.Location = new System.Drawing.Point(4, 89);
            this.Tablepnl.Name = "Tablepnl";
            this.Tablepnl.Size = new System.Drawing.Size(667, 418);
            this.Tablepnl.TabIndex = 1;
            this.Tablepnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Tablepnl_Paint);
            // 
            // frmTable_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 508);
            this.Controls.Add(this.Tablepnl);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable_ThanhToan";
            this.Text = "frmTable_ThanhToan";
            this.Load += new System.EventHandler(this.frmTable_ThanhToan_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.FlowLayoutPanel Tablepnl;
    }
}
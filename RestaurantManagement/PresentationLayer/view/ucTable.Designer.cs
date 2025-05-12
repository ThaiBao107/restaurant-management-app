namespace PresentationLayer.View
{
    partial class ucTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTable = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Tan;
            this.guna2Panel1.Controls.Add(this.txtTable);
            this.guna2Panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(108, 81);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // txtTable
            // 
            this.txtTable.Image = global::PresentationLayer.Properties.Resources.Table_S;
            this.txtTable.ImageRotate = 0F;
            this.txtTable.Location = new System.Drawing.Point(20, 11);
            this.txtTable.Margin = new System.Windows.Forms.Padding(2);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(70, 52);
            this.txtTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtTable.TabIndex = 2;
            this.txtTable.TabStop = false;
            this.txtTable.Click += new System.EventHandler(this.txtTable_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-2, 84);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(110, 36);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lbNameTable);
            this.guna2Panel2.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2Panel2.Location = new System.Drawing.Point(2, 89);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(106, 31);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lbNameTable
            // 
            this.lbNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.Location = new System.Drawing.Point(17, 7);
            this.lbNameTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(74, 16);
            this.lbNameTable.TabIndex = 1;
            this.lbNameTable.Text = "Table Name";
            this.lbNameTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(-2, 84);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(110, 36);
            this.guna2CustomGradientPanel2.TabIndex = 0;
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(112, 122);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox txtTable;
        private System.Windows.Forms.Label lbNameTable;
    }
}

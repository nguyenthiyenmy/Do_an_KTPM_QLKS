
namespace QLKhachSannn
{
    partial class fMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TraCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TraCuuToolStripMenuItem,
            this.DatPhongToolStripMenuItem,
            this.DichVuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TraCuuToolStripMenuItem
            // 
            this.TraCuuToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.TraCuuToolStripMenuItem.Name = "TraCuuToolStripMenuItem";
            this.TraCuuToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.TraCuuToolStripMenuItem.Text = "TRA CỨU";
            this.TraCuuToolStripMenuItem.Click += new System.EventHandler(this.TraCuuToolStripMenuItem_Click);
            // 
            // DatPhongToolStripMenuItem
            // 
            this.DatPhongToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.DatPhongToolStripMenuItem.Name = "DatPhongToolStripMenuItem";
            this.DatPhongToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.DatPhongToolStripMenuItem.Text = "ĐẶT PHÒNG";
            this.DatPhongToolStripMenuItem.Click += new System.EventHandler(this.DatPhongToolStripMenuItem_Click);
            // 
            // DichVuToolStripMenuItem
            // 
            this.DichVuToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.DichVuToolStripMenuItem.Name = "DichVuToolStripMenuItem";
            this.DichVuToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.DichVuToolStripMenuItem.Text = "DỊCH VỤ";
            this.DichVuToolStripMenuItem.Click += new System.EventHandler(this.DichVuToolStripMenuItem_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKhachSannn.Properties.Resources._270114311_4749986615091111_3418751548170437429_n;
            this.ClientSize = new System.Drawing.Size(661, 345);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fMenu";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TraCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DichVuToolStripMenuItem;
    }
}


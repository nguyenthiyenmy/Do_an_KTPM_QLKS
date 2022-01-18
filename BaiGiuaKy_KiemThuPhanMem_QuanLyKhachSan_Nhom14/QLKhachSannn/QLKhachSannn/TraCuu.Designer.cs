
namespace QLKhachSannn
{
    partial class TraCuu
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
            this.gridDsPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.rdTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdGia = new System.Windows.Forms.RadioButton();
            this.rdLoai = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDsPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDsPhong
            // 
            this.gridDsPhong.BackgroundColor = System.Drawing.Color.OldLace;
            this.gridDsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDsPhong.Location = new System.Drawing.Point(39, 396);
            this.gridDsPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridDsPhong.Name = "gridDsPhong";
            this.gridDsPhong.RowHeadersWidth = 51;
            this.gridDsPhong.RowTemplate.Height = 24;
            this.gridDsPhong.Size = new System.Drawing.Size(579, 141);
            this.gridDsPhong.TabIndex = 8;
            this.gridDsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDsPhong_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.rdTinhTrang);
            this.groupBox1.Controls.Add(this.rdGia);
            this.groupBox1.Controls.Add(this.rdLoai);
            this.groupBox1.Controls.Add(this.rdMa);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(579, 292);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM NHANH";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(340, 221);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(122, 44);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.SandyBrown;
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(123, 221);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(113, 44);
            this.btTimKiem.TabIndex = 3;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click_1);
            // 
            // rdTinhTrang
            // 
            this.rdTinhTrang.AutoSize = true;
            this.rdTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTinhTrang.Location = new System.Drawing.Point(298, 166);
            this.rdTinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTinhTrang.Name = "rdTinhTrang";
            this.rdTinhTrang.Size = new System.Drawing.Size(183, 24);
            this.rdTinhTrang.TabIndex = 2;
            this.rdTinhTrang.Text = "Theo tình trạng phòng";
            this.rdTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdGia
            // 
            this.rdGia.AutoSize = true;
            this.rdGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGia.Location = new System.Drawing.Point(298, 110);
            this.rdGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGia.Name = "rdGia";
            this.rdGia.Size = new System.Drawing.Size(137, 24);
            this.rdGia.TabIndex = 2;
            this.rdGia.Text = "Theo giá phòng";
            this.rdGia.UseVisualStyleBackColor = true;
            // 
            // rdLoai
            // 
            this.rdLoai.AutoSize = true;
            this.rdLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLoai.Location = new System.Drawing.Point(66, 166);
            this.rdLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdLoai.Name = "rdLoai";
            this.rdLoai.Size = new System.Drawing.Size(140, 24);
            this.rdLoai.TabIndex = 2;
            this.rdLoai.Text = "Theo loại phòng";
            this.rdLoai.UseVisualStyleBackColor = true;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Checked = true;
            this.rdMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMa.Location = new System.Drawing.Point(66, 110);
            this.rdMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(138, 24);
            this.rdMa.TabIndex = 2;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Theo mã phòng";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(217, 57);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(283, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "TRA CỨU PHÒNG";
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(668, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDsPhong);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "TraCuu";
            this.Text = "TRA CỨU THÔNG TIN PHÒNG";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDsPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDsPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.RadioButton rdTinhTrang;
        private System.Windows.Forms.RadioButton rdGia;
        private System.Windows.Forms.RadioButton rdLoai;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
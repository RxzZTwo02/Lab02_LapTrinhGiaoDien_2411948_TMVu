namespace Lab02_QuanLySinhVien
{
    partial class frmTuyChon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxTim = new System.Windows.Forms.GroupBox();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTim
            // 
            this.groupBoxTim.Controls.Add(this.rdNgaySinh);
            this.groupBoxTim.Controls.Add(this.rdHoTen);
            this.groupBoxTim.Controls.Add(this.rdMaSV);
            this.groupBoxTim.Location = new System.Drawing.Point(25, 12);
            this.groupBoxTim.Name = "groupBoxTim";
            this.groupBoxTim.Size = new System.Drawing.Size(430, 60);
            this.groupBoxTim.TabIndex = 0;
            this.groupBoxTim.TabStop = false;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.rdNgaySinh.Location = new System.Drawing.Point(295, 23);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(95, 21);
            this.rdNgaySinh.TabIndex = 2;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            this.rdNgaySinh.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTen.ForeColor = System.Drawing.Color.Blue;
            this.rdHoTen.Location = new System.Drawing.Point(165, 23);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(75, 21);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Checked = true;
            this.rdMaSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaSV.ForeColor = System.Drawing.Color.Blue;
            this.rdMaSV.Location = new System.Drawing.Point(35, 23);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(72, 21);
            this.rdMaSV.TabIndex = 0;
            this.rdMaSV.TabStop = true;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapThongTin.Location = new System.Drawing.Point(30, 93);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(100, 17);
            this.lblNhapThongTin.TabIndex = 1;
            this.lblNhapThongTin.Text = "Nhập Thông tin";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(145, 90);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(215, 25);
            this.txtThongTin.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Purple;
            this.btnTim.Location = new System.Drawing.Point(375, 87);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 29);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Purple;
            this.btnSapXep.Location = new System.Drawing.Point(120, 137);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(95, 33);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(265, 137);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 191);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.lblNhapThongTin);
            this.Controls.Add(this.groupBoxTim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.groupBoxTim.ResumeLayout(false);
            this.groupBoxTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxTim;
        public System.Windows.Forms.RadioButton rdNgaySinh;
        public System.Windows.Forms.RadioButton rdHoTen;
        public System.Windows.Forms.RadioButton rdMaSV;
        public System.Windows.Forms.Label lblNhapThongTin;
        public System.Windows.Forms.TextBox txtThongTin;
        public System.Windows.Forms.Button btnTim;
        public System.Windows.Forms.Button btnSapXep;
        public System.Windows.Forms.Button btnThoat;
    }
}

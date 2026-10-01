namespace Lab02_NhapThongTinGiangVien
{
    partial class frmTimGiangVien
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
            this.gbTimTheo = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbTimTheo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTimTheo
            // 
            this.gbTimTheo.Controls.Add(this.rdSoDT);
            this.gbTimTheo.Controls.Add(this.rdHoTen);
            this.gbTimTheo.Controls.Add(this.rdMaGV);
            this.gbTimTheo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimTheo.Location = new System.Drawing.Point(24, 18);
            this.gbTimTheo.Name = "gbTimTheo";
            this.gbTimTheo.Size = new System.Drawing.Size(465, 62);
            this.gbTimTheo.TabIndex = 0;
            this.gbTimTheo.TabStop = false;
            this.gbTimTheo.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.Location = new System.Drawing.Point(318, 25);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(102, 21);
            this.rdSoDT.TabIndex = 2;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            this.rdSoDT.CheckedChanged += new System.EventHandler(this.rdTim_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTen.Location = new System.Drawing.Point(176, 25);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(66, 21);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdTim_CheckedChanged);
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaGV.Location = new System.Drawing.Point(32, 25);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(71, 21);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdTim_CheckedChanged);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTim.Location = new System.Drawing.Point(26, 99);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(62, 19);
            this.lblTim.TabIndex = 1;
            this.lblTim.Text = "Mã GV";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(135, 96);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(260, 25);
            this.txtTim.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(407, 92);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 31);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmTimGiangVien
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 149);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.gbTimTheo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm thông tin giảng viên";
            this.gbTimTheo.ResumeLayout(false);
            this.gbTimTheo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimTheo;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}

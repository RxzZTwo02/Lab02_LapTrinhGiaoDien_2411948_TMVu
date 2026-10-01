namespace Lab02_QuanLySinhVien
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxTTSV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuyenNganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripLV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCtxFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtxMauChu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtxSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCtxTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTongSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMauChu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupboxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.groupboxDSSV.SuspendLayout();
            this.contextMenuStripLV.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxTTSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupboxDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 515);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupboxTTSV
            // 
            this.groupboxTTSV.Controls.Add(this.btnThoat);
            this.groupboxTTSV.Controls.Add(this.btnMacDinh);
            this.groupboxTTSV.Controls.Add(this.btnSua);
            this.groupboxTTSV.Controls.Add(this.btnXoa);
            this.groupboxTTSV.Controls.Add(this.btnThem);
            this.groupboxTTSV.Controls.Add(this.pbHinh);
            this.groupboxTTSV.Controls.Add(this.clbChuyenNganh);
            this.groupboxTTSV.Controls.Add(this.rdNu);
            this.groupboxTTSV.Controls.Add(this.rdNam);
            this.groupboxTTSV.Controls.Add(this.btnBrowse);
            this.groupboxTTSV.Controls.Add(this.txtHinh);
            this.groupboxTTSV.Controls.Add(this.cboLop);
            this.groupboxTTSV.Controls.Add(this.txtDiaChi);
            this.groupboxTTSV.Controls.Add(this.dtpNgaySinh);
            this.groupboxTTSV.Controls.Add(this.txtHoTen);
            this.groupboxTTSV.Controls.Add(this.mtxtMaSo);
            this.groupboxTTSV.Controls.Add(this.label8);
            this.groupboxTTSV.Controls.Add(this.label7);
            this.groupboxTTSV.Controls.Add(this.label6);
            this.groupboxTTSV.Controls.Add(this.label5);
            this.groupboxTTSV.Controls.Add(this.label4);
            this.groupboxTTSV.Controls.Add(this.label3);
            this.groupboxTTSV.Controls.Add(this.label2);
            this.groupboxTTSV.Controls.Add(this.label1);
            this.groupboxTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxTTSV.Location = new System.Drawing.Point(0, 0);
            this.groupboxTTSV.Name = "groupboxTTSV";
            this.groupboxTTSV.Size = new System.Drawing.Size(490, 515);
            this.groupboxTTSV.TabIndex = 0;
            this.groupboxTTSV.TabStop = false;
            this.groupboxTTSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(400, 465);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.Color.Purple;
            this.btnMacDinh.Location = new System.Drawing.Point(305, 465);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 13;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Purple;
            this.btnSua.Location = new System.Drawing.Point(210, 465);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(115, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Purple;
            this.btnThem.Location = new System.Drawing.Point(20, 465);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 20);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(150, 180);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 18;
            this.pbHinh.TabStop = false;
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(115, 335);
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(200, 109);
            this.clbChuyenNganh.TabIndex = 9;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(200, 295);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 8;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(115, 295);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 7;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(440, 253);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(245, 255);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(185, 20);
            this.txtHinh.TabIndex = 5;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.cboLop.Location = new System.Drawing.Point(245, 215);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(120, 21);
            this.cboLop.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(245, 175);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(245, 135);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(245, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(245, 55);
            this.mtxtMaSo.Mask = "\\SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(120, 20);
            this.mtxtMaSo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chuyên Ngành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // groupboxDSSV
            // 
            this.groupboxDSSV.Controls.Add(this.lvSinhVien);
            this.groupboxDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxDSSV.Location = new System.Drawing.Point(0, 0);
            this.groupboxDSSV.Name = "groupboxDSSV";
            this.groupboxDSSV.Size = new System.Drawing.Size(590, 515);
            this.groupboxDSSV.TabIndex = 0;
            this.groupboxDSSV.TabStop = false;
            this.groupboxDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSo,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colLop,
            this.colPhai,
            this.colChuyenNganh,
            this.colHinh});
            this.lvSinhVien.ContextMenuStrip = this.contextMenuStripLV;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(584, 496);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMaSo
            // 
            this.colMaSo.Text = "Mã số";
            this.colMaSo.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 140;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 90;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 100;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 70;
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            this.colPhai.Width = 50;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.Text = "Chuyên ngành";
            this.colChuyenNganh.Width = 180;
            // 
            // colHinh
            // 
            this.colHinh.Text = "Hình";
            this.colHinh.Width = 100;
            // 
            // contextMenuStripLV
            // 
            this.contextMenuStripLV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCtxFont,
            this.tsmiCtxMauChu,
            this.tsmiCtxSapXep,
            this.tsmiCtxTimKiem});
            this.contextMenuStripLV.Name = "contextMenuStripLV";
            this.contextMenuStripLV.Size = new System.Drawing.Size(125, 92);
            // 
            // tsmiCtxFont
            // 
            this.tsmiCtxFont.Name = "tsmiCtxFont";
            this.tsmiCtxFont.Size = new System.Drawing.Size(124, 22);
            this.tsmiCtxFont.Text = "Font";
            this.tsmiCtxFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiCtxMauChu
            // 
            this.tsmiCtxMauChu.Name = "tsmiCtxMauChu";
            this.tsmiCtxMauChu.Size = new System.Drawing.Size(124, 22);
            this.tsmiCtxMauChu.Text = "Màu chữ";
            this.tsmiCtxMauChu.Click += new System.EventHandler(this.tsmiMauChu_Click);
            // 
            // tsmiCtxSapXep
            // 
            this.tsmiCtxSapXep.Name = "tsmiCtxSapXep";
            this.tsmiCtxSapXep.Size = new System.Drawing.Size(124, 22);
            this.tsmiCtxSapXep.Text = "Sắp xếp";
            this.tsmiCtxSapXep.Click += new System.EventHandler(this.tsmiSapXep_Click);
            // 
            // tsmiCtxTimKiem
            // 
            this.tsmiCtxTimKiem.Name = "tsmiCtxTimKiem";
            this.tsmiCtxTimKiem.Size = new System.Drawing.Size(124, 22);
            this.tsmiCtxTimKiem.Text = "Tìm kiếm";
            this.tsmiCtxTimKiem.Click += new System.EventHandler(this.tsmiTimKiem_Click);
            // 
            // openFileDialogHinh
            // 
            this.openFileDialogHinh.FileName = "Hãy Chọn File";
            this.openFileDialogHinh.Filter = "Image File(*.bmp; *.jpg; *.png)|*.bmp;*.jpg;*.png|All File(*.*)|*.*";
            this.openFileDialogHinh.Title = "Open File Image";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTongSV});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTongSV
            // 
            this.toolStripStatusLabelTongSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTongSV.Name = "toolStripStatusLabelTongSV";
            this.toolStripStatusLabelTongSV.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabelTongSV.Text = "Tổng Sinh Viên: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoFile,
            this.tsmiThoat});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiMoFile
            // 
            this.tsmiMoFile.Name = "tsmiMoFile";
            this.tsmiMoFile.Size = new System.Drawing.Size(113, 22);
            this.tsmiMoFile.Text = "Mở File";
            this.tsmiMoFile.Click += new System.EventHandler(this.tsmiMoFile_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(113, 22);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa,
            this.tsmiSua,
            this.tsmiListView});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiThem
            // 
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiThem.Size = new System.Drawing.Size(169, 22);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Y)));
            this.tsmiXoa.Size = new System.Drawing.Size(169, 22);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiSua
            // 
            this.tsmiSua.Name = "tsmiSua";
            this.tsmiSua.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSua.Size = new System.Drawing.Size(169, 22);
            this.tsmiSua.Text = "Sửa";
            this.tsmiSua.Click += new System.EventHandler(this.tsmiSua_Click);
            // 
            // tsmiListView
            // 
            this.tsmiListView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFont,
            this.tsmiMauChu,
            this.tsmiSapXep,
            this.tsmiTimKiem});
            this.tsmiListView.Name = "tsmiListView";
            this.tsmiListView.Size = new System.Drawing.Size(169, 22);
            this.tsmiListView.Text = "ListView";
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(125, 22);
            this.tsmiFont.Text = "Font";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiMauChu
            // 
            this.tsmiMauChu.Name = "tsmiMauChu";
            this.tsmiMauChu.Size = new System.Drawing.Size(125, 22);
            this.tsmiMauChu.Text = "Màu Chữ";
            this.tsmiMauChu.Click += new System.EventHandler(this.tsmiMauChu_Click);
            // 
            // tsmiSapXep
            // 
            this.tsmiSapXep.Name = "tsmiSapXep";
            this.tsmiSapXep.Size = new System.Drawing.Size(125, 22);
            this.tsmiSapXep.Text = "Sắp Xếp";
            this.tsmiSapXep.Click += new System.EventHandler(this.tsmiSapXep_Click);
            // 
            // tsmiTimKiem
            // 
            this.tsmiTimKiem.Name = "tsmiTimKiem";
            this.tsmiTimKiem.Size = new System.Drawing.Size(125, 22);
            this.tsmiTimKiem.Text = "Tìm Kiếm";
            this.tsmiTimKiem.Click += new System.EventHandler(this.tsmiTimKiem_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupboxTTSV.ResumeLayout(false);
            this.groupboxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.groupboxDSSV.ResumeLayout(false);
            this.contextMenuStripLV.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupboxTTSV;
        private System.Windows.Forms.GroupBox groupboxDSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSo;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colPhai;
        private System.Windows.Forms.ColumnHeader colChuyenNganh;
        private System.Windows.Forms.ColumnHeader colHinh;
        private System.Windows.Forms.OpenFileDialog openFileDialogHinh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTongSV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiSua;
        private System.Windows.Forms.ToolStripMenuItem tsmiListView;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiMauChu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSapXep;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLV;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtxFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtxMauChu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtxSapXep;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtxTimKiem;
    }
}

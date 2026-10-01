using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NhapThongTinGiangVien
{
    public partial class frmGiangVien : Form
    {
        private const string WebsiteKhoaCNTT = "https://cntt.dlu.edu.vn/";
        private QuanLyGiangVien qlgv;

        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            this.qlgv = new QuanLyGiangVien();
            SeedSampleGiangVien();

            // Thiết lập link liên kết khoa CNTT
            this.linklbLienHe.Links.Clear();
            this.linklbLienHe.Links.Add(0, linklbLienHe.Text.Length, WebsiteKhoaCNTT);

            // Mặc định chọn mã số đầu tiên
            if (this.cboMaSo.Items.Count > 0)
                this.cboMaSo.SelectedIndex = 0;

            // Cho phép nhấp đôi chuột để chuyển môn nhanh
            this.lbDanhSachHP.DoubleClick += (s, ev) => MoveSelectedItems(lbDanhSachHP, lbHocPhanDay);
            this.lbHocPhanDay.DoubleClick += (s, ev) => MoveSelectedItems(lbHocPhanDay, lbDanhSachHP);
        }

        private void SeedSampleGiangVien()
        {
            var gv1 = new GiangVien
            {
                MaSo = "001",
                GioiTinh = "Nam",
                HoTen = "Nguyễn Văn An",
                NgaySinh = new DateTime(1985, 5, 15),
                Mail = "an.nguyen@cntt.edu.vn",
                SoDT = "(0901).234.567",
                NgoaiNgu = new string[] { "Tiếng Anh" },
                dsHocPhan = new DanhMucHocPhan()
            };
            gv1.dsHocPhan.Them(new HocPhan("Tin học cơ sở"));
            gv1.dsHocPhan.Them(new HocPhan("Lập trình hướng đối tượng"));
            qlgv.Them(gv1);

            var gv2 = new GiangVien
            {
                MaSo = "002",
                GioiTinh = "Nữ",
                HoTen = "Nguyen Thi C",
                NgaySinh = new DateTime(1999, 9, 23, 16, 59, 39),
                Mail = "cc@yahoo.com",
                SoDT = "(0633).333.333",
                NgoaiNgu = new string[] { "Tiếng Anh" },
                dsHocPhan = new DanhMucHocPhan()
            };
            gv2.dsHocPhan.Them(new HocPhan("Phân tích TKHDT"));
            gv2.dsHocPhan.Them(new HocPhan("Lập trình cấu trúc C/C++"));
            qlgv.Them(gv2);
        }

        /// <summary>
        /// Chuyển các mục được chọn từ ListBox nguồn sang ListBox đích.
        /// </summary>
        private void MoveSelectedItems(ListBox source, ListBox destination)
        {
            var selectedItems = source.SelectedItems.Cast<object>().ToList();
            if (selectedItems.Count == 0) return;

            foreach (var item in selectedItems)
            {
                destination.Items.Add(item);
                source.Items.Remove(item);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(this.lbDanhSachHP, this.lbHocPhanDay);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(this.lbHocPhanDay, this.lbDanhSachHP);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        /// <summary>
        /// Khôi phục toàn bộ các điều khiển về trạng thái ban đầu.
        /// </summary>
        public void Reset()
        {
            if (this.cboMaSo.Items.Count > 0)
                this.cboMaSo.SelectedIndex = 0;
            else
                this.cboMaSo.Text = "";

            this.txtHoTen.Clear();
            this.txtMail.Clear();
            this.mtxtSoDT.Clear();
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);

            foreach (object ob in this.lbHocPhanDay.Items)
                this.lbDanhSachHP.Items.Add(ob);
            this.lbHocPhanDay.Items.Clear();

            this.txtHoTen.Focus();
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu nhập trước khi thông báo.
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(this.cboMaSo.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã số giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboMaSo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHoTen.Focus();
                return false;
            }

            return true;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            GiangVien gv = GetGiangVien();
            bool kq = qlgv.Them(gv);
            if (!kq)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (frmTimGiangVien frm = new frmTimGiangVien(this.qlgv))
            {
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Thu thập dữ liệu từ các điều khiển trên form và tạo đối tượng GiangVien.
        /// </summary>
        public GiangVien GetGiangVien()
        {
            string gt = rdNu.Checked ? "Nữ" : "Nam";

            var gv = new GiangVien
            {
                MaSo = this.cboMaSo.Text.Trim(),
                GioiTinh = gt,
                HoTen = this.txtHoTen.Text.Trim(),
                NgaySinh = this.dtpNgaySinh.Value,
                Mail = this.txtMail.Text.Trim(),
                SoDT = this.mtxtSoDT.Text.Trim(),
                NgoaiNgu = this.chklbNgoaiNgu.CheckedItems
                                .Cast<object>()
                                .Select(o => o.ToString())
                                .ToArray()
            };

            var dshp = new DanhMucHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
            {
                dshp.Them(new HocPhan(hp.ToString()));
            }
            gv.dsHocPhan = dshp;

            return gv;
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string strlink = e.Link.LinkData?.ToString() ?? WebsiteKhoaCNTT;
                Process.Start(new ProcessStartInfo(strlink) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở trình duyệt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        private QuanLySinhVien qlsv;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            if (cn.Length > 0)
                cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }

        private void CapNhatTongSV()
        {
            if (this.toolStripStatusLabelTongSV != null && this.lvSinhVien != null)
            {
                this.toolStripStatusLabelTongSV.Text = "Tổng Sinh Viên: " + this.lvSinhVien.Items.Count;
            }
        }

        public void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }
            CapNhatTongSV();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            }
            sv.ChuyenNganh = cn;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;

            DateTime dt;
            if (DateTime.TryParseExact(lvitem.SubItems[2].Text.Trim(),
                new string[] { "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "MM/dd/yyyy" },
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dt))
            {
                sv.NgaySinh = dt;
            }
            else if (DateTime.TryParse(lvitem.SubItems[2].Text.Trim(), out dt))
            {
                sv.NgaySinh = dt;
            }
            else
            {
                sv.NgaySinh = DateTime.Now;
            }

            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;

            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
            {
                if (!string.IsNullOrWhiteSpace(t))
                    cn.Add(t.Trim());
            }
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);

            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (s.CompareTo(this.clbChuyenNganh.Items[i].ToString()) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
                }
            }
        }

        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MaSo.CompareTo(sv1);
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialogHinh.FileName;
                pbHinh.ImageLocation = openFileDialogHinh.FileName;
            }
        }

        private void tsmiMoFile_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiThem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void tsmiSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = lvSinhVien.Font;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lvSinhVien.Font = dlg.Font;
                }
            }
        }

        private void tsmiMauChu_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = lvSinhVien.ForeColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lvSinhVien.ForeColor = dlg.Color;
                }
            }
        }

        private void tsmiSapXep_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(false, this.qlsv, this.lvSinhVien, this.LoadListView))
            {
                frm.ShowDialog();
            }
        }

        private void tsmiTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(true, this.qlsv, this.lvSinhVien, this.LoadListView))
            {
                frm.ShowDialog();
            }
        }
    }
}

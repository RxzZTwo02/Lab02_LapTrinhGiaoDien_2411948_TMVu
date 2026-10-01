using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_LapTrinhGiaoDien_2411948_TMVu
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(lblTienTHA.Text.Replace(".", "").Replace(" đồng", ""));
            if (chkTinHocB.Checked)
                s += int.Parse(lblTienTHB.Text.Replace(".", "").Replace(" đồng", ""));
            if (chkTiengAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Replace(".", "").Replace(" đồng", ""));
            if (chkTiengAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Replace(".", "").Replace(" đồng", ""));
            txtTongTien.Text = s.ToString("#,##0").Replace(",", ".") + " đồng";
        }
        

    }
}

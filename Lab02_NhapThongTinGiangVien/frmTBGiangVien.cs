using System;
using System.Windows.Forms;

namespace Lab02_NhapThongTinGiangVien
{
    public partial class frmTBGiangVien : Form
    {
        public frmTBGiangVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gán chuỗi thông tin cho thuộc tính Text của lblThongBao.
        /// </summary>
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


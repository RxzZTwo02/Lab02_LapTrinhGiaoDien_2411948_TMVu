using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_NhapThongTinGiangVien
{
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhMucHocPhan dsHocPhan { get; set; }
        public string GioiTinh { get; set; }
        public string[] NgoaiNgu { get; set; }
        public string SoDT { get; set; }
        public string Mail { get; set; }

        public GiangVien()
        {
            dsHocPhan = new DanhMucHocPhan();
            NgoaiNgu = new string[0];
            NgaySinh = DateTime.Now;
            GioiTinh = "Nam";
        }

        public GiangVien(string maso, string sdt, string mail, string hoten,
            DateTime ngaysinh, DanhMucHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds ?? new DanhMucHocPhan();
            this.NgoaiNgu = nn ?? new string[0];
            this.SoDT = sdt;
            this.Mail = mail;
            this.GioiTinh = gt;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Mã số: ").Append(MaSo).Append("\n");
            sb.Append("Họ tên: ").Append(HoTen).Append("\n");
            sb.Append("Ngày sinh: ").Append(NgaySinh.ToString("dd/MM/yyyy")).Append("\n");
            sb.Append("Giới tính: ").Append(GioiTinh).Append("\n");
            sb.Append("Số ĐT: ").Append(SoDT).Append("\n");
            sb.Append("Mail: ").Append(Mail).Append("\n\n");

            sb.Append("Ngoại ngữ: ");
            if (NgoaiNgu != null && NgoaiNgu.Length > 0)
            {
                var validNN = NgoaiNgu.Where(n => !string.IsNullOrWhiteSpace(n)).ToArray();
                if (validNN.Length > 0)
                {
                    sb.Append(string.Join(";", validNN)).Append(";");
                }
            }
            sb.Append("\n");

            sb.Append("Danh sách môn dạy: ");
            if (dsHocPhan != null && dsHocPhan.ds != null && dsHocPhan.ds.Count > 0)
            {
                sb.Append(string.Join(";", dsHocPhan.ds.Select(hp => hp.ToString()))).Append(";");
            }

            return sb.ToString();
        }
    }
}


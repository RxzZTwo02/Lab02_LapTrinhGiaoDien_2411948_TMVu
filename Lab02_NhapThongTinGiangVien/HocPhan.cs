using System;

namespace Lab02_NhapThongTinGiangVien
{
    public class HocPhan : IEquatable<HocPhan>
    {
        public int ID { get; set; }
        public string TenHP { get; set; }
        public int SoTC { get; set; }

        public HocPhan()
        {
        }

        public HocPhan(string ten) : this(0, ten, 0)
        {
        }

        public HocPhan(int id, string ten, int tc)
        {
            this.ID = id;
            this.TenHP = ten;
            this.SoTC = tc;
        }

        public override string ToString()
        {
            return TenHP ?? string.Empty;
        }

        public bool Equals(HocPhan other)
        {
            if (other == null) return false;
            if (this.ID > 0 && other.ID > 0)
                return this.ID == other.ID;
            return string.Equals(this.TenHP, other.TenHP, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as HocPhan);
        }

        public override int GetHashCode()
        {
            if (ID > 0) return ID.GetHashCode();
            return TenHP != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(TenHP) : 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_NhapThongTinGiangVien
{
    public class DanhMucHocPhan
    {
        public List<HocPhan> ds { get; set; }

        public int Count => ds.Count;

        public DanhMucHocPhan()
        {
            ds = new List<HocPhan>();
        }

        public DanhMucHocPhan(IEnumerable<HocPhan> collection)
        {
            ds = collection != null ? new List<HocPhan>(collection) : new List<HocPhan>();
        }

        public HocPhan this[int index]
        {
            get
            {
                if (index >= 0 && index < ds.Count)
                    return ds[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < ds.Count)
                    ds[index] = value;
            }
        }

        public void Them(HocPhan hp)
        {
            if (hp != null && !ds.Contains(hp))
            {
                ds.Add(hp);
            }
        }

        public bool Xoa(HocPhan hp)
        {
            return hp != null && ds.Remove(hp);
        }

        public void Clear()
        {
            ds.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Danh sach mon hoc: ");
            foreach (var hp in ds)
            {
                sb.Append(hp).Append(";");
            }
            return sb.ToString();
        }
    }
}


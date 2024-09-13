using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_wf
{
    
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public bool Phai { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Hinh { get; set; }
        public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop, string hinh, bool p,string e,string sdt)
        {
            this.MSSV = ms;
            this.HoVaTen = ht;
            this.NgaySinh = ngay;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.Phai = p;
            this.Email = e;
            this.SoDienThoai = sdt;
        }
        public SinhVien() { }
    }
   
    
    
}

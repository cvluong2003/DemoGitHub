using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class SinhVien
    {
        public string masv { get; set; }
        public string tensv { get; set; }
        public string lop { get; set; }
        public int nv1 { get; set; }
        public int nv2 { get; set; }
        public int nv3 { get; set; }
        public SinhVien()
    {

    }
        public  SinhVien(string masv,string tensv,string lop,int nv1,int nv2,int nv3)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.lop = lop;
            this.nv1 = nv1;
            this.nv2 = nv2;
            this.nv3 = nv3;
        }
    }
}

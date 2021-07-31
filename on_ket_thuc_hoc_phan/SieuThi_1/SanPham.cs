using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThi_1
{
    class sanpham
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string soluong { get; set; }
        public string namsx { get; set; }
        public string mahang { get; set; }
       
        public string tenhang { get; set; }
        public string quocgia { get; set; }
        public sanpham()
        {

        }
        public override bool Equals(object obj)
        {
            sanpham s = (sanpham)obj;
            return this.masp.Equals(s.masp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabPham
{
    [Serializable]
    class sanpham
    {
        public String masp { get; set; }
        public String tensp { get; set; }
        public String soluong { get; set; }
        public String  namsanxuat { get; set; }
        public String mahang { get; set; }
        public String tenhang { get; set; }
        public String quocgia { get; set; }
        public sanpham()
        {

        }
      
    }
}

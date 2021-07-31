using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocVien
{
    [Serializable]
    class HocVien
    {
        public String ma{ get; set; }
        public String ngaysinh{ get; set; }
        public String hoten{ get; set; }
        public String gioitinh{ get; set; }
        public HocVien()
        {

        }
        public HocVien( String hoten, String gioitinh)
        {

            this.hoten = hoten;
            this.gioitinh = gioitinh;
        }
    }
}

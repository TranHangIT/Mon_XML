using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlaibaikhachhang
{
    class KhachHang
    {
        public string makh { get; set; }
        public string chinhanh { get; set; }

        public String hoten { get; set; }
        public string diachi { get; set; }
        public string sodienthoai { get; set; }
        public KhachHang()
        {

        }
        public KhachHang(String hoten, String diachi, String sodienthoai)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }
    }
}

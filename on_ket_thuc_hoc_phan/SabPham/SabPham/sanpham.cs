using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabPham
{
    [Serializable]
    class hangsxS
    {
        public String masp { get; set; }
        public String tensp { get; set; }
        public String mahang { get; set; }
        public String tenhang { get; set; }
        public hangsxS()
        {

        }
        public hangsxS(String mahang, String tenhang)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
        }
      
    }
}

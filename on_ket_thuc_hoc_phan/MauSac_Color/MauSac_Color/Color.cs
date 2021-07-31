using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauSac_Color
{
    class Color
    {
        public String name { get; set; }
        public String data{ get; set; }
        public String special { get; set; }
        public Color()
        {

        }
        public Color(string name, string data, string special)
        {
            this.name = name;
            this.data = data;
            this.special = special;
        }
    }
}

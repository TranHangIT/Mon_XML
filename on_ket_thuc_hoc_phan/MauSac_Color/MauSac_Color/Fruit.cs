using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauSac_Color
{
    class Fruit
    {
        public String name { get; set; }
        public String data{ get; set; }
        public Fruit()
        {

        }
        public Fruit(string name, string data)
        {
            this.name = name;
            this.data = data;
        }
    }
}

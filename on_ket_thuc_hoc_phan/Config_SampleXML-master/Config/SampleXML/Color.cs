using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleXML
{
    class Color
    {
        string name;
        string data;
        string special;
        public Color()
        {

        }
        public Color(string name, string data, string special)
        {
            this.name = name;
            this.data = data;
            this.special = special;
        }
        public string Name { get => name; set => name = value; }
        public string Data { get => data; set => data = value; }
        public string Special { get => special; set => special = value; }
    }
}

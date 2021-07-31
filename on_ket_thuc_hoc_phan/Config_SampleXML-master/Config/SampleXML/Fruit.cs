using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleXML
{
    class Fruit
    {
        string name;
        string data;
        public Fruit()
        {

        }
        public Fruit(string name, string data)
        {
            this.name = name;
            this.data = data;
        }
        public string Name { get => name; set => name = value; }
        public string Data { get => data; set => data = value; }
    }
}

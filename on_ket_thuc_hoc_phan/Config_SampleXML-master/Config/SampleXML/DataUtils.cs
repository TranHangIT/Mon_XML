using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace SampleXML
{
    class DataUtils
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "data.xml";
        public DataUtils()
        {
            fileName = "data.xml";
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public List<Color> getColors()
        {
            List<Color> list = new List<Color>();
            XmlNode colors = root.SelectSingleNode("Colors");
            XmlNodeList nodeList = colors.ChildNodes;
            foreach (XmlNode item in nodeList)
            {
                string name = item.Name;
                string data = item.InnerText;
                string special = "";
                if (item.Attributes.Count > 0)
                    special = item.Attributes[0].InnerText;
                list.Add(new Color(name, data, special));
            }
            return list;
        }
        public List<Fruit> getFruits()
        {
            List<Fruit> list = new List<Fruit>();
            XmlNode fruits = root.SelectSingleNode("Fruits");
            XmlNodeList nodeList = fruits.ChildNodes;
            foreach (XmlNode item in nodeList)
            {
                string name = item.Name;
                string data = item.InnerText;
               
                list.Add(new Fruit(name, data));
            }
            return list;
        }
    }
}

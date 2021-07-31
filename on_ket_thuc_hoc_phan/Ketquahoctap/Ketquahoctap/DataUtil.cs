using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ketquahoctap
{
    class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "lophoc.xml";
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;
            XmlNodeList li = root.SelectNodes("sinhvien");
            int index = 0;
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.SelectSingleNode("masv").InnerText;
                dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("tuoi").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                index++;
            }

        }

    }
}

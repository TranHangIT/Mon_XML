using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyHocVien
{
    
    class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            filename = "DSSV.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;
            int index = 0;

            XmlNodeList li = root.SelectNodes("HocVien");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[1].Value = item.Attributes[2].InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("hoten").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("gioitinh").InnerText;
             
                index++;
            }
        }
    }
}

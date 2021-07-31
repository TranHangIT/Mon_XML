using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lamlaibaikhachhang
{
    class DataUtil
    {

        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            filename = "danhsachkhachhang.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            int index = 0;

            XmlNodeList li = root.SelectNodes("khachhang");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.Attributes[1].InnerText;
                dgv.Rows[index].Cells[1].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("hoten").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                dgv.Rows[index].Cells[4].Value = item.SelectSingleNode("sodt").InnerText;
                index++;
            }
        }
        public void them(KhachHang s)
        {
            XmlNode cantim = root.SelectSingleNode("khachhang[@makh ='" + s.makh + "']");
            if (cantim == null)
            {
                XmlElement st = doc.CreateElement("khachhang");
                st.SetAttribute("makh", s.makh);
                st.SetAttribute("chinhanh", s.chinhanh);

                XmlElement ten = doc.CreateElement("hoten");
                ten.InnerText = s.hoten;

                XmlElement dc = doc.CreateElement("diachi");
                dc.InnerText = s.diachi;

                XmlElement sodt = doc.CreateElement("sodt");
                sodt.InnerText = s.sodienthoai;

                st.AppendChild(ten);
                st.AppendChild(dc);
                st.AppendChild(sodt);

                root.AppendChild(st);

                doc.Save(filename);


            }
            else
            {
                MessageBox.Show("Đã tồn tại mã khách hàng này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

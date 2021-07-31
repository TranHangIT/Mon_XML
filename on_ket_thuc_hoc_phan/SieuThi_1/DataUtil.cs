using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SieuThi_1
{
    class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            filename = "sieuthi.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            int index = 0;

            XmlNodeList li = root.SelectNodes("sanpham");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("namsx").InnerText;


                XmlNodeList li2 = item.SelectNodes("hangsx");
                foreach (XmlNode item2 in li2)
                {
                    dgv.Rows[index].Cells[4].Value = item2.SelectSingleNode("mahang").InnerText;
                    dgv.Rows[index].Cells[5].Value = item2.SelectSingleNode("tenhang").InnerText;
                    dgv.Rows[index].Cells[6].Value = item2.SelectSingleNode("quocgia").InnerText;
                }

                index++;
            }
        }
        public List<sanpham> hienthi_2()
        {
            List<sanpham> lisst = new List<sanpham>();
  
            XmlNodeList li = root.SelectNodes("sanpham");
            foreach (XmlNode item in li)
            {
                sanpham s = new sanpham();
                s.masp = item.Attributes[0].InnerText;
                s.tensp = item.SelectSingleNode("tensp").InnerText;
                s.soluong = item.SelectSingleNode("soluong").InnerText;
                s.namsx = item.SelectSingleNode("namsx").InnerText;


                XmlNodeList li2 = item.SelectNodes("hangsx");
                foreach (XmlNode item2 in li2)
                {
                    s.mahang = item2.SelectSingleNode("mahang").InnerText;
                    s.tenhang = item2.SelectSingleNode("tenhang").InnerText;
                    s.quocgia = item2.SelectSingleNode("quocgia").InnerText;
                }

                lisst.Add(s);
               
            }
            return lisst;
        }
      

        public void them(sanpham s)
        {
            XmlNode cantim = root.SelectSingleNode("sanpham[@masp ='" + s.masp + "']");
            if (cantim == null)
            {
                XmlElement st = doc.CreateElement("sanpham");
                st.SetAttribute("masp", s.masp);


                XmlElement tensp = doc.CreateElement("tensp");
                tensp.InnerText = s.tensp;
                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = s.soluong;
                XmlElement namsx = doc.CreateElement("namsx");
                namsx.InnerText = s.namsx;

                XmlElement hangsx = doc.CreateElement("hangsx");

                XmlElement mahang = doc.CreateElement("mahang");
                mahang.InnerText = s.mahang;
                XmlElement tenhang = doc.CreateElement("tenhang");
                tenhang.InnerText = s.tenhang;
                XmlElement quocgia = doc.CreateElement("quocgia");
                quocgia.InnerText = s.quocgia;

                hangsx.AppendChild(mahang);
                hangsx.AppendChild(tenhang);
                hangsx.AppendChild(quocgia);

                st.AppendChild(tensp);
                st.AppendChild(soluong);
                st.AppendChild(namsx);

                st.AppendChild(hangsx);

                root.AppendChild(st);

                doc.Save(filename);


            }
            else
            {
                MessageBox.Show("Mã sản phẩm này đã tồng tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoa(sanpham s)
        {
            XmlNode cantim = root.SelectSingleNode("sanpham[@masp ='" + s.masp + "']");
            if (cantim != null)
            {
                root.RemoveChild(cantim);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Mã sản phẩm này chưa tồn tại để xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sua(sanpham s)
        {
            XmlNode cantim = root.SelectSingleNode("sanpham[@masp ='" + s.masp + "']");
            if (cantim != null)
            {
                XmlElement st = doc.CreateElement("sanpham");
                st.SetAttribute("masp", s.masp);


                XmlElement tensp = doc.CreateElement("tensp");
                tensp.InnerText = s.tensp;
                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = s.soluong;
                XmlElement namsx = doc.CreateElement("namsx");
                namsx.InnerText = s.namsx;

                XmlElement hangsx = doc.CreateElement("hangsx");

                XmlElement mahang = doc.CreateElement("mahang");
                mahang.InnerText = s.mahang;
                XmlElement tenhang = doc.CreateElement("tenhang");
                tenhang.InnerText = s.tenhang;
                XmlElement quocgia = doc.CreateElement("quocgia");
                quocgia.InnerText = s.quocgia;

                hangsx.AppendChild(mahang);
                hangsx.AppendChild(tenhang);
                hangsx.AppendChild(quocgia);

                st.AppendChild(tensp);
                st.AppendChild(soluong);
                st.AppendChild(namsx);

                st.AppendChild(hangsx);

                root.ReplaceChild(st, cantim);

                doc.Save(filename);


            }
            else
            {
                MessageBox.Show("Mã sản phẩm này không tồn tại để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

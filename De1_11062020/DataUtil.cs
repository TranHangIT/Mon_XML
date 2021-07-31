using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace De1_11062020
{
    class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            filename = "thuvien.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            int index = 0;

            XmlNodeList li = root.SelectNodes("sach");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensach").InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("sotrang").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("tacgia/@hoten").InnerText;
                dgv.Rows[index].Cells[4].Value = item.SelectSingleNode("tacgia/diachi").InnerText;
                index++;
            }
        }
        public void them(Sách s)
        {
            XmlNode cantim = root.SelectSingleNode("sach[@masach ='" + s.masach + "']");
            if (cantim == null)
            {
                XmlElement st = doc.CreateElement("sach");
                st.SetAttribute("masach", s.masach);

                XmlElement ten = doc.CreateElement("tensach");
                ten.InnerText = s.tensach;

                XmlElement sotrang = doc.CreateElement("sotrang");
                sotrang.InnerText = s.sotrang;

                XmlElement tg = doc.CreateElement("tacgia");
                tg.SetAttribute("hoten", s.tentacgia);

                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.diachitacgia;

                tg.AppendChild(diachi);

                st.AppendChild(ten);
                st.AppendChild(sotrang);
                st.AppendChild(tg);

                root.AppendChild(st);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã sách này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sua(Sách s)
        {
            XmlNode cantim = root.SelectSingleNode("sach[@masach ='" + s.masach + "']");
            if (cantim != null)
            {
                XmlElement st = doc.CreateElement("sach");
                st.SetAttribute("masach", s.masach);

                XmlElement ten = doc.CreateElement("tensach");
                ten.InnerText = s.tensach;

                XmlElement sotrang = doc.CreateElement("sotrang");
                sotrang.InnerText = s.sotrang;

                XmlElement tg = doc.CreateElement("tacgia");
                tg.SetAttribute("hoten", s.tentacgia);

                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.diachitacgia;

                tg.AppendChild(diachi);

                st.AppendChild(ten);
                st.AppendChild(sotrang);
                st.AppendChild(tg);

                root.ReplaceChild(st, cantim);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Chưa tồn tại mã sách này để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void tim(String tentacgia, DataGridView dgv)
        {
            XmlNode cantim = root.SelectSingleNode("sach/tacgia[@hoten ='" + tentacgia + "']");
            if (cantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 5;
                int index = 0;

                XmlNodeList li = root.SelectNodes("sach");
                foreach (XmlNode item in li)
                {
                    string k = item.SelectSingleNode("tacgia/@hoten").InnerText;

                    if (k.Equals(tentacgia))
                    {
                        dgv.Rows.Add();
                        dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                        dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensach").InnerText;
                        dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("sotrang").InnerText;
                        dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("tacgia/@hoten").InnerText;
                        dgv.Rows[index].Cells[4].Value = item.SelectSingleNode("tacgia/diachi").InnerText;
                        index++;
                    }

                }
            }
            else
            {
                this.hienthi(dgv);
                MessageBox.Show("Không tồn tại tên tác giả này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace De_4
{
    class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;

        public DataUtil()
        {
            filename = "Thongtincuocgoi.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            int index = 0;

            XmlNodeList li = root.SelectNodes("cuocgoi");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = index+1;
                dgv.Rows[index].Cells[1].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("sogoiden").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("ngaygoi").InnerText;
                dgv.Rows[index].Cells[4].Value = item.SelectSingleNode("sophut").InnerText;
                index++;
            }
        }
        public void them(CuocGoi s)
        {
            XmlNode cantim = root.SelectSingleNode("cuocgoi[@sogoi ='" +s.sogoidi+ "']");
            if (cantim == null)
            {
                XmlElement st = doc.CreateElement("cuocgoi");
                st.SetAttribute("sogoi", s.sogoidi);
               
                XmlElement ten = doc.CreateElement("sogoiden");
                ten.InnerText = s.sogoiden;

                XmlElement dc = doc.CreateElement("ngaygoi");
                dc.InnerText = s.ngaygoi;

                XmlElement sodt = doc.CreateElement("sophut");
                sodt.InnerText = s.sophut;

                st.AppendChild(ten);
                st.AppendChild(dc);
                st.AppendChild(sodt);

                root.AppendChild(st);

                doc.Save(filename);


            }
            else
            {
                MessageBox.Show("Đã tồn tại mã  cuộc gọi này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sua(CuocGoi s)
        {
            XmlNode cantim = root.SelectSingleNode("cuocgoi[@sogoi ='" + s.sogoidi + "']");
            if (cantim != null)
            {
                XmlElement st = doc.CreateElement("cuocgoi");
                st.SetAttribute("sogoi", s.sogoidi);

                XmlElement ten = doc.CreateElement("sogoiden");
                ten.InnerText = s.sogoiden;

                XmlElement dc = doc.CreateElement("ngaygoi");
                dc.InnerText = s.ngaygoi;

                XmlElement sodt = doc.CreateElement("sophut");
                sodt.InnerText = s.sophut;

                st.AppendChild(ten);
                st.AppendChild(dc);
                st.AppendChild(sodt);

                root.ReplaceChild(st,cantim);

                doc.Save(filename);


            }
            else
            {
                MessageBox.Show("Chưa tồn tại mã cuộc gọi này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoa(CuocGoi s)
        {
            XmlNode cantim = root.SelectSingleNode("cuocgoi[@sogoi ='" + s.sogoidi + "']");
            if (cantim != null)
            {
                root.RemoveChild(cantim);
                doc.Save(filename);
               
            }
            else
            {
                MessageBox.Show("Chưa tồn tại mã cuộc gọi này  để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

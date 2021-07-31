using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;   

namespace DemoFormXML
{
    class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "SieuThi.xml";
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void HienThi(DataGridView dgv,Label lblSoLuongSP,Label lblSoLuongCacSP)
        {
            int index = 0;
            int soLuongCacSP = 0;
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            XmlNodeList li = root.SelectNodes("sanpham");
            foreach (XmlNode item in li)
            {
                dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
                dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
                dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("namsanxuat").InnerText;
                XmlNode hangsx = item.SelectSingleNode("hangsx");
                dgv.Rows[index].Cells[4].Value = hangsx.SelectSingleNode("mahang").InnerText;
                dgv.Rows[index].Cells[5].Value = hangsx.SelectSingleNode("tenhang").InnerText;
                dgv.Rows[index].Cells[6].Value = hangsx.SelectSingleNode("quocgia").InnerText;
                index++;
                soLuongCacSP += int.Parse(item.SelectSingleNode("soluong").InnerText);
            }
            lblSoLuongSP.Text = "Số lượng sản phẩm " +  index;
            lblSoLuongCacSP.Text = "Số lượng các sản phẩm " + soLuongCacSP;
        }
        public bool Them(SanPham s)
        {
            try
            {
                XmlElement sp = doc.CreateElement("sanpham");
                sp.SetAttribute("masp", s.masp);

                XmlElement tensp = doc.CreateElement("tensp");
                tensp.InnerText = s.tensp;

                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = s.soluong.ToString();

                XmlElement namsanxuat = doc.CreateElement("namsanxuat");
                namsanxuat.InnerText = s.namsanxuat.ToString();

                XmlElement mahang = doc.CreateElement("mahang");
                mahang.InnerText = s.mahang;

                XmlElement tenhang = doc.CreateElement("tenhang");
                tenhang.InnerText = s.tenhang;

                XmlElement quocgia = doc.CreateElement("quocgia");
                quocgia.InnerText = s.quocgia;

                sp.AppendChild(tensp);
                sp.AppendChild(soluong);
                sp.AppendChild(namsanxuat);

                XmlElement hangsx = doc.CreateElement("hangsx");
                hangsx.AppendChild(mahang);
                hangsx.AppendChild(tenhang);
                hangsx.AppendChild(quocgia);

                sp.AppendChild(hangsx);

                root.AppendChild(sp);

                doc.Save(filename);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public Boolean Sua(SanPham s)
        {
            XmlNode spcantim = root.SelectSingleNode("sanpham[@masp='" + s.masp + "']");
            if (spcantim != null)
            {
                XmlElement sp = doc.CreateElement("sanpham");
                sp.SetAttribute("masp", s.masp);

                XmlElement tensp = doc.CreateElement("tensp");
                tensp.InnerText = s.tensp;

                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = s.soluong.ToString();

                XmlElement namsanxuat = doc.CreateElement("namsanxuat");
                namsanxuat.InnerText = s.namsanxuat.ToString();

                XmlElement mahang = doc.CreateElement("mahang");
                mahang.InnerText = s.mahang;

                XmlElement tenhang = doc.CreateElement("tenhang");
                tenhang.InnerText = s.tenhang;

                XmlElement quocgia = doc.CreateElement("quocgia");
                quocgia.InnerText = s.quocgia;

                sp.AppendChild(tensp);
                sp.AppendChild(soluong);
                sp.AppendChild(namsanxuat);

                XmlElement hangsx = doc.CreateElement("hangsx");
                hangsx.AppendChild(mahang);
                hangsx.AppendChild(tenhang);
                hangsx.AppendChild(quocgia);

                sp.AppendChild(hangsx);

                root.ReplaceChild(sp, spcantim);

                doc.Save(filename);

                return true;
            }
            return false;
        }
        public Boolean Xoa(string masp)
        {
            XmlNode svcantim = root.SelectSingleNode("sanpham[@masp='" + masp + "']");
            if (svcantim != null)
            {
                root.RemoveChild(svcantim);

                doc.Save(filename);

                return true;
            }
            return false;
        }

        public void TimKiem(string masp, DataGridView dgv)
        {
            XmlNode spcantim = root.SelectSingleNode("sanpham[@masp='" + masp + "']");
            if (spcantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 7;
                dgv.Rows[0].Cells[0].Value = spcantim.Attributes[0].InnerText;
                dgv.Rows[0].Cells[1].Value = spcantim.SelectSingleNode("tensp").InnerText;
                dgv.Rows[0].Cells[2].Value = spcantim.SelectSingleNode("soluong").InnerText;
                dgv.Rows[0].Cells[3].Value = spcantim.SelectSingleNode("namsanxuat").InnerText;
                XmlNode hangsx = spcantim.SelectSingleNode("hangsx");
                dgv.Rows[0].Cells[4].Value = hangsx.SelectSingleNode("mahang").InnerText;
                dgv.Rows[0].Cells[5].Value = hangsx.SelectSingleNode("tenhang").InnerText;
                dgv.Rows[0].Cells[6].Value = hangsx.SelectSingleNode("quocgia").InnerText;
            }
        }
        public void timKiemMaHang(string mahang, DataGridView dgv, Label lblSoLuongCacSP)
        {
            int index = 0;
            int soLuongCacSP = 0;
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            XmlNodeList li = root.SelectNodes("sanpham");
            foreach (XmlNode item in li)
            {
                XmlNode hangsx = item.SelectSingleNode("hangsx");
                if (hangsx.SelectSingleNode("mahang").InnerText.Equals(mahang))
                {
                    dgv.Rows.Add();
                    soLuongCacSP += int.Parse(item.SelectSingleNode("soluong").InnerText);
                    dgv.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                    dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
                    dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
                    dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("namsanxuat").InnerText;
                    dgv.Rows[index].Cells[4].Value = hangsx.SelectSingleNode("mahang").InnerText;
                    dgv.Rows[index].Cells[5].Value = hangsx.SelectSingleNode("tenhang").InnerText;
                    dgv.Rows[index].Cells[6].Value = hangsx.SelectSingleNode("quocgia").InnerText;
                    index++;
                }
            }
            lblSoLuongCacSP.Text = "Số lượng các sản phẩm " + soLuongCacSP;
        }
    }
}

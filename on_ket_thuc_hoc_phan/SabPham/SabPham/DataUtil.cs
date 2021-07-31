using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SabPham
{
    class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "sieuThi.xml";
            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public void HienThi(DataGridView dgv)
        {
            //    int index = 0;
            //    //int soLuongCacSP = 0;
            //    dgv.Rows.Clear();
            //    dgv.ColumnCount = 7;
            //    XmlNodeList li = root.SelectNodes("sanpham");
            //    foreach (XmlNode item in li)
            //    {
            //        dgv.Rows.Add();
            //        dgv.Rows[index].Cells[0].Value = item.SelectSingleNode("masp").InnerText;
            //        dgv.Rows[index].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
            //        dgv.Rows[index].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
            //        //dgv.Rows[index].Cells[3].Value = item.SelectSingleNode("namsanxuat").InnerText;
            //        XmlNode hangsx = item.SelectSingleNode("hangsx");
            //        dgv.Rows[index].Cells[4].Value = hangsx.Attributes[3].InnerText;
            //        dgv.Rows[index].Cells[5].Value = hangsx.Attributes[4].InnerText;
            //        dgv.Rows[index].Cells[6].Value = hangsx.SelectSingleNode("quocgia").InnerText;
            //        index++;

            //    }
            string user = root.SelectSingleNode("user").InnerText;
            string password = root.SelectSingleNode("password").InnerText;
            List<hangsxS> books = new List<hangsxS>();
            XmlNode books_XML = root.SelectSingleNode("books");
            XmlNodeList book_XML = books_XML.SelectNodes("book");
            foreach (XmlNode x in book_XML)
            {
                string author = x.Attributes[0].InnerText;
                string title = x.Attributes[1].InnerText;
                books.Add(new Book(author, title));
            }
            Config rs = new Config(user, password, books);
            return rs;

        }

        public void them(hangsxS s)
        {
            XmlNode cantim = root.SelectSingleNode("sanpham[@masp ='" + s.masp + "']");
            if (cantim == null)
            {
                XmlElement st = doc.CreateElement("sanpham");// bat buoc phai tao den dday

                
                XmlElement ma = doc.CreateElement("masp");
                ma.InnerText = s.masp;
                XmlElement ten = doc.CreateElement("tensp");
                ten.InnerText = s.tensp;
                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = s.soluong.ToString();

                XmlElement namsanxuat = doc.CreateElement("namsanxuat");
                namsanxuat.InnerText = s.namsanxuat.ToString();
                st.SetAttribute("mahang", s.mahang);
                st.SetAttribute("tenhang", s.tenhang);
                XmlElement quocgia = doc.CreateElement("quocgia");
                quocgia.InnerText = s.quocgia;

                st.AppendChild(ma);
                st.AppendChild(ten);
                st.AppendChild(soluong);
                st.AppendChild(namsanxuat);
                st.AppendChild(quocgia);
                

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


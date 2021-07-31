using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tentep = @"D:\XML\DeThi\DeThi\thuvien.xml";
        int d;
        XmlDocument doc = new XmlDocument();
        void HienThi()
        {
            doc.Load(tentep);
            int sd = 0;
            XmlNodeList thuvien = doc.SelectNodes("thuvien/sach");
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows.Add();
            foreach (XmlNode sach in thuvien)
            {
                XmlNode ma = sach.SelectSingleNode("@masach");
                XmlNode tensach = sach.SelectSingleNode("tensach");
                XmlNode sotrang = sach.SelectSingleNode("sotrang");
                XmlNode tentg = sach.SelectSingleNode("tacgia/@hoten");
                XmlNode diachi = sach.SelectSingleNode("tacgia/diachi");

                dataGridView1.Rows[sd].Cells[0].Value = ma.InnerText.ToString();
                dataGridView1.Rows[sd].Cells[1].Value = tensach.InnerText.ToString();
                dataGridView1.Rows[sd].Cells[2].Value = sotrang.InnerText.ToString();
                dataGridView1.Rows[sd].Cells[3].Value = tentg.InnerText.ToString();
                dataGridView1.Rows[sd].Cells[4].Value = diachi.InnerText.ToString();

                dataGridView1.Rows.Add();
                sd++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_ma.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txt_tensach.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txt_sotrang.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txt_tentg.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode sach = doc.CreateElement("sach");
            XmlAttribute masach = doc.CreateAttribute("masach");            
            XmlElement tensach = doc.CreateElement("tensach");
            XmlElement sotrang = doc.CreateElement("sotrang");
            XmlNode tacgia = doc.CreateElement("tacgia");
            XmlAttribute hoten = doc.CreateAttribute("hoten");
            XmlElement diachi = doc.CreateElement("diachi");

            masach.InnerText = txt_ma.Text;
            sach.Attributes.Append(masach);

            tensach.InnerText = txt_tensach.Text;
            sach.AppendChild(tensach);

            sotrang.InnerText = txt_sotrang.Text;
            sach.AppendChild(sotrang);

            hoten.InnerText = txt_tentg.Text;
            tacgia.Attributes.Append(hoten);
            diachi.InnerText = txt_diachi.Text;
            tacgia.AppendChild(diachi);
            sach.AppendChild(tacgia);

            XmlNode sach_co = goc.SelectSingleNode("/thuvien/sach[@masach='" + txt_ma.Text + "']");
            if(sach_co != null){
                MessageBox.Show("Trùng mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                goc.AppendChild(sach);
                doc.Save(tentep);
                HienThi();
            }


        }

        private void butCapNhat_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode sach_cu = goc.SelectSingleNode("/thuvien/sach[@masach='" + txt_ma.Text + "']");
            XmlNode sach = doc.CreateElement("sach");
            XmlAttribute masach = doc.CreateAttribute("masach");
            XmlElement tensach = doc.CreateElement("tensach");
            XmlElement sotrang = doc.CreateElement("sotrang");
            XmlNode tacgia = doc.CreateElement("tacgia");
            XmlAttribute hoten = doc.CreateAttribute("hoten");
            XmlElement diachi = doc.CreateElement("diachi");

            masach.InnerText = txt_ma.Text;
            sach.Attributes.Append(masach);

            tensach.InnerText = txt_tensach.Text;
            sach.AppendChild(tensach);

            sotrang.InnerText = txt_sotrang.Text;
            sach.AppendChild(sotrang);

            hoten.InnerText = txt_tentg.Text;
            tacgia.Attributes.Append(hoten);
            diachi.InnerText = txt_diachi.Text;
            tacgia.AppendChild(diachi);
            sach.AppendChild(tacgia);

            goc.ReplaceChild(sach, sach_cu);
            doc.Save(tentep);
            HienThi();
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            int sd = 0;
            XmlNodeList thuvien = doc.SelectNodes("thuvien/sach");
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows.Add();
            int f = 0;
            foreach (XmlNode sach in thuvien)
            {
                XmlNode ma = sach.SelectSingleNode("@masach");
                XmlNode tensach = sach.SelectSingleNode("tensach");
                XmlNode sotrang = sach.SelectSingleNode("sotrang");
                XmlNode tentg = sach.SelectSingleNode("tacgia/@hoten");
                XmlNode diachi = sach.SelectSingleNode("tacgia/diachi");
                if (tentg.InnerText.ToString() == txt_tentg.Text)
                {
                    dataGridView1.Rows[sd].Cells[0].Value = ma.InnerText.ToString();
                    dataGridView1.Rows[sd].Cells[1].Value = tensach.InnerText.ToString();
                    dataGridView1.Rows[sd].Cells[2].Value = sotrang.InnerText.ToString();
                    dataGridView1.Rows[sd].Cells[3].Value = tentg.InnerText.ToString();
                    dataGridView1.Rows[sd].Cells[4].Value = diachi.InnerText.ToString();
                    f = 1;
                    dataGridView1.Rows.Add();
                    sd++;
                }
                
            }
            if(f == 0)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HienThi();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_11062020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            data.hienthi(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txt_ma.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txt_tensach.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txt_sotrang.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txt_tentg.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txt_diachi.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
            }
            catch (Exception eee)
            {
                MessageBox.Show("Có lỗi " + eee.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if(txt_ma.Text !=""&&txt_tensach.Text!=""&&txt_sotrang.Text != "" && txt_tentg.Text != "" && txt_diachi.Text != "")
            {
                Sách s = new Sách();
                s.masach = txt_ma.Text;
                s.tensach = txt_tensach.Text;
                s.sotrang = txt_sotrang.Text;
                s.tentacgia = txt_tentg.Text;
                s.diachitacgia = txt_diachi.Text;
                data.them(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCapNhat_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text != "" && txt_tensach.Text != "" && txt_sotrang.Text != "" && txt_tentg.Text != "" && txt_diachi.Text != "")
            {
                Sách s = new Sách();
                s.masach = txt_ma.Text;
                s.tensach = txt_tensach.Text;
                s.sotrang = txt_sotrang.Text;
                s.tentacgia = txt_tentg.Text;
                s.diachitacgia = txt_diachi.Text;
                data.sua(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            if(txt_tentg.Text != "")
            {
                data.tim(txt_tentg.Text, dataGridView1);
            }
            else
            {
                MessageBox.Show("Phải nhập họ tên tác giả để tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDanhSachBanDau(object sender, EventArgs e)
        {
            data.hienthi(dataGridView1);
        }
    }
}
